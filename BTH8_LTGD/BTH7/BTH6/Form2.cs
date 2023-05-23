using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbAge.Text == "" || tbAddress.Text == "")
                MessageBox.Show("Bạn phải nhập đủ dữ liệu");
            else
            {
                ListViewItem f = new ListViewItem(tbName.Text);
                f.SubItems.Add(tbAge.Text);
                f.SubItems.Add(tbAddress.Text);
                list1.Items.Add(f);
                tbName.Text = tbAge.Text = tbAddress.Text = "";

            }
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Empl File|*.empl";
            f.Title = "Open file";
            f.ShowDialog();

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Empl File|*.empl";
            saveFileDialog1.Title = "Save an Empl File";
            saveFileDialog1.InitialDirectory = @"D:\";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbName.Text = saveFileDialog1.FileName;
                
            }
        }
    }
}
