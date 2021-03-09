namespace Launcher
{
    partial class frmMain
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
            this.lblDarkMode = new System.Windows.Forms.Label();
            this.lblLightMode = new System.Windows.Forms.Label();
            this.lblReset = new System.Windows.Forms.Label();
            this.pbCustom2 = new System.Windows.Forms.PictureBox();
            this.pbCustom1 = new System.Windows.Forms.PictureBox();
            this.pbDiscord = new System.Windows.Forms.PictureBox();
            this.pbSteam = new System.Windows.Forms.PictureBox();
            this.txtCustom1 = new System.Windows.Forms.TextBox();
            this.txtCustom2 = new System.Windows.Forms.TextBox();
            this.btnCustom1 = new System.Windows.Forms.Button();
            this.btnCustom2 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.sfdSavetime = new System.Windows.Forms.SaveFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSteam)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDarkMode
            // 
            this.lblDarkMode.AutoSize = true;
            this.lblDarkMode.Location = new System.Drawing.Point(12, 330);
            this.lblDarkMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDarkMode.Name = "lblDarkMode";
            this.lblDarkMode.Size = new System.Drawing.Size(77, 17);
            this.lblDarkMode.TabIndex = 0;
            this.lblDarkMode.Text = "Dark Mode";
            this.lblDarkMode.Click += new System.EventHandler(this.lblDarkMode_Click);
            // 
            // lblLightMode
            // 
            this.lblLightMode.AutoSize = true;
            this.lblLightMode.Location = new System.Drawing.Point(11, 313);
            this.lblLightMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLightMode.Name = "lblLightMode";
            this.lblLightMode.Size = new System.Drawing.Size(78, 17);
            this.lblLightMode.TabIndex = 1;
            this.lblLightMode.Text = "Light Mode";
            this.lblLightMode.Click += new System.EventHandler(this.lblLightMode_Click);
            // 
            // lblReset
            // 
            this.lblReset.Location = new System.Drawing.Point(581, 15);
            this.lblReset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(116, 55);
            this.lblReset.TabIndex = 6;
            this.lblReset.Text = "To reset the 2 custom launcher icons, click here!";
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            // 
            // pbCustom2
            // 
            this.pbCustom2.Image = global::Launcher.Properties.Resources.custom;
            this.pbCustom2.InitialImage = null;
            this.pbCustom2.Location = new System.Drawing.Point(440, 15);
            this.pbCustom2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCustom2.Name = "pbCustom2";
            this.pbCustom2.Size = new System.Drawing.Size(133, 123);
            this.pbCustom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCustom2.TabIndex = 5;
            this.pbCustom2.TabStop = false;
            this.pbCustom2.Click += new System.EventHandler(this.pbCustom2_Click);
            // 
            // pbCustom1
            // 
            this.pbCustom1.Image = global::Launcher.Properties.Resources.custom;
            this.pbCustom1.InitialImage = null;
            this.pbCustom1.Location = new System.Drawing.Point(299, 15);
            this.pbCustom1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCustom1.Name = "pbCustom1";
            this.pbCustom1.Size = new System.Drawing.Size(133, 123);
            this.pbCustom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCustom1.TabIndex = 4;
            this.pbCustom1.TabStop = false;
            this.pbCustom1.Click += new System.EventHandler(this.pbCustom1_Click);
            // 
            // pbDiscord
            // 
            this.pbDiscord.Image = global::Launcher.Properties.Resources.discord_logo_png_7617;
            this.pbDiscord.InitialImage = global::Launcher.Properties.Resources._1024px_Breezeicons_apps_48_steam_svg;
            this.pbDiscord.Location = new System.Drawing.Point(157, 15);
            this.pbDiscord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbDiscord.Name = "pbDiscord";
            this.pbDiscord.Size = new System.Drawing.Size(133, 123);
            this.pbDiscord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDiscord.TabIndex = 3;
            this.pbDiscord.TabStop = false;
            // 
            // pbSteam
            // 
            this.pbSteam.Image = global::Launcher.Properties.Resources._1024px_Breezeicons_apps_48_steam_svg;
            this.pbSteam.InitialImage = global::Launcher.Properties.Resources._1024px_Breezeicons_apps_48_steam_svg;
            this.pbSteam.Location = new System.Drawing.Point(16, 15);
            this.pbSteam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbSteam.Name = "pbSteam";
            this.pbSteam.Size = new System.Drawing.Size(133, 123);
            this.pbSteam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSteam.TabIndex = 2;
            this.pbSteam.TabStop = false;
            this.pbSteam.Click += new System.EventHandler(this.pbSteam_Click);
            // 
            // txtCustom1
            // 
            this.txtCustom1.Location = new System.Drawing.Point(299, 145);
            this.txtCustom1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustom1.Name = "txtCustom1";
            this.txtCustom1.Size = new System.Drawing.Size(132, 22);
            this.txtCustom1.TabIndex = 7;
            this.txtCustom1.Text = "Adress to .exe here!";
            // 
            // txtCustom2
            // 
            this.txtCustom2.Location = new System.Drawing.Point(440, 145);
            this.txtCustom2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustom2.Name = "txtCustom2";
            this.txtCustom2.Size = new System.Drawing.Size(132, 22);
            this.txtCustom2.TabIndex = 8;
            this.txtCustom2.Text = "Adress to .exe here!";
            // 
            // btnCustom1
            // 
            this.btnCustom1.Location = new System.Drawing.Point(313, 177);
            this.btnCustom1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCustom1.Name = "btnCustom1";
            this.btnCustom1.Size = new System.Drawing.Size(100, 28);
            this.btnCustom1.TabIndex = 9;
            this.btnCustom1.Text = "Add";
            this.btnCustom1.UseVisualStyleBackColor = true;
            this.btnCustom1.Click += new System.EventHandler(this.btnCustom1_Click);
            // 
            // btnCustom2
            // 
            this.btnCustom2.Location = new System.Drawing.Point(461, 177);
            this.btnCustom2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCustom2.Name = "btnCustom2";
            this.btnCustom2.Size = new System.Drawing.Size(100, 28);
            this.btnCustom2.TabIndex = 10;
            this.btnCustom2.Text = "Add";
            this.btnCustom2.UseVisualStyleBackColor = true;
            this.btnCustom2.Click += new System.EventHandler(this.btnCustom2_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(603, 324);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // sfdSavetime
            // 
            this.sfdSavetime.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(495, 324);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 358);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCustom2);
            this.Controls.Add(this.btnCustom1);
            this.Controls.Add(this.txtCustom2);
            this.Controls.Add(this.txtCustom1);
            this.Controls.Add(this.lblReset);
            this.Controls.Add(this.pbCustom2);
            this.Controls.Add(this.pbCustom1);
            this.Controls.Add(this.pbDiscord);
            this.Controls.Add(this.pbSteam);
            this.Controls.Add(this.lblLightMode);
            this.Controls.Add(this.lblDarkMode);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Launcher";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCustom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSteam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDarkMode;
        private System.Windows.Forms.Label lblLightMode;
        private System.Windows.Forms.PictureBox pbSteam;
        private System.Windows.Forms.PictureBox pbDiscord;
        private System.Windows.Forms.PictureBox pbCustom1;
        private System.Windows.Forms.PictureBox pbCustom2;
        private System.Windows.Forms.Label lblReset;
        private System.Windows.Forms.TextBox txtCustom1;
        private System.Windows.Forms.TextBox txtCustom2;
        private System.Windows.Forms.Button btnCustom1;
        private System.Windows.Forms.Button btnCustom2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.SaveFileDialog sfdSavetime;
        private System.Windows.Forms.Button btnSave;
    }
}

