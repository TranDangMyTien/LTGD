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
    
        public Form1()
        {
            InitializeComponent();
        }

        //Tạo sự kiện nhấn cho các số 
        private void bt0_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            lbTinh.Text += bt.Text;
        }

        //Tạo sự kiện nhấn cho các operation (dấu) 
        //Tạo sự kiện nhấn để hiển thị số hoặc dấu lên lable cho người dùng thấy 
        private void Operation_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            lbTinh.Text += bt.Text;
        }

        //Xóa 1 
        private void btR_Click(object sender, EventArgs e)
        {
            if (lbTinh.Text == "") return; //Khi lable rỗng thì không có gì để xóa nữa nên retrun 
            //Trường hợp của else 
            lbTinh.Text = lbTinh.Text.Substring(0, lbTinh.Text.Length - 1); //Cắt chuỗi từ vị trí 0 đến độ dài trừ đi 1 đơn vị 

        }
        //Xóa hết 
        private void btDel_Click(object sender, EventArgs e)
        {
            if (lbTinh.Text == "") return; //Khi lable rỗng thì không có gì để xóa nữa nên retrun 
            //Trường hợp else 
            lbTinh.Text = ""; //Gán chuỗi bằng rỗng 
        }

        private void btBang_Click(object sender, EventArgs e)
        {
            try
            {
                int pos = 0;
                char dau = '+';
                try
                {
                    if (lbTinh.Text.Contains("+")) //Contains: Có chứa kí tự '+'
                        pos = lbTinh.Text.IndexOf('+'); //Indexof : trả về chỉ số vị trí xuất hiện lần đầu tiên một ký tự chỉ định hoặc một chuỗi con chỉ định trong chuỗi
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
                    int a = int.Parse(lbTinh.Text.Substring(0, pos)); //Parse: ép kiểu về số nguyên 
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
