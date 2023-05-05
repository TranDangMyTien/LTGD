using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTGD_BTTH_C3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtTu1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bntCong_Click(object sender, EventArgs e)
        {
            lbDau.Text = bntCong.Text;
            PhanSo ps1, ps2;
            try
            {
                ps1 = new PhanSo(int.Parse(txtTu1.Text), int.Parse(txtMau1.Text));
                ps2 = new PhanSo(int.Parse(txtTu2.Text), int.Parse(txtMau2.Text));
                PhanSo kq = ps1.cong(ps2);
                txtTu.Text = kq.TS.ToString();
                txtMau.Text = kq.MS.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void bntTru_Click(object sender, EventArgs e)
        {
            lbDau.Text = bntTru.Text;
            PhanSo ps1, ps2;
            try
            {
                ps1 = new PhanSo(int.Parse(txtTu1.Text), int.Parse(txtMau1.Text));
                ps2 = new PhanSo(int.Parse(txtTu2.Text), int.Parse(txtMau2.Text));
                PhanSo kq = ps1.tru(ps2);
                txtTu.Text = kq.TS.ToString();
                txtMau.Text = kq.MS.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void bntNhan_Click(object sender, EventArgs e)
        {
            lbDau.Text = bntNhan.Text;
            PhanSo ps1, ps2;
            try
            {
                ps1 = new PhanSo(int.Parse(txtTu1.Text), int.Parse(txtMau1.Text));
                ps2 = new PhanSo(int.Parse(txtTu2.Text), int.Parse(txtMau2.Text));
                PhanSo kq = ps1.nhan(ps2);
                txtTu.Text = kq.TS.ToString();
                txtMau.Text = kq.MS.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void bntChia_Click(object sender, EventArgs e)
        {
            lbDau.Text = bntChia.Text;
            PhanSo ps1, ps2;
            try
            {
                ps1 = new PhanSo(int.Parse(txtTu1.Text), int.Parse(txtMau1.Text));
                ps2 = new PhanSo(int.Parse(txtTu2.Text), int.Parse(txtMau2.Text));
                PhanSo kq = ps1.chia(ps2);
                txtTu.Text = kq.TS.ToString();
                txtMau.Text = kq.MS.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }
    }
}
