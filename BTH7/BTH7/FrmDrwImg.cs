using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH7
{
    public partial class FrmDrwImg : Form
    {
        public FrmDrwImg()
        {
            InitializeComponent();
        }

        private void FrmDrwImg_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rec1 = new Rectangle(0, 0, ClientRectangle.Width / 2, ClientRectangle.Height / 2);
            Rectangle rec2 = new Rectangle(0, ClientRectangle.Height / 2, ClientRectangle.Width / 2, ClientRectangle.Height / 2);
            Rectangle rec3 = new Rectangle(ClientRectangle.Width / 2,0, ClientRectangle.Width / 2, ClientRectangle.Height / 2);
            DrwImg(rec1, e.Graphics);
            DrwTxt(rec2, e.Graphics);
            DrwPolygon(rec3, e.Graphics);
        }

        private void DrwImg(Rectangle rec , Graphics g)
        {
            Image img = Image.FromFile(Application.StartupPath + @"XucXac\back.png");
            g.DrawImage(img, rec);

            Font f = new Font("Arial", 24, FontStyle.Bold);
            SolidBrush br = new SolidBrush(Color.FromArgb(50, 255, 255, 0));
            StringFormat fm = new StringFormat();
            fm.LineAlignment = StringAlignment.Far;
            g.DrawString("Anita", f, br, rec, fm);
        }
        private void DrwTxt(Rectangle rec, Graphics g)
        {
            LinearGradientBrush br = new LinearGradientBrush(rec, Color.Black, Color.White,45);
            g.FillRectangle(br, rec);
            LinearGradientBrush lbr = new LinearGradientBrush(new Rectangle(0, 0, 40, 40),
                Color.Red,Color.Yellow,LinearGradientMode.BackwardDiagonal);
            StringFormat fm = new StringFormat();
            fm.Alignment = StringAlignment.Center;
            fm.LineAlignment = StringAlignment.Center;
            Font f = new Font("Arial", 48, FontStyle.Bold | FontStyle.Italic);
            g.DrawString("HELLO", f, lbr, rec, fm);

        }
        private void DrwPolygon(Rectangle rec, Graphics g)
        {
            Point[] arrP = { new Point(rec.Left,rec.Height/2) ,
                             new Point(rec.Left + rec.Width/2,0),
                             new Point(rec.Left + rec.Width, rec.Width/4),
                             new Point(rec.Left + rec.Width/2, rec.Width)};
            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(arrP);
            PathGradientBrush br = new PathGradientBrush(path);
            br.CenterColor = Color.White;
            Color[] arrC = { Color.Red, Color.Yellow, Color.Cyan };
            br.SurroundColors = arrC;
            g.FillPolygon(br,arrP);
        }

        private void FrmDrwImg_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
