using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsBanDau
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bntCong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b  = int.Parse(txtSo2.Text);
            int kq = a + b;
            lbKQ.Text = kq.ToString();
        }

        private void bntTru_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            int kq = a - b;
            lbKQ.Text = kq.ToString();
        }

        private void bntDong_Click(object sender, EventArgs e)
        {
            DialogResult rel = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi form?", "Thông báo", MessageBoxButtons.OKCancel);
            if (rel == DialogResult.OK)
                this.Close();
        }

        private void bntChia_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            if (b != 0) //Nếu số bị chia khác 0 mới thực hiện phép tính 
                lbKQ.Text = String.Format("{0:0.00}", (double)a / b);
            else
                lbKQ.Text = "Số bị chia phải khác 0";
        }

        private void bntNhan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            int kq = a * b;
            lbKQ.Text = kq.ToString();
        }

        private void txtSo1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
