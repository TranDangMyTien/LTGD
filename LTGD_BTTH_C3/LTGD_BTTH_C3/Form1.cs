namespace LTGD_BTTH_C3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

      

        private void bntTru_Click(object sender, EventArgs e)
        {
            PHANSO a, b, kq;
            a = new PHANSO(); //Cách tạo thứ 1 
            kq = new PHANSO();
            try
            {
                a.TS = int.Parse(txtTuSo1.Text);
                a.MS = int.Parse(txtMauSo1.Text);
                b = new PHANSO(int.Parse(txtTuSo2.Text), int.Parse(txtMauSo2.Text)); //Cách tạo thứ 2 
                //kq = a.tong(b);
                //txtTuSokq.Text = kq.TS.ToString();
                //txtMauSokq.Text = kq.MS.ToString();
                kq.TS = a.TS * b.MS - a.MS * b.TS;
                kq.MS = a.MS * b.MS;
                txtTuSokq.Text = kq.TS.ToString();
                txtMauSokq.Text = kq.MS.ToString();
                
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void bntNhan_Click(object sender, EventArgs e)
        {
            PHANSO a, b, kq;
            a = new PHANSO(); //Cách tạo thứ 1 
            kq = new PHANSO();
            try
            {
                a.TS = int.Parse(txtTuSo1.Text);
                a.MS = int.Parse(txtMauSo1.Text);
                b = new PHANSO(int.Parse(txtTuSo2.Text), int.Parse(txtMauSo2.Text)); //Cách tạo thứ 2 
                //kq = a.tong(b);
                //txtTuSokq.Text = kq.TS.ToString();
                //txtMauSokq.Text = kq.MS.ToString();
                kq.TS = a.TS * b.TS;
                kq.MS = a.MS * b.MS;
                txtTuSokq.Text = kq.ToString();
                txtMauSokq.Text = kq.MS.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
           
        }

        private void bntCong_Click(object sender, EventArgs e)
        {
           
            PHANSO a, b, kq;
            a = new PHANSO(); //Cách tạo thứ 1 
            kq = new PHANSO();
           
            try
            {
                a.TS = int.Parse(txtTuSo1.Text);
                a.MS = int.Parse(txtMauSo1.Text);
                b = new PHANSO(int.Parse(txtTuSo2.Text), int.Parse(txtMauSo2.Text)); //Cách tạo thứ 2 
                kq = a.tong(b);
               
                txtTuSokq.Text = kq.TS.ToString();
                txtMauSokq.Text = kq.MS.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
            //finally
            //{
            //    txtMauSokq.Clear();
            //    txtTuSokq.Clear();
            //    txtTuSo1.Clear();
            //    txtMauSo1.Clear();
            //    txtTuSo2.Clear();
            //    txtMauSo2.Clear();

            //}
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTuSo1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMauSo2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntChia_Click(object sender, EventArgs e)
        {
            PHANSO a, b, kq;
            a = new PHANSO(); //Cách tạo thứ 1 
            kq = new PHANSO();
            try
            {
                a.TS = int.Parse(txtTuSo1.Text);
                a.MS = int.Parse(txtMauSo1.Text);
                b = new PHANSO(int.Parse(txtTuSo2.Text), int.Parse(txtMauSo2.Text)); //Cách tạo thứ 2 
                //kq = a.tong(b);
                //txtTuSokq.Text = kq.TS.ToString();
                //txtMauSokq.Text = kq.MS.ToString();
                kq.TS = a.TS * b.MS;
                kq.MS = a.MS * b.TS;
                txtTuSokq.Text = kq.TS.ToString();
                txtMauSokq.Text = kq.MS.ToString();
                //txtTuSokq.Text = kq.toiGianPhanSo(kq).TS.ToString();
                //txtMauSokq.Text = kq.toiGianPhanSo(kq).MS.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Lỗi chia cho 0", "Thông báo", MessageBoxButtons.OKCancel);
            }
        }

        private void txtMauSo1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    public class PHANSO
    {
        private int ts, ms;
        public PHANSO() //Phương thức khởi tạo không tham số 
        {
            ts = 0;
            ms = 1;
        }
        public PHANSO(int t, int m) //Phương thức khởi tạo có tham số 
        {
            this.ts = t;
            this.ms = m;
        }
        //THUỘC TÍNH GET SET    
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
        //Phương thức cộng 
        public PHANSO tong(PHANSO a)
        {
            PHANSO k = new PHANSO();
            k.ts = ts * a.ms + a.ts * ms;
            k.ms = ms * a.ms;
            return k;
        }
        //Tìm ước chung lớn nhất 
        public int timUCLN(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }
        public PHANSO toiGianPhanSo(PHANSO rutGon)
        {
            //PHANSO rutGon = new PHANSO();
            int uocChung = timUCLN(rutGon.ts, rutGon.ms);
            if (uocChung != 0)
            {
                rutGon.ts = ts / uocChung;
                rutGon.ms = ms / uocChung;
            }
            else
            {
                rutGon.ts = ts;
                rutGon.ms = ms;
            }
            return rutGon;
        }
        public void xuat()
        {
            Console.Write(" {0}/{1} ", ts, ms);
        }
    }
}