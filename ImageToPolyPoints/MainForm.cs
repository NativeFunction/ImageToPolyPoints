using Classes.ImageToPolyPoints;
using ImageToPolyPoints.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ImageToPolyPoints
{
    public partial class MainForm : Form
    {
        private PolyPointGenerator Generator = null;
        private float GeneratorAccuracy = 1f;
        private Size PointOrigin = default(Size);
        private List<Point> Points = null;
        private PolyPointImage PolyPointImage = null;

        public MainForm()
        {
            InitializeComponent();
            PointColorButton.ForeColor = DefaultBackColor;
        }

        #region Functions

        private void CloseImage()
        {
            if (Generator != null)
            {
                Generator.Close();
                Generator = null;
            }
            Points = null;
            if (PolyPointImage != null)
            {
                PolyPointImage.Close();
                PolyPointImage = null;
            }
            TextBoxOutput.Clear();
            PointOrigin = new Size(0, 0);
            PointOriginXTextBox.Text = "0";
            PointOriginYTextBox.Text = "0";
            GeneratorAccuracy = 1f;
            ConvertingImageBox.Invalidate();
        }

        private float GetZoomFromBox()
        {
            if (ZoomBox.Text.Contains(" "))
            {
                string[] ZoomPercent = ZoomBox.Text.Split(' ');
                if (Int32.TryParse(ZoomPercent[0], out int zoom))
                {
                    if (zoom > 0)
                        return zoom / 100f;
                }
            }
            return 1f;
        }

        private void OutputPoints()
        {
            string s = "";
            foreach (Point p in Points)
            {
                s += $"{p.X}, {p.Y}\r\n";
            }
            TextBoxOutput.Text = s;
        }

        private void PointOriginTextBoxUpdateText()
        {
            if (Generator != null && PolyPointImage != null)
            {
                if (Int32.TryParse(PointOriginXTextBox.Text, out int PointOriginX) && Int32.TryParse(PointOriginYTextBox.Text, out int PointOriginY))
                {
                    PointOrigin = new Size(PointOriginX, PointOriginY);
                    PolyPointImage.PointOrigin = PointOrigin;
                    Points = Generator.GenerateAsList(GeneratorAccuracy, PointOrigin);
                    ConvertingImageBox.Invalidate();
                    OutputPoints();
                }
            }
        }

        #endregion Functions

        #region Events

        private void AccuracyTextBox_TextChange(object sender, EventArgs e)
        {
            if (Generator != null && PolyPointImage != null)
            {
                if (float.TryParse(TextBoxAccuracy.Text, out float accuracy))
                {
                    GeneratorAccuracy = accuracy;
                    Points = Generator.GenerateAsList(GeneratorAccuracy, PointOrigin);
                    ConvertingImageBox.Invalidate();
                    OutputPoints();
                }
            }
        }

        private void ButtonPointOriginGetCenter_Click(object sender, EventArgs e)
        {
            if (Generator != null)
            {
                PointOriginXTextBox.Text = (Generator.Image.Size.Width / 2).ToString();
                PointOriginYTextBox.Text = (Generator.Image.Size.Height / 2).ToString();
                PointOriginTextBoxUpdateText();
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseImage();
        }

        private void ConvertingImageBox_Paint(object sender, PaintEventArgs e)
        {
            if (Generator != null && Points != null)
            {
                PolyPointImage.Refresh(e.Graphics, Generator.Image, Points);
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Open Image";
                ofd.Filter = "png files (*.png)|*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    CloseImage();

                    Generator = new PolyPointGenerator(new Bitmap(ofd.FileName));

                    if (float.TryParse(TextBoxAccuracy.Text, out float acc))
                        GeneratorAccuracy = acc;

                    if (Int32.TryParse(PointOriginXTextBox.Text, out int PointOriginX) && Int32.TryParse(PointOriginYTextBox.Text, out int PointOriginY))
                        PointOrigin = new Size(PointOriginX, PointOriginY);

                    Points = Generator.GenerateAsList(GeneratorAccuracy, PointOrigin);

                    PolyPointImage = new PolyPointImage(ConvertingImageBox.CreateGraphics(), ConvertingImageBox.BackColor, PointColorDialog.Color)
                    {
                        PointOrigin = PointOrigin,
                        Zoom = GetZoomFromBox()
                    };

                    ConvertingImageBox.Size = new Size((int)Math.Ceiling(Generator.Image.Size.Width * PolyPointImage.Zoom),
                    (int)Math.Ceiling(Generator.Image.Size.Height * PolyPointImage.Zoom));

                    if (Int32.TryParse(TextBoxPointDisplaySize.Text, out int o))
                        PolyPointImage.PointSize = o;

                    ConvertingImageBox.Invalidate();

                    OutputPoints();
                }
            }
        }

        private void PointColorButton_Click(object sender, EventArgs e)
        {
            PointColorDialog.ShowDialog();

            if (PolyPointImage != null)
            {
                if (PointColorDialog.Color != PolyPointImage.PointColor)
                {
                    PolyPointImage.PointColor = PointColorDialog.Color;
                    ConvertingImageBox.Invalidate();
                }
            }

            PointColorButton.BackColor = PointColorDialog.Color;
        }

        private void PointDisplaySizeTextBox_TextChange(object sender, EventArgs e)
        {
            if (PolyPointImage != null && float.TryParse(TextBoxPointDisplaySize.Text, out float o))
            {
                PolyPointImage.PointSize = o;
                ConvertingImageBox.Invalidate();
            }
        }

        private void PointOriginTextBox_TextChange(object sender, EventArgs e)
        {
            PointOriginTextBoxUpdateText();
        }

        private void ZoomComboBox_TextChange(object sender, EventArgs e)
        {
            if (PolyPointImage != null)
            {
                PolyPointImage.Zoom = GetZoomFromBox();
                ConvertingImageBox.Size = new Size((int)Math.Ceiling(Generator.Image.Size.Width * PolyPointImage.Zoom),
                    (int)Math.Ceiling(Generator.Image.Size.Height * PolyPointImage.Zoom));
                ConvertingImageBox.Invalidate();
            }
        }

        #endregion Events
    }
}