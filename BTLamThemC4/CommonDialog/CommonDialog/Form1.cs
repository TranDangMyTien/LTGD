using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Threading;


namespace CommonDialog
{
    public partial class Form1 : Form
    {
        //Khi khai báo biến kiểu bool mà không gán giá trị cho nó, mặc định nó sẽ nhận giá trị false.
        private bool aOpen; 
        private bool aClose;
        public Form1()
        {
            this.Opacity = 0; //Khi form mở thì nó ở trạng thái mờ (độ rox bằng 0)
            InitializeComponent();
        }
        //Thêm 1 tập tin 
        private void btnMTT_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            //Đặt tên tiêu đề cho dlg
            //dgl.Title = "Hộp thoại mở file"!
            //Lọc file chỉ định 
            //dgl.Filter = "File ảnh|*.jpg;*.jpeg;*.png;*.gif;*.tif|ALL File|*.*";
            dlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK) //Kiểm tra người dùng đã chọn 
            {   //Lấy tên thì là SaveFileName 
                listKetQua.Items.Add(dlg.FileName); //Add đường dẫn 
                //Lấy ảnh 
                //pictureBox1.Image = Image.FromFile(f.FileName);
            }
            
        }
        //MỞ RỘNG LƯU FILE (SAVEFILEDIALOG) (RichtextBox : Cái cho người dùng nhập nhiều, chèn ảnh...)
        //SaveFileDialog f = new SaveFileDialog();
        ////Đặt tên tiêu đề 
        //f.Title = "Hộp thoại lưu file"!
        ////Định dạng nơi muốn lưu 
        //f.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        //if (f.ShowDialog() == DialogResult.OK)
        //{
        //    File.WriteAllText(f.FileName, txtTuThem.Text(cái người dùng muốn lưu));
        //}
        //else
        //{
        //    MessageBox.Show("Bạn chưa lưu nội dung");
        //}




        //Thêm nhiều tập tin 
        private void btnNTT_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dlg.Multiselect = true; //Câu lệnh cho phép thêm nhiều 
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in dlg.FileNames) //Kiểm tra người dùng đã chọn
                {
                    listKetQua.Items.Add(file); //Add từng đường dẫn vào 
                }
            }
        }

        private void btnThuMuc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.ShowDialog();
            listKetQua.Items.Add(f.SelectedPath); //Add đường dẫn 
        }

        private void btnNen_Click(object sender, EventArgs e)
        {
            ColorDialog f = new ColorDialog();
            f.ShowDialog();
            listKetQua.BackColor = f.Color; //Đổi màu nền listBox
        }

        private void btnChu_Click(object sender, EventArgs e)
        {
            ColorDialog f = new ColorDialog();
            f.AllowFullOpen = true; //Có allow thì câu lệnh ở dưới mới thực hiện được 
            f.FullOpen = true; //Mở to cái bảng ra 
            f.ShowDialog();
            listKetQua.ForeColor = f.Color; //Đổi màu chữ listBox 
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();
            f.ShowDialog();
            listKetQua.Font = f.Font;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listKetQua.Items.Clear(); //Xóa bên listBox 
            listKetQua.BackColor = Color.Bisque; //Trả về màu nền cũ của listBoxt 
            listKetQua.ForeColor = Color.Black; //Trả về màu chữ đen 
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (!aClose)
            {
                timerOut.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Enabled là một giá trị cho biết dạng thức điều kiện là bật hay tắt.
            //True sẽ bật dạng thức điều kiện. False sẽ tắt dạng thức điều kiện. Mặc định là True.
            timerLoad.Enabled = true;
            aClose = false;
        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            if (!aOpen) //Kết quả là false
            {
                this.Opacity += 0.05;
                if (this.Opacity >= 1)
                {
                    aOpen = true;
                }
            }
        }

        private void timerOut_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.05;
            if (this.Opacity <= 0)
            {
                Application.Exit();
                aClose = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) //Sự kiện khi người dùng nhấn vào X của form 
        {
            if (!aClose) //Kết quả là false
            {
                e.Cancel = true;
                timerOut.Enabled = true;
            }
        }
    }
}
