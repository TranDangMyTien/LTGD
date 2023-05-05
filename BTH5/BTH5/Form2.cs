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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int[] arrFirst;
        int[] arrTang;
        int[] arrGiam;
        int[] arrDao;
        int[] arrLast;

        private void Show(int[] arr, TextBox textBox)
        {
            textBox.Text = String.Empty;
            for (int i = 0; i < arr.Length; i++)
                textBox.Text += arr[i].ToString() + ",";
            textBox.Text = textBox.Text.TrimEnd(',');
        }
        private void btInit_Click(object sender, EventArgs e)
        {
            tbMangTang.Text = "";
            tbMangGiam.Text = "";
            tbMangDao.Text = "";
            tbMangCuoi.Text = "";

            try
            {
                int cnt = Int32.Parse(tbSoPt.Text);
                Random rd = new Random();
                arrFirst = new int[cnt];
                for (int i = 0; i < cnt; i++)
                    arrFirst[i] = rd.Next(0, 100);
                Show(arrFirst, tbMang);
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn phải nhập dữ liệu");
            }
        }
        
        private void Sort()
        {
            arrTang = new int[arrFirst.Length];
            arrGiam = new int[arrFirst.Length];
            arrDao = new int[arrFirst.Length];
            arrLast = new int[arrFirst.Length];

            try
            {
                //Mảng tăng
                Array.Copy(arrFirst, arrTang, arrFirst.Length);
                Array.Sort(arrTang);
                Show(arrTang, tbMangTang);

                //Mảng giảm
                Array.Copy(arrTang, arrGiam, arrFirst.Length);
                Array.Reverse(arrGiam);
                Show(arrGiam, tbMangGiam);

                //Mảng đảo ngược
                Array.Copy(arrFirst, arrDao, arrFirst.Length);
                Array.Reverse(arrDao);
                Show(arrDao, tbMangDao);

                //Chẵn tăng, lẻ giảm
                Array.Copy(arrFirst, arrLast, arrFirst.Length);
                int i = 0, j = arrLast.Length - 1;
                while (i < j) 
                {
                    if (arrLast[i] % 2 == 0)
                        i++;
                    if (arrLast[j] % 2 != 0)
                        j--;
                    if (i < j)
                    {
                        if (arrLast[i] % 2 != 0 && arrLast[j] % 2 == 0)
                        {
                            Swap(ref arrLast[i], ref arrLast[j]);
                            i++;
                            j--;
                        }
                    }
                }
                int mid = arrLast[i] % 2 != 0 ? i - 1 : i;

                for (int a = 0; a < mid; a++)
                    for (int b = a + 1; b < mid + 1; b++)
                        if (arrLast[a] > arrLast[b])
                            Swap(ref arrLast[a], ref arrLast[b]);

                for (int a = mid + 1; a < arrLast.Length; a++) 
                    for (int b = a + 1; b < arrLast.Length; b++)
                        if (arrLast[a] < arrLast[b])
                            Swap(ref arrLast[a], ref arrLast[b]);
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn phải có dữ liệu ở Mảng đầu");
            }
            Show(arrLast, tbMangCuoi);
        }
        private void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        private void btSort_Click(object sender, EventArgs e)
        {
            Sort();
            
        }
    }
}
