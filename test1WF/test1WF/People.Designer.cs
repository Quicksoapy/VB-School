﻿namespace test1WF
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPerson4
            // 
            this.pbPerson4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPerson4.Location = new System.Drawing.Point(420, 447);
            this.pbPerson4.Name = "pbPerson4";
            this.pbPerson4.Size = new System.Drawing.Size(350, 350);
            this.pbPerson4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerson4.TabIndex = 7;
            this.pbPerson4.TabStop = false;
            this.pbPerson4.Click += new System.EventHandler(this.pbPerson4_Click);
            // 
            // pbPerson3
            // 
            this.pbPerson3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPerson3.Location = new System.Drawing.Point(12, 447);
            this.pbPerson3.Name = "pbPerson3";
            this.pbPerson3.Size = new System.Drawing.Size(350, 350);
            this.pbPerson3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerson3.TabIndex = 6;
            this.pbPerson3.TabStop = false;
            this.pbPerson3.Click += new System.EventHandler(this.pbPerson3_Click);
            // 
            // pbPerson2
            // 
            this.pbPerson2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbPerson2.Location = new System.Drawing.Point(420, 68);
            this.pbPerson2.Name = "pbPerson2";
            this.pbPerson2.Size = new System.Drawing.Size(350, 350);
            this.pbPerson2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerson2.TabIndex = 5;
            this.pbPerson2.TabStop = false;
            this.pbPerson2.Click += new System.EventHandler(this.pbPerson2_Click);
            // 
            // pbPerson1
            // 
            this.pbPerson1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPerson1.Location = new System.Drawing.Point(12, 68);
            this.pbPerson1.Name = "pbPerson1";
            this.pbPerson1.Size = new System.Drawing.Size(350, 350);
            this.pbPerson1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerson1.TabIndex = 4;
            this.pbPerson1.TabStop = false;
            this.pbPerson1.Click += new System.EventHandler(this.pbPerson1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Good guess streak:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(45, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "0";
            // 
            // People
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 803);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbPerson4);
            this.Controls.Add(this.pbPerson3);
            this.Controls.Add(this.pbPerson2);
            this.Controls.Add(this.pbPerson1);
            this.Name = "People";
            this.Text = "People";
            this.Load += new System.EventHandler(this.People_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPerson4;
        private System.Windows.Forms.PictureBox pbPerson3;
        private System.Windows.Forms.PictureBox pbPerson2;
        private System.Windows.Forms.PictureBox pbPerson1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}