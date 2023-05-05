using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Editor
{
    public partial class Form1 : Form
    {
        bool isChecked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();
            foreach (FontFamily family in fonts.Families)
                listBox.Items.Add(family.Name);
            FontSize();
        }

        private void FontSize()//size chữ
        {
            for (int i = 8; i <= 32; i += 2)
                comboBox.Items.Add(i.ToString());
            comboBox.SelectedIndex = 3; //size chữ mặc định là = 14)
        }
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fontName = listBox.SelectedItem.ToString(); // lấy font chữ trong listbox
            //lấy văn bản được chọn trong richbox
            int selectionStart = richTextBox.SelectionStart;
            int selectionLength = richTextBox.SelectionLength;
            //đặt font chữ mới cho văn bản đc chọn
            richTextBox.SelectionFont = new Font(fontName, richTextBox.SelectionFont.Size, richTextBox.SelectionFont.Style);
            //khôi phục vị trí chọn ban đầu
            richTextBox.Select(selectionStart, selectionLength);
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            float fontSize = float.Parse(comboBox.SelectedItem.ToString());
            //lấy văn bản đc chọn trong richtextbox
            int selectionStart = richTextBox.SelectionStart;
            int selectionLength = richTextBox.SelectionLength;
            //đặt kích thước chữ cho văn bản được chọn
            richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, fontSize, richTextBox.Font.Style);
            //khôi phục vị trí ban đầu
            richTextBox.Select(selectionStart, selectionLength);
        }

        private void rdB_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rdB.Checked;
        }

        private void rdI_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rdI.Checked;
        }

        private void rdU_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rdU.Checked;
        }

        private void rdB_Click(object sender, EventArgs e)
        {
            FontStyle style = richTextBox.SelectionFont.Style;
            if(rdB.Checked && !isChecked)
            {
                rdB.Checked = false;
                style &= FontStyle.Bold;
            }
            else
            {
                rdB.Checked = true;
                isChecked = false;
                style |= FontStyle.Bold;
            }
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, style);
        }

        private void rdI_Click(object sender, EventArgs e)
        {
            FontStyle style = richTextBox.SelectionFont.Style;
            if(rdB.Checked && !isChecked)
            {
                rdB.Checked = false;
                style |= FontStyle.Italic;
            }
            {
                rdB.Checked = true;
                isChecked = false;
                style |= FontStyle.Italic;
            }
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, style);

        }

        private void rdU_Click(object sender, EventArgs e)
        {
            FontStyle style = richTextBox.SelectionFont.Style;
            if(rdB.Checked && !isChecked)
            {
                rdB.Checked = false;
                style &= FontStyle.Underline;
            }
            else
            {
                rdB.Checked = true;
                isChecked = false;
                style |= FontStyle.Underline;
            }
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, style);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //lấy giá trị màu từ hscrollbar
            Color color = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            //lấy văn bản đc chọn trong richtextbox
            int selectionStart = richTextBox.SelectionStart;
            int selectionLength = richTextBox.SelectionLength;
            //đặt màu cho văn bản dc chọn
            richTextBox.SelectionColor = color;
            //khoi phuc vi tri ban dau
            richTextBox.Select(selectionStart, selectionLength);

        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            Color color = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            int selectionStart = richTextBox.SelectionStart;
            int selectionLength = richTextBox.SelectionLength;
            richTextBox.SelectionColor = color;
            richTextBox.Select(selectionStart, selectionLength);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            Color color = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            int selectionStart = richTextBox.SelectionStart;
            int selectionLength = richTextBox.SelectionLength;
            richTextBox.SelectionColor = color;
            richTextBox.Select(selectionStart, selectionLength);
        }
    }
}
