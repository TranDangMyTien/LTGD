using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace BTH7
{
    public partial class FrmDrwMouse : Form
    {
        Color color;
        int pentWidt;
        Point pOld;
        Bitmap bmp;
        public FrmDrwMouse()
        {
            InitializeComponent();
        }

        private void FrmDrwMouse_Load(object sender, EventArgs e)
        {
            color = Color.Red;
            pentWidt = 1;
            bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
             
        }

        private void FrmDrwMouse_MouseDown(object sender, MouseEventArgs e)
        {
            pOld = e.Location;

        }

        private void FrmDrwMouse_MouseMove(object sender, MouseEventArgs e)
        {
             if(e.Button == MouseButtons.Left)
            {
                Pen pen = new Pen(color, pentWidt);
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                Graphics g = Graphics.FromImage(bmp);
                g.DrawLine(pen, pOld, e.Location);
                pOld = e.Location;
                Invalidate();
            }
        }

        private void FrmDrwMouse_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.R: color = Color.Red; break;
                case Keys.G: color = Color.Green; break;
                case Keys.B: color = Color.Blue; break;
                case Keys.Up: pentWidt++; break;
                case Keys.Down: pentWidt--; break;
            }
            return true;
        }
    }
}
