﻿namespace Launcher
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
            ((System.ComponentModel.ISupportInitialize)(this.pbCustom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSteam)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDarkMode
            // 
            this.lblDarkMode.AutoSize = true;
            this.lblDarkMode.Location = new System.Drawing.Point(12, 203);
            this.lblDarkMode.Name = "lblDarkMode";
            this.lblDarkMode.Size = new System.Drawing.Size(60, 13);
            this.lblDarkMode.TabIndex = 0;
            this.lblDarkMode.Text = "Dark Mode";
            this.lblDarkMode.Click += new System.EventHandler(this.lblDarkMode_Click);
            // 
            // lblLightMode
            // 
            this.lblLightMode.AutoSize = true;
            this.lblLightMode.Location = new System.Drawing.Point(12, 190);
            this.lblLightMode.Name = "lblLightMode";
            this.lblLightMode.Size = new System.Drawing.Size(60, 13);
            this.lblLightMode.TabIndex = 1;
            this.lblLightMode.Text = "Light Mode";
            this.lblLightMode.Click += new System.EventHandler(this.lblLightMode_Click);
            // 
            // lblReset
            // 
            this.lblReset.Location = new System.Drawing.Point(343, 171);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(87, 45);
            this.lblReset.TabIndex = 6;
            this.lblReset.Text = "To reset the 2 custom launcher icons, click here!";
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            // 
            // pbCustom2
            // 
            this.pbCustom2.Image = global::Launcher.Properties.Resources.custom;
            this.pbCustom2.InitialImage = null;
            this.pbCustom2.Location = new System.Drawing.Point(330, 12);
            this.pbCustom2.Name = "pbCustom2";
            this.pbCustom2.Size = new System.Drawing.Size(100, 100);
            this.pbCustom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCustom2.TabIndex = 5;
            this.pbCustom2.TabStop = false;
            this.pbCustom2.Click += new System.EventHandler(this.pbCustom2_Click);
            // 
            // pbCustom1
            // 
            this.pbCustom1.Image = global::Launcher.Properties.Resources.custom;
            this.pbCustom1.InitialImage = null;
            this.pbCustom1.Location = new System.Drawing.Point(224, 12);
            this.pbCustom1.Name = "pbCustom1";
            this.pbCustom1.Size = new System.Drawing.Size(100, 100);
            this.pbCustom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCustom1.TabIndex = 4;
            this.pbCustom1.TabStop = false;
            this.pbCustom1.Click += new System.EventHandler(this.pbCustom1_Click);
            // 
            // pbDiscord
            // 
            this.pbDiscord.Image = global::Launcher.Properties.Resources.discord_logo_png_7617;
            this.pbDiscord.InitialImage = global::Launcher.Properties.Resources._1024px_Breezeicons_apps_48_steam_svg;
            this.pbDiscord.Location = new System.Drawing.Point(118, 12);
            this.pbDiscord.Name = "pbDiscord";
            this.pbDiscord.Size = new System.Drawing.Size(100, 100);
            this.pbDiscord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDiscord.TabIndex = 3;
            this.pbDiscord.TabStop = false;
            // 
            // pbSteam
            // 
            this.pbSteam.Image = global::Launcher.Properties.Resources._1024px_Breezeicons_apps_48_steam_svg;
            this.pbSteam.InitialImage = global::Launcher.Properties.Resources._1024px_Breezeicons_apps_48_steam_svg;
            this.pbSteam.Location = new System.Drawing.Point(12, 12);
            this.pbSteam.Name = "pbSteam";
            this.pbSteam.Size = new System.Drawing.Size(100, 100);
            this.pbSteam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSteam.TabIndex = 2;
            this.pbSteam.TabStop = false;
            this.pbSteam.Click += new System.EventHandler(this.pbSteam_Click);
            // 
            // txtCustom1
            // 
            this.txtCustom1.Location = new System.Drawing.Point(224, 118);
            this.txtCustom1.Name = "txtCustom1";
            this.txtCustom1.Size = new System.Drawing.Size(100, 20);
            this.txtCustom1.TabIndex = 7;
            // 
            // txtCustom2
            // 
            this.txtCustom2.Location = new System.Drawing.Point(330, 118);
            this.txtCustom2.Name = "txtCustom2";
            this.txtCustom2.Size = new System.Drawing.Size(100, 20);
            this.txtCustom2.TabIndex = 8;
            // 
            // btnCustom1
            // 
            this.btnCustom1.Location = new System.Drawing.Point(235, 144);
            this.btnCustom1.Name = "btnCustom1";
            this.btnCustom1.Size = new System.Drawing.Size(75, 23);
            this.btnCustom1.TabIndex = 9;
            this.btnCustom1.Text = "Confirm";
            this.btnCustom1.UseVisualStyleBackColor = true;
            this.btnCustom1.Click += new System.EventHandler(this.btnCustom1_Click);
            // 
            // btnCustom2
            // 
            this.btnCustom2.Location = new System.Drawing.Point(346, 144);
            this.btnCustom2.Name = "btnCustom2";
            this.btnCustom2.Size = new System.Drawing.Size(75, 23);
            this.btnCustom2.TabIndex = 10;
            this.btnCustom2.Text = "Confirm";
            this.btnCustom2.UseVisualStyleBackColor = true;
            this.btnCustom2.Click += new System.EventHandler(this.btnCustom2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 225);
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
    }
}
