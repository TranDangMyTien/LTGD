using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanh3._2
{

    internal class TamGiac
    {
        private double a, b, c;
        public TamGiac()
        {
            this.a = 1;
            this.b = 1;
            this.c = 1;
        }
        public TamGiac(double a, double b, double c)
        {
            this.a = a > 0 ? a : 1;
            this.b = b > 0 ? b : 1;
            this.c = c > 0 ? c : 1;

        }

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public double B
        {
            set { b = value; }
            get { return b; }
        }

        public double C
        {
            set { c = value; }
            get { return c; }
        }

        public static Boolean checkTamGiac(TamGiac t)
        {
            return (t.a + t.b) > t.c && (t.a + t.c) > t.b && (t.b + t.c) > t.a;
        }

        public static Boolean checkTamGiacCan(TamGiac t)
        {

            return t.a == t.b || t.b == t.c || t.c == t.a;


        }

        public static Boolean checkTamGiacDeu(TamGiac t)
        {

            return t.a == t.b && t.b == t.c && t.c == t.a;


        }

        public static double ChuVi(TamGiac t)
        {
            return t.a + t.b + t.c;
        }
        public static double DienTich(TamGiac t)
        {
            double c = TamGiac.ChuVi(t)/2;
            return Math.Sqrt(c * (c - t.a) * (c - t.b) * (c - t.c));
        }
        

    }
}

