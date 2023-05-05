using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGiai_Click(object sender, EventArgs e)
        {
            double a, b, c, delta, x1, x2;
            string kq = "";
            a = Convert.ToDouble(txta.Text);
            b = Convert.ToDouble(txtb.Text);
            c = Convert.ToDouble(txtc.Text);
            if(a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        kq = "Phương trình có vô số nghiệm";
                    else
                        kq = "Phương trình vô nghiệm";
                }
                else
                    kq = String.Format("Phương trình có nghiệm là : {0:0.00} ", ((-c)/b));
            }   
            else
            {
                delta = b * b - 4 * a * c;
                if (delta < 0)
                    kq = "Phương trình vô  nghiệm";
                else if (delta == 0)
                    kq = string.Format("Phương trình có nghiệm kép là : {0:0.00}", ((-b) / 2 * a));
                else // delta > 0 
                {
                    x1 = ((-b + Math.Sqrt(delta)) / 2 * a);
                    x2 = ((-b - Math.Sqrt(delta)) / 2 * a);
                    kq = string.Format("Phương trình có 2 nghiệm x1 = {0:0.00}, x2 = {1: 0.00}", x1, x2);
                }   
            }

            txtKq.Text = kq;
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
