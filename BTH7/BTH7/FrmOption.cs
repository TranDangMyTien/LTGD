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
    public partial class FrmOption : Form
    {
        public FrmOption()
        {
            InitializeComponent();
        }
        public static int i;

        private void btOk_Click(object sender, EventArgs e)
        {
            if (btRect.Checked)
                i = 1;
            else if (btEllipse.Checked)
                i = 2;
            else if (btTrian.Checked)
                i = 3;
            this.Close();
        }
        public static Color cl;
        private void btColor_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            cl = new Color();
            if (cld.ShowDialog() == DialogResult.OK)
            {
                cl = cld.Color;
                btColor.BackColor = cld.Color;
                
            }

        }
    }
}
