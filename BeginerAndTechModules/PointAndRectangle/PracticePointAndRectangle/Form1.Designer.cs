namespace PracticePointAndRectangle
{
    partial class FormPointAndRectangle
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
            this.numericUpDownX1 = new System.Windows.Forms.NumericUpDown();
            this.infoRectangle = new System.Windows.Forms.Label();
            this.infoX1 = new System.Windows.Forms.Label();
            this.infoY1 = new System.Windows.Forms.Label();
            this.infoX2 = new System.Windows.Forms.Label();
            this.infoY2 = new System.Windows.Forms.Label();
            this.infoX = new System.Windows.Forms.Label();
            this.infoY = new System.Windows.Forms.Label();
            this.infoPoint = new System.Windows.Forms.Label();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.labelLocation = new System.Windows.Forms.Label();
            this.numericUpDownY1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownX1
            // 
            this.numericUpDownX1.DecimalPlaces = 2;
            this.numericUpDownX1.Location = new System.Drawing.Point(52, 25);
            this.numericUpDownX1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownX1.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownX1.Name = "numericUpDownX1";
            this.numericUpDownX1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownX1.TabIndex = 0;
            this.numericUpDownX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownX1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownX1.ValueChanged += new System.EventHandler(this.numericUpDownX1_ValueChanged);
            // 
            // infoRectangle
            // 
            this.infoRectangle.AutoSize = true;
            this.infoRectangle.Location = new System.Drawing.Point(25, 9);
            this.infoRectangle.Name = "infoRectangle";
            this.infoRectangle.Size = new System.Drawing.Size(59, 13);
            this.infoRectangle.TabIndex = 6;
            this.infoRectangle.Text = "Rectangle:";
            // 
            // infoX1
            // 
            this.infoX1.AutoSize = true;
            this.infoX1.Location = new System.Drawing.Point(11, 27);
            this.infoX1.Name = "infoX1";
            this.infoX1.Size = new System.Drawing.Size(27, 13);
            this.infoX1.TabIndex = 7;
            this.infoX1.Text = "x1 =";
            // 
            // infoY1
            // 
            this.infoY1.AutoSize = true;
            this.infoY1.Location = new System.Drawing.Point(11, 53);
            this.infoY1.Name = "infoY1";
            this.infoY1.Size = new System.Drawing.Size(27, 13);
            this.infoY1.TabIndex = 8;
            this.infoY1.Text = "y1 =";
            // 
            // infoX2
            // 
            this.infoX2.AutoSize = true;
            this.infoX2.Location = new System.Drawing.Point(11, 79);
            this.infoX2.Name = "infoX2";
            this.infoX2.Size = new System.Drawing.Size(27, 13);
            this.infoX2.TabIndex = 9;
            this.infoX2.Text = "x2 =";
            // 
            // infoY2
            // 
            this.infoY2.AutoSize = true;
            this.infoY2.Location = new System.Drawing.Point(10, 105);
            this.infoY2.Name = "infoY2";
            this.infoY2.Size = new System.Drawing.Size(27, 13);
            this.infoY2.TabIndex = 10;
            this.infoY2.Text = "y2 =";
            // 
            // infoX
            // 
            this.infoX.AutoSize = true;
            this.infoX.Location = new System.Drawing.Point(10, 161);
            this.infoX.Name = "infoX";
            this.infoX.Size = new System.Drawing.Size(21, 13);
            this.infoX.TabIndex = 11;
            this.infoX.Text = "x =";
            // 
            // infoY
            // 
            this.infoY.AutoSize = true;
            this.infoY.Location = new System.Drawing.Point(10, 187);
            this.infoY.Name = "infoY";
            this.infoY.Size = new System.Drawing.Size(21, 13);
            this.infoY.TabIndex = 12;
            this.infoY.Text = "y =";
            // 
            // infoPoint
            // 
            this.infoPoint.AutoSize = true;
            this.infoPoint.Location = new System.Drawing.Point(25, 143);
            this.infoPoint.Name = "infoPoint";
            this.infoPoint.Size = new System.Drawing.Size(34, 13);
            this.infoPoint.TabIndex = 13;
            this.infoPoint.Text = "Point:";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(50, 212);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonDraw.TabIndex = 14;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // labelLocation
            // 
            this.labelLocation.BackColor = System.Drawing.Color.PaleGreen;
            this.labelLocation.Location = new System.Drawing.Point(52, 242);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(100, 23);
            this.labelLocation.TabIndex = 15;
            this.labelLocation.Text = "label9";
            this.labelLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownY1
            // 
            this.numericUpDownY1.DecimalPlaces = 2;
            this.numericUpDownY1.Location = new System.Drawing.Point(52, 51);
            this.numericUpDownY1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownY1.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownY1.Name = "numericUpDownY1";
            this.numericUpDownY1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownY1.TabIndex = 16;
            this.numericUpDownY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownY1.Value = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.numericUpDownY1.ValueChanged += new System.EventHandler(this.numericUpDownY1_ValueChanged);
            // 
            // numericUpDownX2
            // 
            this.numericUpDownX2.DecimalPlaces = 2;
            this.numericUpDownX2.Location = new System.Drawing.Point(52, 77);
            this.numericUpDownX2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownX2.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownX2.Name = "numericUpDownX2";
            this.numericUpDownX2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownX2.TabIndex = 17;
            this.numericUpDownX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownX2.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownX2.ValueChanged += new System.EventHandler(this.numericUpDownX2_ValueChanged);
            // 
            // numericUpDownY2
            // 
            this.numericUpDownY2.DecimalPlaces = 2;
            this.numericUpDownY2.Location = new System.Drawing.Point(52, 103);
            this.numericUpDownY2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownY2.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownY2.Name = "numericUpDownY2";
            this.numericUpDownY2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownY2.TabIndex = 18;
            this.numericUpDownY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownY2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownY2.ValueChanged += new System.EventHandler(this.numericUpDownY2_ValueChanged);
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.DecimalPlaces = 2;
            this.numericUpDownX.Location = new System.Drawing.Point(52, 159);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownX.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownX.TabIndex = 19;
            this.numericUpDownX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownX.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownX.ValueChanged += new System.EventHandler(this.numericUpDownX_ValueChanged);
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.DecimalPlaces = 2;
            this.numericUpDownY.Location = new System.Drawing.Point(52, 185);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownY.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownY.TabIndex = 20;
            this.numericUpDownY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownY.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownY.ValueChanged += new System.EventHandler(this.numericUpDownY_ValueChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(192, 13);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(395, 252);
            this.pictureBox.TabIndex = 21;
            this.pictureBox.TabStop = false;
            this.pictureBox.Resize += new System.EventHandler(this.pictureBox_Resize);
            // 
            // FormPointAndRectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 372);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.numericUpDownY);
            this.Controls.Add(this.numericUpDownX);
            this.Controls.Add(this.numericUpDownY2);
            this.Controls.Add(this.numericUpDownX2);
            this.Controls.Add(this.numericUpDownY1);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.infoPoint);
            this.Controls.Add(this.infoY);
            this.Controls.Add(this.infoX);
            this.Controls.Add(this.infoY2);
            this.Controls.Add(this.infoX2);
            this.Controls.Add(this.infoY1);
            this.Controls.Add(this.infoX1);
            this.Controls.Add(this.infoRectangle);
            this.Controls.Add(this.numericUpDownX1);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "FormPointAndRectangle";
            this.Text = "Point and Rectangle";
            this.Load += new System.EventHandler(this.FormPointAndRectangle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownX1;
        private System.Windows.Forms.Label infoRectangle;
        private System.Windows.Forms.Label infoX1;
        private System.Windows.Forms.Label infoY1;
        private System.Windows.Forms.Label infoX2;
        private System.Windows.Forms.Label infoY2;
        private System.Windows.Forms.Label infoX;
        private System.Windows.Forms.Label infoY;
        private System.Windows.Forms.Label infoPoint;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.NumericUpDown numericUpDownY1;
        private System.Windows.Forms.NumericUpDown numericUpDownX2;
        private System.Windows.Forms.NumericUpDown numericUpDownY2;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

