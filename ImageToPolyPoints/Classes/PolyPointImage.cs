using System.Collections.Generic;
using System.Drawing;

namespace ImageToPolyPoints.Classes
{
    internal class PolyPointImage
    {
        public Size PointOrigin = default(Size);
        public float PointSize = 1;
        public float Zoom = 1;

        private Color _backColor;
        private Brush _brush;
        private Graphics _graphics = null;
        private Color _pointColor = Color.Black;

        public PolyPointImage(Graphics graphics, Color backColor, Color pointColor)
        {
            _graphics = graphics;
            _backColor = backColor;
            PointColor = pointColor;
        }

        public Color PointColor
        {
            get { return _pointColor; }
            set
            {
                _pointColor = value;
                _brush = new SolidBrush(_pointColor);
            }
        }

        public void Close()
        {
            _brush.Dispose();
            _graphics.Dispose();
        }

        public void Draw(Bitmap image, List<Point> points)
        {
            _graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            _graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            _graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
            _graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            _graphics.ScaleTransform(Zoom, Zoom);
            _graphics.DrawImage(image, 0, 0, image.Size.Width, image.Size.Height);

            foreach (var i in points)
            {
                _graphics.FillRectangle(_brush,
                    .5f + (i.X + PointOrigin.Width - PointSize / 2), .5f + (i.Y + PointOrigin.Height - PointSize / 2),
                    PointSize, PointSize);
            }
        }

        public void Refresh(Graphics graphics, Bitmap image, List<Point> points)
        {
            UpdateGraphics(graphics);
            Draw(image, points);
        }

        private void UpdateGraphics(Graphics graphics)
        {
            _graphics.Dispose();
            _graphics = graphics;
        }
    }
}