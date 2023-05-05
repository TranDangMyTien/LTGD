using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            lbTinh.Text += bt.Text;
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            lbTinh.Text += bt.Text;
        }

        private void btR_Click(object sender, EventArgs e)
        {
            if (lbTinh.Text == "") return;
            lbTinh.Text = lbTinh.Text.Substring(0, lbTinh.Text.Length - 1);

        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (lbTinh.Text == "") return;
            lbTinh.Text = "";
        }

        private void btBang_Click(object sender, EventArgs e)
        {
            try
            {
                int pos = 0;
                char dau = '+';
                try
                {
                    if (lbTinh.Text.Contains("+"))
                        pos = lbTinh.Text.IndexOf('+');
                    else if (lbTinh.Text.Contains("-"))
                    {
                        pos = lbTinh.Text.IndexOf('-');
                        dau = '-';
                    }
                    else if (lbTinh.Text.Contains("x"))
                    {
                        pos = lbTinh.Text.IndexOf('x');
                        dau = 'x';
                    }
                    else
                    {
                        pos = lbTinh.Text.IndexOf('/');
                        dau = '/';
                    }
                    int a = int.Parse(lbTinh.Text.Substring(0, pos));
                    int b = int.Parse(lbTinh.Text.Substring(pos + 1));
                    switch(dau)
                    {
                        case '+': lbTinh.Text += " = " + (a + b).ToString(); break;
                        case '-': lbTinh.Text += " = " + (a - b).ToString(); break;
                        case 'x': lbTinh.Text += " = " + (a * b).ToString(); break;
                        case '/': lbTinh.Text += " = " + (a / b).ToString(); break;
                        default: break;
                    }    
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Vượt quá dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lbTinh.Text = "";
                }
                catch (DivideByZeroException)
                {

                    MessageBox.Show("Lỗi chia cho 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lbTinh.Text = "";
                }
            }
            catch (Exception) { }
            
        }
       
    }
}
