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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace App_ListViewDemo_BTTuLam_BTH7
{
    public partial class Form1 : Form
    {
        string luuPath = null;
        public Form1()
        {
            InitializeComponent();


        }

        private void comboBoxFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewFolder.Items.Clear();
            try
            {
                if (comboBoxFolder.SelectedItem != null)
                {
                    lbFolder.Text = comboBoxFolder.SelectedItem.ToString();
                    luuPath = lbFolder.Text;
                    foreach (string directory in Directory.GetDirectories(lbFolder.Text))
                    {
                        ListViewItem item = new ListViewItem(Path.GetFileName(directory));
                        item.SubItems.Add("");
                        item.SubItems.Add(Directory.GetLastAccessTime(directory).ToString());
                        if (radioButton1.Checked)
                            item.ImageIndex = 2;
                        else if (radioButton3.Checked)
                            item.ImageIndex = 0;
                        listViewFolder.Items.Add(item);
                    }
                    foreach (string file in Directory.GetFiles(lbFolder.Text))
                    {
                        ListViewItem item = new ListViewItem(Path.GetFileName(file));
                        item.SubItems.Add("");
                        item.SubItems.Add(File.GetLastAccessTime(file).ToString());
                        if (radioButton1.Checked)
                            item.ImageIndex = 2;
                        else if (radioButton3.Checked)
                            item.ImageIndex = 0;
                        listViewFolder.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a folder.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string[] drives = Directory.GetLogicalDrives();
            foreach (string drive in drives)
            {
                comboBoxFolder.Items.Add(drive);
            }
            comboBoxFolder.SelectedIndex = 0;
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxFolder_SelectedIndexChanged(sender, e);
            listViewFolder_DoubleClick(sender, e);
        }

        private void listViewFolder_DoubleClick(object sender, EventArgs e)
        {
            luuPath += @"\" + listViewFolder.SelectedItems[0].Text;
            try
            {
                if (listViewFolder.SelectedItems[0].Text.ToLower().EndsWith(".pdf") ||
                    listViewFolder.SelectedItems[0].Text.ToLower().EndsWith(".txt") ||
                    listViewFolder.SelectedItems[0].Text.ToLower().EndsWith(".docs") ||
                    listViewFolder.SelectedItems[0].Text.ToLower().EndsWith(".doc") ||
                    listViewFolder.SelectedItems[0].Text.ToLower().EndsWith(".empl"))
                {
                    using (StreamReader read = new StreamReader(luuPath))
                    {
                        Form2 frm = new Form2();
                        frm.data(read.ReadToEnd());
                        frm.ShowDialog();
                    }
                    //sau khi chon xong phai xoa path de chon lai;
                    luuPath = luuPath.Substring(0, luuPath.Length - listViewFolder.SelectedItems[0].Text.Length);
                }
                else
                {
                    string[] path = Directory.GetDirectories(luuPath);
                    listViewFolder.Items.Clear();
                    foreach (string drive in path)
                    {
                        ListViewItem temp = new ListViewItem(Path.GetFileName(drive));
                        temp.SubItems.Add("");
                        temp.SubItems.Add(Directory.GetLastAccessTime(drive).ToString());
                        if (radioButton1.Checked == true)
                            temp.ImageIndex = 2;
                        else if (radioButton3.Checked == true)
                            temp.ImageIndex = 0;
                        listViewFolder.Items.Add(temp);
                    }
                    foreach (string drive in Directory.GetFiles(luuPath))
                    {
                        try
                        {
                            FileInfo f = new FileInfo(luuPath + @"\" + Path.GetFileName(drive));
                            ListViewItem temp = new ListViewItem(Path.GetFileName(drive));
                            temp.SubItems.Add(((double)(f.Length) / 1000).ToString());
                            temp.SubItems.Add(Directory.GetLastAccessTime(drive).ToString());
                            temp.ImageIndex = 1;
                            listViewFolder.Items.Add(temp);
                        }
                        catch (IOException ex)
                        {
                            // xử lý ngoại lệ khi không thể lấy thông tin về file
                            Console.WriteLine("IOException occurred: " + ex.Message);
                        }
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                // xử lý ngoại lệ khi không tìm thấy tệp tin
                Console.WriteLine("FileNotFoundException occurred: " + ex.Message);
            }
            catch (IOException ex)
            {
                // xử lý ngoại lệ khi có lỗi trong quá trình đọc tệp tin
                Console.WriteLine("IOException occurred: " + ex.Message);
            }
        }
    }
}

