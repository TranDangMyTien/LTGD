using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNhap.Text != "")
                {
                    ListBox1.Items.Add(txtNhap.Text);
                    txtNhap.Clear();
                    txtNhap.Focus();
                }    
            }
            catch(FormatException)
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhap.Clear();
                txtNhap.Focus();
            }
            catch(OverflowException)
            {
                MessageBox.Show("Vượt quá dữ liệu!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhap.Clear();
                txtNhap.Focus();
            }
        }

        bool CheckListBox(ListBox tmp)
        {
            if (tmp.Items.Count > 0)
                return true;
            return false;
        }

        private void btRight_Click(object sender, EventArgs e)
        {
           try
            {
                ListBox1.SelectionMode = SelectionMode.MultiSimple;//cho phép chọn nhiều item
                for (int i = ListBox1.SelectedItems.Count - 1; i >= 0; i--)
                    ListBox2.Items.Add(ListBox1.Items[i]);
                for (int i = ListBox1.SelectedItems.Count - 1; i >= 0; i--)
                    ListBox1.Items.Remove(ListBox1.Items[i]);
            }
            catch(Exception) { }
        }
        private void btLeft_Click(object sender, EventArgs e)
        {
            try
            {
                ListBox1.Items.Add(ListBox2.SelectedItem);
                ListBox2.Items.Remove(ListBox2.SelectedItem);
            }
            catch (Exception) { }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (CheckListBox(ListBox1) || CheckListBox(ListBox2))
            {
                for (int i = ListBox2.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ListBox2.Items.Remove(ListBox2.Items[i]);
                }
                for (int i = ListBox1.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ListBox1.Items.Remove(ListBox1.Items[i]);
                }
            }
            else
            {
                MessageBox.Show("List trống, không xóa được!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            if (ListBox1.Items.Count > 0)
                ListBox1.Items.Clear();
            if (ListBox2.Items.Count > 0)
                ListBox2.Items.Clear();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult ex = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ex == DialogResult.OK)
                this.Close();
        }

        private void comboBoxMau_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMau.SelectedIndex == 0)
                ListBox2.Items.Add("Đây là red");
            else if (comboBoxMau.SelectedIndex == 1)
                ListBox2.BackColor = Color.Green;
            else
                ListBox2.BackColor = Color.Pink;
        }
    }
}
