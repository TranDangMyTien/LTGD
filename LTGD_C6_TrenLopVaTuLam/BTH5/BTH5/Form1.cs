using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string txt = "  khoa Công nghệ thông tin, trường đại học mở TP HCM";
        
        private void btThaythe_Click(object sender, EventArgs e)
        {
            txtS1.Text = txtS1.Text.Replace(txtS2.Text, txtS3.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbName.Text = "     Chương Trình Minh Họa Xử Lý Chuỗi       ";
            txtS1.Text = txt;
        }

        private void btChen_Click(object sender, EventArgs e)
        {
            try
            {
                int pos = int.Parse(tbVitriChen.Text);
                if (pos < 0 || pos > txtS1.Text.Length) return;
                txtS1.Text = txtS1.Text.Insert(pos, txtS2.Text);
            }catch(FormatException)
            {
                MessageBox.Show("Bạn phải nhập dữ liệu vào");
                
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int pos = txtS1.Text.IndexOf(txtS2.Text);
            while(pos >= 0)
            {
                txtS1.Text = txtS1.Text.Remove(pos, txtS2.Text.Length);
                pos = txtS1.Text.IndexOf(txtS2.Text);
            }
        }

        private void btLay_Click(object sender, EventArgs e)
        {
            try
            {
                int pos = int.Parse(tbVitriLay.Text);
                int num = int.Parse(tbKituLay.Text);
                txtS2.Text = txtS1.Text.Substring(pos, num);
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn phải nhập dữ liệu vào");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbName.Text = lbName.Text.Substring(lbName.Text.Length - 1) +
            lbName.Text.Substring(0, lbName.Text.Length - 1);
        }

        private void btKhoiphuc_Click(object sender, EventArgs e)
        {
            txtS1.Text = txt;
        }

        private void btChuanhoa_Click(object sender, EventArgs e)
        {
            char[] token = { ' ', '\t' };
            string[] arr = txtS1.Text.Split(token, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < arr.Length; i++)
                arr[i] = arr[i].Substring(0, 1).ToUpper() + arr[i].Substring(1).ToLower();

            txtS1.Text = String.Join(" ", arr);
        }

        private void btDaotu_Click(object sender, EventArgs e)
        {
            char[] token = { ' ', '\t' };
            string[] arr = txtS1.Text.Split(token, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(arr);
            txtS1.Text = String.Join(" ", arr);
        }
    }
}
