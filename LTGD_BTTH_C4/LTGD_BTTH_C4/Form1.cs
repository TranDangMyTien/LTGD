using System.Security.Cryptography.Xml;

namespace LTGD_BTTH_C4
{
    public partial class Form1 : Form
    {
        int dx = 1, dy = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picBall.Left < 0 || picBall.Right > ClientRectangle.Width)
                dx = -dx;
            if (picBall.Top < 0 || picBall.Bottom > ClientRectangle.Height)
                dy = -dy;
            picBall.Left += dx;
            picBall.Top += dy;
        }
    }
}