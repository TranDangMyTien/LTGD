using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuyenMaASCII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAsKi_Click(object sender, EventArgs e)
        {
            try
            {
                byte a = Convert.ToByte(txtSo1.Text);
                int tmp = Convert.ToInt32(txtSo1.Text);
                if (tmp < 31 && tmp > 127)
                    lbKq1.Text = "Error";
                else
                {
                    char x = Convert.ToChar(a);
                    lbKq1.Text = Convert.ToString(x);
                }
            }
            catch(FormatException)
            {
                lbKq1.Text = "Error";
            }
        }

        private void btKiAs_Click(object sender, EventArgs e)
        {
            try
            {
                char x = Convert.ToChar(txtSo2.Text);
                byte a = Convert.ToByte(x);
                lbKq2.Text = Convert.ToString(a);
            }
            catch(FormatException)
            {
                lbKq2.Text = "Error";
            }
        }
    }
}
