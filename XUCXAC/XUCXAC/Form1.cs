using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XUCXAC
{
    public partial class Form1 : Form
    {
        string pathImg;
        Random rand = new Random();
        private int soTienConLai;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pathImg = Application.StartupPath + @"\HinhXucXac\";
            soTienConLai = Convert.ToInt32(lbResult.Text);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            label6.Text = label7.Text = label8.Text = "6"; 
        }
        private void btQuaySo_Click(object sender, EventArgs e)
        {
            int so1 = rand.Next(1, 7);
            int so2 = rand.Next(1, 7);
            int so3 = rand.Next(1, 7);
            label6.Text = so1.ToString();
            label7.Text = so2.ToString();
            label8.Text = so3.ToString();
            pic1.Image = Image.FromFile(pathImg + so1.ToString() + ".gif");
            pic2.Image = Image.FromFile(pathImg + so2.ToString() + ".gif");
            pic3.Image = Image.FromFile(pathImg + so3.ToString() + ".gif");
            int total = so1 + so2 + so3;

            int tienCuoc1 = int.Parse(comboBox1.SelectedItem.ToString());
            int tienCuoc2 = int.Parse(comboBox2.SelectedItem.ToString());
            if (tienCuoc1 + tienCuoc2 > soTienConLai)
            {
                MessageBox.Show("Tổng tiền cược không được lớn hơn tổng tiền còn lại!!", "Lưu ý");
                return;
            }
            //groupbox chẵn lẻ
            if (rdChan.Checked)
            {
                if (total % 2 == 0)
                    soTienConLai += tienCuoc1;
                else
                    soTienConLai -= tienCuoc1;
            }
            else
            {
                if (total % 2 == 0)
                    soTienConLai -= tienCuoc1;
                else
                    soTienConLai += tienCuoc1;
            }
            //groupbox tổng 3-10 && 11-18
            if (rd3.Checked)
            {
                if (total <= 10)
                    soTienConLai += tienCuoc2;
                else //total >= 11
                    soTienConLai -= tienCuoc2;

            }
            else
            {
                if (total <= 10)
                    soTienConLai -= tienCuoc2;
                else //total >= 11
                    soTienConLai += tienCuoc2;
            }
            lbResult.Text = soTienConLai.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Đóng ứng dụng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            pic1.Image = pic2.Image = pic3.Image = Image.FromFile(Application.StartupPath + @"\HinhXucXac\5.gif");
            pic1.SizeMode = pic2.SizeMode =pic3.SizeMode = PictureBoxSizeMode.Zoom;
            pic1.Visible = pic2.Visible = pic3.Visible = checkBox.Checked;
        }
       
    }
}
