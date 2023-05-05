using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTL_BTH5_BongNay
{
    public partial class Form1 : Form
    {
        int dx, dy, dxThanhNgang;
        bool trangThaiBanh;
        bool isGameOver;
        bool kiemTraVaCham;


        private bool isMovingRight = true; // biến lưu hướng di chuyển của PictureBox
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dx = 10;
            dy = 8;
            dxThanhNgang = 8;
            trangThaiBanh = false;
            isGameOver = false;
            kiemTraVaCham = true;

            
        }
        private void DiChuyenBanh()
        {
            if (!isGameOver)
            {
                if (pictureBox1.Left < 0 || pictureBox1.Right > ClientRectangle.Width)
                {
                    dx = -dx;
                    kiemTraVaCham = true;
                }
                if (pictureBox1.Top < 0 )
                {
                    dy = -dy;
                    kiemTraVaCham = true;
                }
             
                if(pictureBox1.Bottom > button1.Bottom)
                {
                    isGameOver = true;
                }    
                pictureBox1.Left += dx;
                pictureBox1.Top += dy; 
            }
            else
            {
                timer1.Stop();
                timer1.Enabled = false;
                MessageBox.Show("Game Over");
            }    

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            KiemTraVaCham();
            DiChuyenBanh(); 
        }
        private void DiChuyenThanhNgang(int giaTri)
        {
            if(button1.Left > 0 && button1.Right < ClientRectangle.Width)
            {
                button1.Left += giaTri;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           ResetMouseEventArgs();
        }

        private void KiemTraVaCham()
        {
            if (kiemTraVaCham)
            {
                if (button1.Bounds.IntersectsWith(pictureBox1.Bounds))
                {
                    dy = -dy;
                    kiemTraVaCham = false;
                } 
            }
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch(keyData)
            {
                case Keys.Escape:
                    if (!isGameOver)
                    {
                        trangThaiBanh = !trangThaiBanh;
                        if (trangThaiBanh)
                        {
                            timer1.Enabled = trangThaiBanh;
                            timer1.Start();
                        }
                        else
                        {
                            timer1.Stop();
                            timer1.Enabled = trangThaiBanh;
                        }
                        
                    }
                    return true; 
                case Keys.Left:
                    if (button1.Left > 0)
                    {
                        button1.Left -= dxThanhNgang;
                    }
                    return true;
                    case Keys.Right:
                    if (button1.Right < ClientRectangle.Width)
                    {
                        button1.Left += dxThanhNgang;
                    }
                    return true;
            }  
            return base.ProcessDialogKey(keyData);
        }






    }
}
