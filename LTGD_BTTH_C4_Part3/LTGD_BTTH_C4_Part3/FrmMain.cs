namespace LTGD_BTTH_C4_Part3
{
    public partial class FrmMain : Form
    {
        public static string TenDangNhap = "";
        public bool bClose;
        public FrmMain()
        {
            FrmDangnhap f = new FrmDangnhap(); ;
            f.ShowDialog();
            InitializeComponent();
        }

      

        private void bntThem_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "") return;
            ListViewItem item = new ListViewItem(txtHoTen.Text);
            item.SubItems.Add(dtNgaySinh.Value.ToString());
            item.SubItems.Add(rbNam.Checked ? "Nam" : "Nữ");
            item.ImageIndex = rbNam.Checked ? 0 : 1;
            listNhanVien.Items.Add(item);
            //Chuyển focus về ô họ tên 
            txtHoTen.Text = "";
            txtHoTen.Focus();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            txtDN.Text = TenDangNhap;
            bClose = false;
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listNhanVien.SelectedItems)
                listNhanVien.Items.Remove(item);
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!bClose)
            {
                e.Cancel = true;
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.05;
            if(this.Opacity <= 0)
            {
                bClose = true;
                Application.Exit();
            }
        }
    }
}