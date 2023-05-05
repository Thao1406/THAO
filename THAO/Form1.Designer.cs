namespace THAO
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
            this.THAO = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // THAO
            // 
            this.THAO.AutoSize = true;
            this.THAO.Location = new System.Drawing.Point(143, 52);
            this.THAO.Name = "THAO";
            this.THAO.Size = new System.Drawing.Size(45, 16);
            this.THAO.TabIndex = 0;
            this.THAO.Text = "THAO";
            this.THAO.Click += new System.EventHandler(this.THAO_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::THAO.Properties.Resources.hii;
            this.pictureBox1.Location = new System.Drawing.Point(285, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 234);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 394);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.THAO);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label THAO;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

