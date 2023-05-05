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
    public partial class FrmDrwTxt : Form
    {
        public FrmDrwTxt()
        {
            InitializeComponent();
        }

        private void FrmDrwTxt_Paint(object sender, PaintEventArgs e)
        {
            Font f = new Font("Arial", 36, FontStyle.Bold);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Far; 
            e.Graphics.DrawString("Hello", f, Brushes.Green, ClientRectangle);

            TextureBrush tbr = new TextureBrush(Image.FromFile(Application.StartupPath + @"\hoa.jpg"));
            format.Alignment = StringAlignment.Near;
            format.LineAlignment = StringAlignment.Far;
            e.Graphics.DrawString("Hello", f,tbr, ClientRectangle, format);

            HatchBrush hbr = new HatchBrush(HatchStyle.DarkHorizontal, Color.Red, Color.Green);
            format.FormatFlags = StringFormatFlags.DirectionVertical;
            //format.LineAlignment = StringAlignment.Near;
            e.Graphics.DrawString("HELLO", f, hbr, ClientRectangle, format);

            LinearGradientBrush lbr = new LinearGradientBrush(new Rectangle(50, 50, 10, 10),
                Color.Blue, Color.White, 45);
            format.Alignment = StringAlignment.Far;
            format.LineAlignment = StringAlignment.Far;
            e.Graphics.DrawString("HELLO", f, lbr, ClientRectangle, format);
        }

        private void FrmDrwTxt_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
