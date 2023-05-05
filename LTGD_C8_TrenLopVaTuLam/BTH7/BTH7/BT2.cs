using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH7
{
    public partial class BT2 : Form
    {
        public BT2()
        {
            InitializeComponent();
        }
        Graphics g;//de ve
        Bitmap bmp;// duoc ve
        private void BT2_Load(object sender, EventArgs e)
        {
            t1.Text = "12000";
            t2.Text = "11000";
            t3.Text = "8500";
            t4.Text = "16800";
            t5.Text = "17500";

            bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            g = Graphics.FromImage(bmp);
        }

        private int GetMaxValue(int[] arrValue)
        {
            int max = 0;
            foreach (int value in arrValue)
            {
                if (value > max) max = value;
            }
            return max;
        }

        private void BT2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void btGen_Click(object sender, EventArgs e)
        {
            try
            {

                int monday = Convert.ToInt32(t1.Text) / 100;
                int tuesday = Convert.ToInt32(t2.Text) / 100;
                int wednesday = Convert.ToInt32(t3.Text) / 100;
                int thurday = Convert.ToInt32(t4.Text) / 100;
                int friday = Convert.ToInt32(t5.Text) / 100;
                int[] arrValue = { monday, tuesday, wednesday, thurday, friday };
                int maxValue = GetMaxValue(arrValue);
                if (maxValue * 100 > 50000)
                {
                    MessageBox.Show("Vui lòng nhập số nhỏ hơn 50.000", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    t1.Text = "";
                    t2.Text = "";
                    t3.Text = "";
                    t4.Text = "";
                    t5.Text = "";
                    t1.Focus();
                    return;
                }
                //tao chieu cao cua form dua theo chi so cao nhat
                this.Height = btGen.Bottom + maxValue + 100;
                int bottom = this.Height - 50;

                //Khoi phuc bitmap
                bmp.Dispose();
                bmp = new Bitmap(this.Width, this.Height);


                //khoi phuc graph
                g.Dispose();
                g = Graphics.FromImage(bmp);
                g.Clear(BackColor);

                g.FillRectangle(new SolidBrush(Color.Red),
                    t1.Left + 15, bottom - monday, 40, monday);
                g.FillRectangle(new SolidBrush(Color.Green),
                    t2.Left + 15, bottom - tuesday, 40, tuesday);
                g.FillRectangle(new SolidBrush(Color.Blue),
                    t3.Left + 15, bottom - wednesday, 40, wednesday);
                g.FillRectangle(new SolidBrush(Color.Cyan),
                    t4.Left + 15, bottom - thurday, 40, thurday);
                g.FillRectangle(new SolidBrush(Color.Yellow),
                    t5.Left + 15, bottom - friday, 40, friday);
                g.DrawLine(new Pen(Color.Black), t1.Left, bottom, t5.Right, bottom);
                Invalidate();

            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t1.Text = "";
                t2.Text = "";
                t3.Text = "";
                t4.Text = "";
                t5.Text = "";
                t1.Focus();
            }
        }
    }
}
