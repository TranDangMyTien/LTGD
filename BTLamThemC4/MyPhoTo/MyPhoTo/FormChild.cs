using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace MyPhoTo
{

    public partial class FormChild : Form
    {
        Image img;
        public FormChild()
        {
            InitializeComponent();
        }

        private void FormChild_Load(object sender, EventArgs e)
        {
            LoadImage(Application.StartupPath + @"\meo.jpg");
        }
        private void LoadImage(String fileName)
        {
            img = Image.FromFile(fileName);
            pic.Image = img;
        }

        private void MenuLoad_Click(object sender, EventArgs e)
        {
            LoadImage(Application.StartupPath + @"\meo.jpg");
        }

        private void MenuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "PNG File (*.png)|*.png" 
                + "|JPG File (*.jpg)|*.jpg" 
                + "|GIF File (*.gif)|*.gif";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadImage(dlg.FileName);
            }
        }

        private void MenuClear_Click(object sender, EventArgs e)
        {
            pic.Image = null;
        }

        private void MenuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Image file (jpeg, gif, bmp, ...)|*.jpg;*.gif;*.bmp;*.png|"+"jpeg file(*.jpg)|*.jpg|" +"gif file(*.gif)|*.gif|" + "bitmap file(*.bmp) | *.bmp|" + "png file (*.png)|*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dlg.FileName.ToLower().EndsWith(".jpg"))
                {
                    img.Save(dlg.FileName, ImageFormat.Jpeg);
                }
                else if (dlg.FileName.ToLower().EndsWith(".bmp"))
                {
                    img.Save(dlg.FileName, ImageFormat.Bmp);
                }
                else if (dlg.FileName.ToLower().EndsWith(".png"))
                {
                    img.Save(dlg.FileName, ImageFormat.Png);
                } else if (dlg.FileName.ToLower().EndsWith(".gif"))
                {
                    img.Save(dlg.FileName, ImageFormat.Gif);
                }
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
