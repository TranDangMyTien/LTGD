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
    public partial class Form5 : Form
    {
        Random r = new Random();
        string[] toantu = { "+", "-", "X", "/" };
        int index = 0;
        public Form5()
        {
            InitializeComponent();
        }

       

        private void bntTiepTuc_Click(object sender, EventArgs e)
        {
            int so1, so2;
            do
            {
                so1 = r.Next(10);
                so2 = r.Next(10);
                index = r.Next(4);
            } while (index == 3 && so2 == 0);
            lbSo1.Text = so1.ToString();
            lbSo2.Text = so2.ToString();
            lbToanTu.Text = toantu[index];
            lbKQ.Text = " ";
            txtToan.Text = " ";
        }

        //Tạo sự kiện nhấn cho các số 0-9 và dấu - 
        private void bnt8_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtToan.Text += bt.Text;

        }

        private void bntXem_Click(object sender, EventArgs e)
        {
            int kq = 0;
            switch (index)
            {
                case 0: 
                    kq = int.Parse(lbSo1.Text) + int.Parse(lbSo2.Text);
                    break;
                case 1:
                    kq = int.Parse(lbSo1.Text) - int.Parse(lbSo2.Text);
                    break;
                case 2:
                    kq = int.Parse(lbSo1.Text) * int.Parse(lbSo2.Text);
                    break;
                case 3:
                    kq = int.Parse(lbSo1.Text) / int.Parse(lbSo2.Text);
                    break;

            }
            try
            {
                int user = int.Parse(txtToan.Text);
                if (user == kq)
                    lbKQ.Text = "Chúc mừng bạn! Chính xác";
                else
                    lbKQ.Text = "Tiếc quá! Kết quả đúng là " + kq.ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn phải nhập kết quả dự đoán là số!", "Thông báo");
            }    
            

        }

        //private void bntTru_Click(object sender, EventArgs e)
        //{
        //    if (txtToan.Text != " ") return;
        //    txtToan.Text = "-";
        //}

        private void bntTroVe_Click(object sender, EventArgs e)
        {
            if (txtToan.Text == " ") return;
            txtToan.Text = txtToan.Text.Substring(0, txtToan.TextLength - 1);
        }

        
        private void bntTru_Click_1(object sender, EventArgs e)
        {
              if (txtToan.Text != " ") return;
              txtToan.Text = "-";
        }
    }
}
