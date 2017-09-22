namespace PracticeCatchMe
{
    partial class Form1
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
            this.btnCatchMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCatchMe
            // 
            this.btnCatchMe.Location = new System.Drawing.Point(111, 101);
            this.btnCatchMe.Name = "btnCatchMe";
            this.btnCatchMe.Size = new System.Drawing.Size(75, 23);
            this.btnCatchMe.TabIndex = 0;
            this.btnCatchMe.Text = "CatchMe";
            this.btnCatchMe.UseVisualStyleBackColor = true;
            this.btnCatchMe.Enter += new System.EventHandler(this.btnCatchMe_Enter);
            this.btnCatchMe.MouseEnter += new System.EventHandler(this.btnCatchMe_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCatchMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCatchMe;
    }
}

