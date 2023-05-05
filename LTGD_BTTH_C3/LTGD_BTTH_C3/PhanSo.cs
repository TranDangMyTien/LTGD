using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTGD_BTTH_C3
{
    internal class PhanSo
    {
        int ts, ms;
        public PhanSo()
        {
            ts = 0;
            ms = 1;
        }
        public PhanSo(int t, int m)
        {
            ts = t;
            ms = m == 0 ? 1 : m; //Bắt lỗi không cho mẫu số bằng 0 
        }
        public int TS
        {
            get { return ts; }
            set { ts = value; }
        }
        public int MS
        {
            get { return ms; }
            set { ms = value; }
        }
        private void toiGian()
        {
            int uc = LopDungChung.USCLN(ts, ms);
            if (uc > 0)
            {
                ts /= uc;
                ms /= uc;
            }
        }
        public PhanSo cong(PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.ts = ts * b.ms + ms * b.ts;
            kq.ms = ms * b.ms;
            kq.toiGian();
            return kq;
        }
        public PhanSo tru(PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.ts = ts * b.ms - ms * b.ts;
            kq.ms = ms * b.ms;
            kq.toiGian();
            return kq;
        }
        public PhanSo nhan(PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.ts = ts * b.ts;
            kq.ms = ms * b.ms;
            kq.toiGian();
            return kq;
        }
        public PhanSo chia(PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.ts = ts * b.ms;
            kq.ms = ms * b.ts;
            kq.toiGian();
            return kq;
        }
    }
}
