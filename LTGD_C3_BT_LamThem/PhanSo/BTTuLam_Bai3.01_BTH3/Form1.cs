using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTuLam_Bai3._01_BTH3
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private Fraction a;
        private Fraction b;
        private string operatorString;
        private Fraction result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateRandomProblem(); //Tạo hàm khởi tạo phân số 
        }
        private void GenerateRandomProblem()
        {
            int num1 = random.Next(1, 10); //tử 
            int num2 = random.Next(1, 10);
            int den1 = random.Next(1, 10); //tử 
            int den2 = random.Next(1, 10);

            a = new Fraction(num1, den1); //Tạo phân số nhờ 
            b = new Fraction(num2, den2);
            int operatorIndex = random.Next(1,5);
            switch (operatorIndex)
            {
                case 1:
                    operatorString = "+";
                    result = Fraction.Add(a, b);
                    break;
                case 2:
                    operatorString = "-";
                    result = Fraction.Subtract(a, b);
                    break;
                case 3:
                    operatorString = "*";
                    result = Fraction.Multiply(a, b);
                    break;
                case 4:
                    operatorString = "/";
                    result = Fraction.Divide(a, b);
                    break;
            }
            //$ Để chèn biểu thức 
            labelProblem.Text = $"{a.Numerator}/{a.Denominator} {operatorString} {b.Numerator}/{b.Denominator} = ?";
            textBoxNumerator.Clear(); //Xóa cái tử dự đoán khi phát sinh phép tính 2 phân số mới 
            textBoxDenominator.Clear(); //Xóa cái mẫu dự đóan khi phát sinh phép tính 2 phân số mới 
            textBoxNumerator.Focus(); //Đặt con trỏ vào textbox đó 
        }

        //Kiểm tra 
        private void button1_Click(object sender, EventArgs e)
        {    
            try
            {   //Tạo một phân số do người dùng nhập (để dự đoán kết quả 2 phép tính) 
                Fraction userAnswer = new Fraction(int.Parse(textBoxNumerator.Text), int.Parse(textBoxDenominator.Text));
                if (userAnswer.Numerator == result.Numerator && userAnswer.Denominator == result.Denominator)
                {
                    MessageBox.Show("Bạn đã trả lời đúng!");
                    GenerateRandomProblem();
                }
                else
                {
                    MessageBox.Show("Bạn đã trả lời sai!");
                    ResetMouseEventArgs();
                }
            }
            catch (FormatException)
            {
               MessageBox.Show("Vui lòng nhập đáp án ở dạng phân số!");
            }
        }

        //Tạo lại 
        private void button2_Click(object sender, EventArgs e)
        {

            labelProblem.Text = "";
            textBoxNumerator.Text = "";
            textBoxDenominator.Text = "";
            GenerateRandomProblem();

        }
    }
}
