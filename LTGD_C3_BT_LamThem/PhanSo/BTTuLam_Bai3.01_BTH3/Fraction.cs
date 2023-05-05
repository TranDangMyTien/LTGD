using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTuLam_Bai3._01_BTH3
{
    public class Fraction
    {
        private int numerator; // tử số
        private int denominator; // mẫu số

        //Tọa phương thức khởi tạo có tham số rồi nên hàm constructor sẽ không được tạo nữa (không cần dùng trong bài này) 
        public Fraction(int numerator, int denominator) //Phương thức khởi tạo có tham số 
        {
            this.numerator = numerator; 
            this.denominator = denominator;
        }

        public static Fraction Add(Fraction a, Fraction b) //Phương thức cộng 2 phân số 
        {
            int numerator = a.numerator * b.denominator + b.numerator * a.denominator;
            int denominator = a.denominator * b.denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction Subtract(Fraction a, Fraction b) //Phương thức trừ 2 phân số 
        {
            int numerator = a.numerator * b.denominator - b.numerator * a.denominator;
            int denominator = a.denominator * b.denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction Multiply(Fraction a, Fraction b) //Phương thức nhân 2 phân số 
        {
            int numerator = a.numerator * b.numerator;
            int denominator = a.denominator * b.denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction Divide(Fraction a, Fraction b) //Phương thức chia 2 phân số 
        {
            int numerator = a.numerator * b.denominator;
            int denominator = a.denominator * b.numerator;
            return new Fraction(numerator, denominator);
        }

        // getters và setters
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        public int Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        }
    }

}
