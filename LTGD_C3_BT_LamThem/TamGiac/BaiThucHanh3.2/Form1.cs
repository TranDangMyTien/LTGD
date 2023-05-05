using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh3._2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt16(txtSo1.Text);
                int b = Convert.ToInt16(txtSo2.Text);
                int c = Convert.ToInt16(txtSo3.Text);

                TamGiac t = new TamGiac(a, b, c);
                if (TamGiac.checkTamGiac(t))
                {
                    rtbNhanXet.Text = "Điều kiện đúng! Tam giác thường.";
                    if (TamGiac.checkTamGiacDeu(t))
                    {
                        rtbNhanXet.Text = "Tam giác đều ";
                    }
                    else if (TamGiac.checkTamGiacCan(t))
                    {
                        rtbNhanXet.Text = "Tam giác cân";
                    }
                    txtChuVi.Text = Convert.ToString(TamGiac.ChuVi(t));
                    txtDienTich.Text = Convert.ToString(String.Format("{0: 0.00}", TamGiac.DienTich(t)));

                }
                else
                {
                    rtbNhanXet.Text = "Không xác định !";
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn phải nhập 3 cạnh của tam giác !");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
