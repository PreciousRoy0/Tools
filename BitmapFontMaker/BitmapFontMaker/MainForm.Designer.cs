namespace BitmapFontMaker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FontComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.FontSizeHeightNumericUpDown = new BitmapFontMaker.ToolStripNumericUpDown();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.HeightNumericUpDown = new BitmapFontMaker.ToolStripNumericUpDown();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.WidthNumericUpDown = new BitmapFontMaker.ToolStripNumericUpDown();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.AboutButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImagePanle = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 585);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(644, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontComboBox,
            this.SaveButton,
            this.FontSizeHeightNumericUpDown,
            this.toolStripSeparator1,
            this.HeightNumericUpDown,
            this.toolStripLabel1,
            this.WidthNumericUpDown,
            this.toolStripLabel2,
            this.AboutButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(644, 26);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FontComboBox
            // 
            this.FontComboBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.FontComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.FontComboBox.Name = "FontComboBox";
            this.FontComboBox.Size = new System.Drawing.Size(121, 26);
            this.FontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontComboBox_SelectedIndexChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Image = global::BitmapFontMaker.Properties.Resources.save;
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(23, 23);
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // FontSizeHeightNumericUpDown
            // 
            this.FontSizeHeightNumericUpDown.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.FontSizeHeightNumericUpDown.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.FontSizeHeightNumericUpDown.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.FontSizeHeightNumericUpDown.Name = "FontSizeHeightNumericUpDown";
            this.FontSizeHeightNumericUpDown.Size = new System.Drawing.Size(41, 23);
            this.FontSizeHeightNumericUpDown.Text = "12";
            this.FontSizeHeightNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.FontSizeHeightNumericUpDown.ValueChanged += new System.EventHandler(this.FontSizeHeightNumericUpDown_ValueChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // HeightNumericUpDown
            // 
            this.HeightNumericUpDown.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.HeightNumericUpDown.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.HeightNumericUpDown.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.HeightNumericUpDown.Name = "HeightNumericUpDown";
            this.HeightNumericUpDown.Size = new System.Drawing.Size(47, 23);
            this.HeightNumericUpDown.Text = "512";
            this.HeightNumericUpDown.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.HeightNumericUpDown.ValueChanged += new System.EventHandler(this.HeightNumericUpDown_ValueChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(46, 23);
            this.toolStripLabel1.Text = "Height:";
            // 
            // WidthNumericUpDown
            // 
            this.WidthNumericUpDown.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.WidthNumericUpDown.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.WidthNumericUpDown.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.WidthNumericUpDown.Name = "WidthNumericUpDown";
            this.WidthNumericUpDown.Size = new System.Drawing.Size(47, 23);
            this.WidthNumericUpDown.Text = "512";
            this.WidthNumericUpDown.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.WidthNumericUpDown.ValueChanged += new System.EventHandler(this.WidthNumericUpDown_ValueChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(42, 23);
            this.toolStripLabel2.Text = "Width:";
            // 
            // AboutButton
            // 
            this.AboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AboutButton.Image = ((System.Drawing.Image)(resources.GetObject("AboutButton.Image")));
            this.AboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(23, 23);
            this.AboutButton.Text = "toolStripButton1";
            this.AboutButton.ToolTipText = "About";
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ImagePanle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 559);
            this.panel1.TabIndex = 4;
            // 
            // ImagePanle
            // 
            this.ImagePanle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagePanle.Location = new System.Drawing.Point(0, 0);
            this.ImagePanle.Name = "ImagePanle";
            this.ImagePanle.Size = new System.Drawing.Size(512, 512);
            this.ImagePanle.TabIndex = 0;
            this.ImagePanle.Paint += new System.Windows.Forms.PaintEventHandler(this.ImagePanle_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 607);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.Text = "Bitmap Font Maker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox FontComboBox;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.Panel panel1;
        private ToolStripNumericUpDown FontSizeHeightNumericUpDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private ToolStripNumericUpDown HeightNumericUpDown;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private ToolStripNumericUpDown WidthNumericUpDown;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Panel ImagePanle;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton AboutButton;
    }
}

