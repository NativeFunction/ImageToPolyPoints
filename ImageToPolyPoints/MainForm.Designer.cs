namespace ImageToPolyPoints
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertingImageBox = new System.Windows.Forms.PictureBox();
            this.TextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.ZoomBox = new System.Windows.Forms.ComboBox();
            this.PointOriginXTextBox = new System.Windows.Forms.TextBox();
            this.PointOriginYTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxPointDisplaySize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxAccuracy = new System.Windows.Forms.TextBox();
            this.ButtonPointOriginGetCenter = new System.Windows.Forms.Button();
            this.PointColorDialog = new System.Windows.Forms.ColorDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.PointColorButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConvertingImageBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(769, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // ConvertingImageBox
            // 
            this.ConvertingImageBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConvertingImageBox.BackColor = System.Drawing.SystemColors.Control;
            this.ConvertingImageBox.Location = new System.Drawing.Point(3, 3);
            this.ConvertingImageBox.Name = "ConvertingImageBox";
            this.ConvertingImageBox.Size = new System.Drawing.Size(467, 374);
            this.ConvertingImageBox.TabIndex = 1;
            this.ConvertingImageBox.TabStop = false;
            this.ConvertingImageBox.Paint += new System.Windows.Forms.PaintEventHandler(this.ConvertingImageBox_Paint);
            // 
            // TextBoxOutput
            // 
            this.TextBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TextBoxOutput.Location = new System.Drawing.Point(13, 82);
            this.TextBoxOutput.Name = "TextBoxOutput";
            this.TextBoxOutput.Size = new System.Drawing.Size(254, 390);
            this.TextBoxOutput.TabIndex = 2;
            this.TextBoxOutput.Text = "";
            // 
            // ZoomBox
            // 
            this.ZoomBox.FormattingEnabled = true;
            this.ZoomBox.Items.AddRange(new object[] {
            "5 %",
            "10 %",
            "25 %",
            "50 %",
            "75 %",
            "100 %",
            "150 %",
            "200 %",
            "300 %",
            "400 %",
            "500 %",
            "750 %",
            "1000 %"});
            this.ZoomBox.Location = new System.Drawing.Point(290, 50);
            this.ZoomBox.Name = "ZoomBox";
            this.ZoomBox.Size = new System.Drawing.Size(83, 24);
            this.ZoomBox.TabIndex = 3;
            this.ZoomBox.Text = "100 %";
            this.ZoomBox.TextChanged += new System.EventHandler(this.ZoomComboBox_TextChange);
            // 
            // PointOriginXTextBox
            // 
            this.PointOriginXTextBox.Location = new System.Drawing.Point(14, 50);
            this.PointOriginXTextBox.Name = "PointOriginXTextBox";
            this.PointOriginXTextBox.Size = new System.Drawing.Size(77, 22);
            this.PointOriginXTextBox.TabIndex = 4;
            this.PointOriginXTextBox.Text = "0";
            this.PointOriginXTextBox.TextChanged += new System.EventHandler(this.PointOriginTextBox_TextChange);
            // 
            // PointOriginYTextBox
            // 
            this.PointOriginYTextBox.Location = new System.Drawing.Point(97, 50);
            this.PointOriginYTextBox.Name = "PointOriginYTextBox";
            this.PointOriginYTextBox.Size = new System.Drawing.Size(75, 22);
            this.PointOriginYTextBox.TabIndex = 5;
            this.PointOriginYTextBox.Text = "0";
            this.PointOriginYTextBox.TextChanged += new System.EventHandler(this.PointOriginTextBox_TextChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Point Origin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Zoom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Point Display Size";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxPointDisplaySize
            // 
            this.TextBoxPointDisplaySize.Location = new System.Drawing.Point(542, 50);
            this.TextBoxPointDisplaySize.Name = "TextBoxPointDisplaySize";
            this.TextBoxPointDisplaySize.Size = new System.Drawing.Size(77, 22);
            this.TextBoxPointDisplaySize.TabIndex = 8;
            this.TextBoxPointDisplaySize.Text = "1.0";
            this.TextBoxPointDisplaySize.TextChanged += new System.EventHandler(this.PointDisplaySizeTextBox_TextChange);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Accuracy";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxAccuracy
            // 
            this.TextBoxAccuracy.Location = new System.Drawing.Point(418, 50);
            this.TextBoxAccuracy.Name = "TextBoxAccuracy";
            this.TextBoxAccuracy.Size = new System.Drawing.Size(77, 22);
            this.TextBoxAccuracy.TabIndex = 11;
            this.TextBoxAccuracy.Text = "1.0";
            this.TextBoxAccuracy.TextChanged += new System.EventHandler(this.AccuracyTextBox_TextChange);
            // 
            // ButtonPointOriginGetCenter
            // 
            this.ButtonPointOriginGetCenter.Location = new System.Drawing.Point(178, 50);
            this.ButtonPointOriginGetCenter.Name = "ButtonPointOriginGetCenter";
            this.ButtonPointOriginGetCenter.Size = new System.Drawing.Size(89, 23);
            this.ButtonPointOriginGetCenter.TabIndex = 13;
            this.ButtonPointOriginGetCenter.Text = "Get Center";
            this.ButtonPointOriginGetCenter.UseVisualStyleBackColor = true;
            this.ButtonPointOriginGetCenter.Click += new System.EventHandler(this.ButtonPointOriginGetCenter_Click);
            // 
            // PointColorDialog
            // 
            this.PointColorDialog.AnyColor = true;
            this.PointColorDialog.FullOpen = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(666, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Point Color";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PointColorButton
            // 
            this.PointColorButton.BackColor = System.Drawing.Color.Black;
            this.PointColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PointColorButton.Location = new System.Drawing.Point(682, 49);
            this.PointColorButton.Name = "PointColorButton";
            this.PointColorButton.Size = new System.Drawing.Size(45, 23);
            this.PointColorButton.TabIndex = 15;
            this.PointColorButton.UseVisualStyleBackColor = false;
            this.PointColorButton.Click += new System.EventHandler(this.PointColorButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.ConvertingImageBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(273, 82);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(484, 390);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 484);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.PointColorButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ButtonPointOriginGetCenter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxAccuracy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxPointDisplaySize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PointOriginYTextBox);
            this.Controls.Add(this.PointOriginXTextBox);
            this.Controls.Add(this.ZoomBox);
            this.Controls.Add(this.TextBoxOutput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(787, 531);
            this.Name = "MainForm";
            this.Text = "ImageToPolyPoints";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConvertingImageBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.PictureBox ConvertingImageBox;
		private System.Windows.Forms.RichTextBox TextBoxOutput;
		private System.Windows.Forms.ComboBox ZoomBox;
		private System.Windows.Forms.TextBox PointOriginXTextBox;
		private System.Windows.Forms.TextBox PointOriginYTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TextBoxPointDisplaySize;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TextBoxAccuracy;
		private System.Windows.Forms.Button ButtonPointOriginGetCenter;
        private System.Windows.Forms.ColorDialog PointColorDialog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button PointColorButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

