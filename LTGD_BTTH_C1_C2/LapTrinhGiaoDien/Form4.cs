using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTrinhGiaoDien
{
    public partial class Form4 : Form
    {
        Random r = new Random();
        int mark = 0; 
        public Form4()
        {
            InitializeComponent();
        }

        private void rd3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntQuaySo_Click(object sender, EventArgs e)
        {
            int so1, so2, so3;
            so1 = r.Next(1, 7);
            so2 = r.Next(1, 7);
            so3 = r.Next(1, 7);
            lb1.Text = so1.ToString();
            lb2.Text = so2.ToString();
            lb3.Text = so3.ToString();

            if (rd3.Checked)
                if (so1 + so2 + so3 <= 10)
                    mark += 10;
                else
                    mark -= 10; 
            else
                if (so1 + so2 + so3 > 10)
                    mark += 10;
                else
                    mark -= 10;

            lbDiem.Text = mark.ToString();
        }

        private void lb3_Click(object sender, EventArgs e)
        {

        }
    }
}
