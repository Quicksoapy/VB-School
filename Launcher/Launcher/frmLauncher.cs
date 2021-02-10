using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void lblDarkMode_Click(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#060425");
            this.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }

        private void lblLightMode_Click(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#bab6f7");
            this.ForeColor = ColorTranslator.FromHtml("#000000");

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#bab6f7");
            pbCustom1.Image = Launcher.Properties.Resources.custom;
            pbCustom1.Tag = "Default1";
            pbCustom2.Image = Launcher.Properties.Resources.custom;
            pbCustom2.Tag = "Default2";
        }

        private void pbSteam_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Program Files (x86)/Steam/steam.exe");
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            pbCustom1.Image = Launcher.Properties.Resources.custom;
            pbCustom1.Tag = "Default1";
            pbCustom2.Image = Launcher.Properties.Resources.custom;
            pbCustom2.Tag = "Default2";
        }

        private void pbCustom1_Click(object sender, EventArgs e)
        {
            if (pbCustom1.Tag == "Default1")
            {
                var cumlist = cumfunny();
                MessageBox.Show(cumlist[0], cumlist[1]);
            } 
            else
            {

                string firstcustom = txtCustom1.Text;
                System.Diagnostics.Process.Start(firstcustom);
            }
        }

        private void pbCustom2_Click(object sender, EventArgs e)
        {
            if (pbCustom2.Tag == "Default2")
            {
                var cumlist = cumfunny();
                MessageBox.Show(cumlist[0], cumlist[1]);
            }
            else
            {
                string Customlink2 = txtCustom2.Text;
                System.Diagnostics.Process.Start(Customlink2);
            }
        }

        private void btnCustom1_Click(object sender, EventArgs e)
        {
            
            pbCustom1.Tag = "NotDefault1";
            string firstcustom = txtCustom1.Text;
            pbCustom1.Image = Icon.ExtractAssociatedIcon(firstcustom).ToBitmap();
        }

        private void btnCustom2_Click(object sender, EventArgs e)
        {
            pbCustom2.Tag = "NotDefault2";
            string firstcustom2 = txtCustom2.Text;
            pbCustom2.Image = Icon.ExtractAssociatedIcon(firstcustom2).ToBitmap();
        }

        private List<string> cumfunny()
        {
            var cumlist = new List<string>();
            string message = "cum is funny haha";
            string title = "peepeepoopoo";
            cumlist.Add(message);
            cumlist.Add(title);
            return cumlist;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}

