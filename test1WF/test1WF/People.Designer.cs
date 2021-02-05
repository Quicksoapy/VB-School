namespace test1WF
{
    partial class People
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
            this.pbPerson4 = new System.Windows.Forms.PictureBox();
            this.pbPerson3 = new System.Windows.Forms.PictureBox();
            this.pbPerson2 = new System.Windows.Forms.PictureBox();
            this.pbPerson1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPerson4
            // 
            this.pbPerson4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPerson4.Location = new System.Drawing.Point(420, 391);
            this.pbPerson4.Name = "pbPerson4";
            this.pbPerson4.Size = new System.Drawing.Size(350, 350);
            this.pbPerson4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerson4.TabIndex = 7;
            this.pbPerson4.TabStop = false;
            // 
            // pbPerson3
            // 
            this.pbPerson3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPerson3.Location = new System.Drawing.Point(12, 391);
            this.pbPerson3.Name = "pbPerson3";
            this.pbPerson3.Size = new System.Drawing.Size(350, 350);
            this.pbPerson3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerson3.TabIndex = 6;
            this.pbPerson3.TabStop = false;
            // 
            // pbPerson2
            // 
            this.pbPerson2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbPerson2.Location = new System.Drawing.Point(420, 12);
            this.pbPerson2.Name = "pbPerson2";
            this.pbPerson2.Size = new System.Drawing.Size(350, 350);
            this.pbPerson2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerson2.TabIndex = 5;
            this.pbPerson2.TabStop = false;
            // 
            // pbPerson1
            // 
            this.pbPerson1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPerson1.Location = new System.Drawing.Point(12, 12);
            this.pbPerson1.Name = "pbPerson1";
            this.pbPerson1.Size = new System.Drawing.Size(350, 350);
            this.pbPerson1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerson1.TabIndex = 4;
            this.pbPerson1.TabStop = false;
            this.pbPerson1.Click += new System.EventHandler(this.pbPerson1_Click);
            // 
            // People
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.pbPerson4);
            this.Controls.Add(this.pbPerson3);
            this.Controls.Add(this.pbPerson2);
            this.Controls.Add(this.pbPerson1);
            this.Name = "People";
            this.Text = "People";
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPerson4;
        private System.Windows.Forms.PictureBox pbPerson3;
        private System.Windows.Forms.PictureBox pbPerson2;
        private System.Windows.Forms.PictureBox pbPerson1;
    }
}