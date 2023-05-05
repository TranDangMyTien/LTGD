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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void bntTinh_Click(object sender, EventArgs e)
        {
            try
            {
                int a = checked(int.Parse(txtSo1.Text));
                int b = checked(int.Parse(txtSo2.Text));
                if (rdCong.Checked) //Kiểm tra rd nào được chọn 
                    lbKQ.Text = string.Format("{0}", checked(a + b)); //Kiểm tra tràn số 
                else if (rdTru.Checked)
                    lbKQ.Text = string.Format("{0}", a - b);
                else if (rdNhan.Checked)
                    lbKQ.Text = string.Format("{0}", checked(a * b)); //Kiểm tra tràn số 
                else 
                {
                    if (b == 0) //Lỗi mặc đặc định DivideByZeroException thì nó xuất câu tiếng anh => Xuất tiếng việt thì tự ném lỗi 
                        throw new DivideByZeroException("Số chia phải khác 0");
                    if (rdChia.Checked)
                        lbKQ.Text = String.Format("{0:0.00}", (double) a / b); 
                    else
                        lbKQ.Text = String.Format("{0}", a / b);
                }
            }
            catch (FormatException)
            {
                lbKQ.Text = "Bạn phải nhập hai số";
            }
            catch (OverflowException)
            {
                lbKQ.Text = "Số quá lớn";
            }
            catch (DivideByZeroException ex)
            {
                lbKQ.Text = ex.Message;
            }
        }

        private void rdCong_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
