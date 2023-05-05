using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTGD_BTTH_C4_Part3
{
    public partial class FrmDangnhap : Form
    {
        public FrmDangnhap()
        {
            InitializeComponent();
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTenDangNhap.Text == "" || txtMatKhau.Text != "admin")
                Application.Exit();
            else
            {
                FrmMain.TenDangNhap = txtTenDangNhap.Text;
                this.Close();
            }
        }

        private void bntDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmDangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(FrmMain.TenDangNhap=="")
                Application.Exit();
        }
    }
}
