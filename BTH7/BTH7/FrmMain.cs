﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH7
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btDrwTxt_Click(object sender, EventArgs e)
        {
            FrmDrwTxt f = new BTH7.FrmDrwTxt();
            f.MdiParent = this;
            f.Show();
        }

        private void btDrwImg_Click(object sender, EventArgs e)
        {
            FrmDrwImg f = new BTH7.FrmDrwImg();
            f.MdiParent = this;
            f.Show();
            
        }

        private void btDrwByMouse_Click(object sender, EventArgs e)
        {
            FrmDrwMouse f = new BTH7.FrmDrwMouse();
            f.MdiParent = this;
            f.Show();
        }
    }
}
