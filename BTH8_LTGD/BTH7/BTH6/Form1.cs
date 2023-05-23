using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace BTH6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitTree();
        }

        private void InitTree()
        {
            string[] drive = Directory.GetLogicalDrives();
            TreeNode node = null;
            foreach (string drv in drive)
            {
                node = new TreeNode(drv);
                Tv1.Nodes.Add(node);
                node.Nodes.Add("Temp");
            }
        }

        private void Tv1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.Nodes.Clear();
            node.ImageIndex = 0;
            try
            {
                foreach (string dir in Directory.GetDirectories(node.FullPath))
                {
                    TreeNode n = node.Nodes.Add(Path.GetFileName(dir));
                    n.Nodes.Add("Temp");
                }
            }
            catch { }
        }

        private void Tv1_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 1;
        }

        private void Tv1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                pic1.Image = null;

                string[] arrFile = Directory.GetFiles(e.Node.FullPath);
                layOut1.Controls.Clear();
                foreach(string file in arrFile)
                {
                    if(file.ToLower().EndsWith(".png") ||
                       file.ToLower().EndsWith(".gif") ||
                       file.ToLower().EndsWith(".jpg") ||
                       file.ToLower().EndsWith(".bmp") ||
                       file.ToLower().EndsWith(".jpeg"))
                    {
                        PictureBox pic = new PictureBox();

                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Image = Image.FromFile(file);
                        pic.Height = layOut1.Height - 10;
                        pic.Width = pic.Height * 5 / 4;
                        pic.Cursor = Cursors.Hand;
                        layOut1.Controls.Add(pic);

                        pic.Click += new EventHandler(pictureBox_Click);
                    }
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Error!");
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic1.Image = pic.Image;
        }
    }
}
