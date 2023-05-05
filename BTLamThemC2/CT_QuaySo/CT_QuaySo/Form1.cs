using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CT_QuaySo
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int Diem = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            int so1 = rand.Next(1, 7);
            int so2 = rand.Next(1, 7);
            int so3 = rand.Next(1, 7);
            lbSo1.Text = so1.ToString();
            lbSo2.Text = so2.ToString();
            lbSo3.Text = so3.ToString();
            if (so1 == so2 && so1 == so3)
            {
                Diem += 100;
            }
            else
                Diem -= 10;
            lbDiem.Text = Diem.ToString();

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
