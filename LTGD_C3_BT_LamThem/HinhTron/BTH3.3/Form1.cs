using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH3._3
{
    public partial class Form1 : Form
    {
        float xT, yT, xD, yD;
        double S, d , R;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {   //Thay thế lớp Diem
            xT = Convert.ToInt32(textBox5.Text);
            yT= Convert.ToInt32(textBox6.Text);
            
            xD = Convert.ToInt32(textBox4.Text);
            yD = Convert.ToInt32(textBox7.Text);

            d = R - (Math.Sqrt((xD - xT) * (xD - xT) + (yD - yT) * (yD - yT)));
            if( d > 0)
            {
                rbNhanXet.Text = " D nằm trong đường tròn!";
            }
            else if (d < 0 )
            {
                rbNhanXet.Text = " D nằm ngoài đường tròn!";
            }    
            else
            {
                rbNhanXet.Text = " D nằm trên đường tròn!";
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            R = Convert.ToInt32(textBox1.Text);
            textBox2.Text = Convert.ToString(2*3.14 * R);
            textBox3.Text = Convert.ToString(3.14 * 3.14 * R);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
