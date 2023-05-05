using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ThongKe_BTTL_BTH6
{
    public partial class Form1 : Form
    {
        int[] arr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void NhapMang(int[] arr)
        {
            Random random = new Random();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] =random.Next(1, 100);
                
            }
        }
        void XuatMang(int[] arr)
        {
            textBox1.Text = " ";
            for(int i = 0;i < arr.Length;i++)
            {
                textBox6.Text += Convert.ToString(arr[i] + " ");
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int gt;
                gt = Convert.ToInt32(textBox1.Text);
                arr = new int[gt];
                NhapMang(arr);
                XuatMang(arr);
            }
            catch (Exception ex) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TongChan();
            TongLe();
            TBCmang();
            btnFindPrime();
        }
        private void TongChan()
        {
            long t = 0;
            for(int i = 0;i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    t += arr[i];
            }
            textBox2.Text = Convert.ToString(t);
        }
        private void TongLe()
        {
            long t = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                    t += arr[i];
            }
            textBox3.Text = Convert.ToString(t);
        }
      
        private void TBCmang()
        {
           
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                
            }
            double average = (double)sum / arr.Length;
            textBox4.Text = average.ToString();
        }
        private bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            int boundary = (int)Math.Floor(Math.Sqrt(n));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
        private void btnFindPrime()
        {
            
            List<int> primes = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrime(arr[i]))
                {
                    primes.Add(arr[i]);
                }
            }
            string result = " ";
            for (int i = 0; i < primes.Count; i++)
            {
                result += primes[i].ToString() + " ";
            }

            textBox5.Text = result.ToString();
        }
    }
}
