namespace LTGD_C2_BT_LamThem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        

        private void btnChuyenSo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSo.Text == "")
                    throw new Exception("Phải nhập dữ liệu!"); //Ném ra nếu thiếu dữ liệu 
              
                int so = int.Parse(txtSo.Text); //Ép kiểu về dữ liệu số nguyên 
                txtKQ.Text = string.Format("{0}", (char)so); //Ép kiểu đầu ra là kiểu chỉ chứa 1 kí tự 
       
            }
            catch (FormatException)
            {
                MessageBox.Show("Phải nhập số!");
            }
            catch (Exception ex) //Có này thì cái throw new Exception "Phải nhập dữ liệu" mới diễn ra 
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnChuyenKT_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKyTu.Text == "")
                    throw new Exception("Phải nhập dữ liệu");
                char kt = char.Parse(txtKyTu.Text);
                txtKQ1.Text = string.Format("{0}", (int)kt);

            }
            catch (FormatException)
            {
                MessageBox.Show("Phải nhập ký tự!");
            }
            catch (Exception ex) //Có này thì cái throw new Exception "Phải nhập dữ liệu" mới diễn ra 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}