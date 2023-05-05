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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int[] arrFirst;
        private void btInit_Click(object sender, EventArgs e)
        {
            tbSumChan.Text = "";
            tbSumLe.Text = "";
            tbTBC.Text = "";
            tbSoNT.Text = "";

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
        private void Show(int[] arr, TextBox textBox)
        {
            textBox.Text = String.Empty;
            for (int i = 0; i < arr.Length; i++)
                textBox.Text += arr[i].ToString() + ",";
            textBox.Text = textBox.Text.TrimEnd(',');
        }
        
        private void btPlay_Click(object sender, EventArgs e)
        {
            int SumChan = 0;
            int SumLe = 0;
            double TbCong = 0;
            int Cnt = 0;
            for (int i = 0; i < arrFirst.Length; i++)
            {
                if (arrFirst[i] % 2 == 0)
                    SumChan += arrFirst[i];
                if (arrFirst[i] % 2 != 0)
                    SumLe += arrFirst[i];

                tbSumChan.Text = SumChan.ToString();
                tbSumLe.Text = SumLe.ToString();
                TbCong += arrFirst[i];
                tbTBC.Text = String.Format("{0:0.00}", (TbCong / arrFirst.Length).ToString());

            }
           
            
            for (int i = 0; i < arrFirst.Length; i++)
            {
                if(Check(arrFirst[i]) == 1)
                    Cnt++;
            }
            
            tbSoNT.Text = Cnt.ToString();
                
        }

        private int Check(int n)
        {
            int check = 1;
            int i = 2;
            while (i <= Math.Sqrt(n))
            {
                if (n % i == 0)
                {
                    check = 0;
                    break;
                }
                i++;
            }
            return check;
        }
    }
}
