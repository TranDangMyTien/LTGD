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
    public partial class BT1 : Form
    {
        private List<Rectangle> rectangles;
        private List<Rectangle> ellipse;
        private List<Point[]> triangle;
        private Point startPoint;
        private Point endPoint;
        private bool drawing;
        public BT1()
        {
            InitializeComponent();
            rectangles = new List<Rectangle>();
            ellipse = new List<Rectangle>();
            triangle = new List<Point[]>();
            startPoint = Point.Empty;
            endPoint = Point.Empty;
            drawing = false;
        }
        

        private void BT1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (FrmOption.i == 1)
                RectUp();
            else if (FrmOption.i == 2)
                EllipseUp();
            else if (FrmOption.i == 3)
                TriangleUp(e);
        }
        private void RectUp()
        {
            // Khi chuột được thả, dừng vẽ hình và lưu hình chữ nhật vào danh sách
            drawing = false;
            Rectangle rect = new Rectangle(
                Math.Min(startPoint.X, endPoint.X),
                Math.Min(startPoint.Y, endPoint.Y),
                Math.Abs(startPoint.X - endPoint.X),
                Math.Abs(startPoint.Y - endPoint.Y));
            rectangles.Add(rect);
        }

        private void EllipseUp()
        {
            // Khi chuột được thả, dừng vẽ hình và lưu hình ellipse vào danh sách
            drawing = false;
            Rectangle rect = new Rectangle(
                Math.Min(startPoint.X, endPoint.X),
                Math.Min(startPoint.Y, endPoint.Y),
                Math.Abs(startPoint.X - endPoint.X),
                Math.Abs(startPoint.Y - endPoint.Y));
            ellipse.Add(rect);
        }

        private void TriangleUp(MouseEventArgs e)
        {
            drawing = false;
            endPoint = e.Location;
            Point[] points = { startPoint, new Point(endPoint.X, startPoint.Y), endPoint };
            triangle.Add(points);
            panel1.Invalidate();
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            // Nếu đang vẽ hình, lưu tọa độ điểm kết thúc và vẽ hình lên màn hình
            if (drawing)
            {
                endPoint = e.Location;
                panel1.Invalidate();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            // Khi chuột được nhấn, lưu tọa độ điểm bắt đầu
            startPoint = e.Location;
            drawing = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
                Rectangle(e);         
                Ellipse(e);      
                Triangle(e);
         
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rectangles.Clear();
            ellipse.Clear();
            triangle.Clear();
            panel1.Invalidate();
            
        }

        private void optionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmOption f = new FrmOption();
            f.ShowDialog();
           
        }

        private void BT1_Load(object sender, EventArgs e)
        {
            FrmOption.cl = Color.Red;
            FrmOption.i = 1;
        }

        private void Rectangle(PaintEventArgs e)
        {
            // Vẽ tất cả các hình chữ nhật đã lưu trữ
            foreach (Rectangle rect in rectangles)
            {
                SolidBrush brush = new SolidBrush(FrmOption.cl);
                e.Graphics.FillRectangle(brush, rect);
            }

            // Nếu đang vẽ hình mới, vẽ hình đó lên màn hình
            if (drawing)
            {
                Rectangle rect = new Rectangle(
                    Math.Min(startPoint.X, endPoint.X),
                    Math.Min(startPoint.Y, endPoint.Y),
                    Math.Abs(startPoint.X - endPoint.X),
                    Math.Abs(startPoint.Y - endPoint.Y));
                SolidBrush brush = new SolidBrush(FrmOption.cl);
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        private void Ellipse(PaintEventArgs e)
        {
            // Vẽ tất cả các hình ellipse đã lưu trữ
            foreach (Rectangle rect in ellipse)
            {
                SolidBrush brush = new SolidBrush(FrmOption.cl);
                e.Graphics.FillEllipse(brush, rect);
            }

            // Nếu đang vẽ hình mới, vẽ hình đó lên màn hình
            if (drawing)
            {
                Rectangle rect = new Rectangle(
                    Math.Min(startPoint.X, endPoint.X),
                    Math.Min(startPoint.Y, endPoint.Y),
                    Math.Abs(startPoint.X - endPoint.X),
                    Math.Abs(startPoint.Y - endPoint.Y));
                SolidBrush brush = new SolidBrush(FrmOption.cl);
                e.Graphics.FillEllipse(brush, rect);
            }
        }

        private void Triangle(PaintEventArgs e)
        {
            // Vẽ các hình tam giác
            foreach (Point[] points in triangle)
            {
                Brush brush = new SolidBrush(FrmOption.cl);
                e.Graphics.FillPolygon(brush, points);
            }

            // Vẽ tam giác đang được vẽ
            if (drawing)
            {
                Point[] points = { startPoint, new Point(endPoint.X, startPoint.Y), endPoint };
                Brush brush = new SolidBrush(FrmOption.cl);
                e.Graphics.FillPolygon(brush, points);
            }

        }
    }
}
