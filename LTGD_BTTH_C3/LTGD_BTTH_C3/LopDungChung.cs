﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTGD_BTTH_C3
{
    internal class LopDungChung
    {
        public static int USCLN(int a, int b)
        {
            int a1 = Math.Abs(a);
            int b1 = Math.Abs(b);
            if (b1 == 0)
                return a1;
            return USCLN(b1, a1 % b1);
        }

    }
}
