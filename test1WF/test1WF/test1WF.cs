﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1WF
{

    public partial class test1WF : Form
    {
        public test1WF()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var form = new People();
            form.ShowDialog();
           
        }

        private void lblPic_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://thispersondoesnotexist.com/");
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
