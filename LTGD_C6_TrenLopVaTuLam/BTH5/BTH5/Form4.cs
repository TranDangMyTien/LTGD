using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH5
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (tbTen.Text == "" || tbMaso.Text == "")
                MessageBox.Show("Bạn phải nhập dữ liệu");
            else
            {
                ListViewItem f = new ListViewItem(tbTen.Text);
                f.SubItems.Add(tbMaso.Text);
                lsSv.Items.Add(f);
                tbTen.Text = "";
                tbMaso.Text = "";
                tbTen.Focus();
            }
        }

        private void btTimName_Click(object sender, EventArgs e)
        {
            if (tbSearchName.Text == "")
                MessageBox.Show("Bạn phải nhập dữ liệu tìm kiếm");
            else
            {
           
                for (int i = 0; i < lsSv.Items.Count; i++)
                {
                    if (lsSv.Items[i].SubItems[0].Text == tbSearchName.Text)
                        lbResultName.Text = "Có sinh viên tên là " + tbSearchName.Text.ToString();
                    else
                        lbResultName.Text = "Không có sinh viên";
                }
            }
        }

        private void btTimNum_Click(object sender, EventArgs e)
        {
            if (tbSearchNum.Text == "")
                MessageBox.Show("Bạn phải nhập dữ liệu tìm kiếm");
            else
            {
                for (int i = 0; i < lsSv.Items.Count; i++)
                {
                    if (lsSv.Items[i].SubItems[1].Text == tbSearchNum.Text)
                        lbResultNum.Text = "Có sinh viên MSSV là " + tbSearchNum.Text.ToString();
                    else
                        lbResultNum.Text = "Không có sinh viên";
                }
            }
        }
    }
}
