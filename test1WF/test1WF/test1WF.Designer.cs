namespace test1WF
{
    partial class test1WF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(test1WF));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblMadeby = new System.Windows.Forms.Label();
            this.lblPic = new System.Windows.Forms.Label();
            this.lblPicfrom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(9, 10);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(172, 60);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(406, 10);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(172, 60);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblMadeby
            // 
            this.lblMadeby.AutoSize = true;
            this.lblMadeby.BackColor = System.Drawing.Color.Transparent;
            this.lblMadeby.Location = new System.Drawing.Point(7, 266);
            this.lblMadeby.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMadeby.Name = "lblMadeby";
            this.lblMadeby.Size = new System.Drawing.Size(155, 13);
            this.lblMadeby.TabIndex = 7;
            this.lblMadeby.Text = "Made by Quicksoapy, using C#";
            // 
            // lblPic
            // 
            this.lblPic.BackColor = System.Drawing.Color.Transparent;
            this.lblPic.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPic.Location = new System.Drawing.Point(436, 266);
            this.lblPic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPic.Name = "lblPic";
            this.lblPic.Size = new System.Drawing.Size(141, 23);
            this.lblPic.TabIndex = 8;
            this.lblPic.Text = "thispersondoesnotexist.com";
            this.lblPic.Click += new System.EventHandler(this.lblPic_Click);
            // 
            // lblPicfrom
            // 
            this.lblPicfrom.AutoSize = true;
            this.lblPicfrom.BackColor = System.Drawing.Color.Transparent;
            this.lblPicfrom.Location = new System.Drawing.Point(436, 252);
            this.lblPicfrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPicfrom.Name = "lblPicfrom";
            this.lblPicfrom.Size = new System.Drawing.Size(71, 13);
            this.lblPicfrom.TabIndex = 9;
            this.lblPicfrom.Text = "Pictures from:";
            // 
            // test1WF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::test1WF.Properties.Resources.autism;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 287);
            this.Controls.Add(this.lblPicfrom);
            this.Controls.Add(this.lblPic);
            this.Controls.Add(this.lblMadeby);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "test1WF";
            this.Text = "The Autism Generator";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblMadeby;
        private System.Windows.Forms.Label lblPic;
        private System.Windows.Forms.Label lblPicfrom;
    }
}

