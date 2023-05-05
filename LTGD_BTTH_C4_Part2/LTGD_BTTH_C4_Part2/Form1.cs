namespace LTGD_BTTH_C4_Part2
{
    
    public partial class Form1 : Form
    {
        string pathImg;
        public Form1()
        {
            InitializeComponent();
        }

        private void lbname_Click(object sender, EventArgs e)
        {

        }

        //private void bntQS_Click(object sender, EventArgs e)
        //{
        //    int so1, so2, so3;
        //    lbname.Text = "  2151050455_Trần Đặng Mỹ Tiên  ";
        //    Random r = new Random();
        //    so1 = r.Next(1, 7); //Lớn nhất của nó là 6 
        //    so2 = r.Next(1, 7);
        //    so3 = r.Next(1, 7);
        //    pic1.Image = Image.FromFile(pathImg + "die6.jpg");
        //    //pic2.Image = Image.FromFile(path + "die" so2.ToString() + ".jpg");
        //    //pic3.Image = Image.FromFile(path + "die" so3.ToString() + ".jpg");
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            lbname.Text = "  2151050455_Trần Đặng Mỹ Tiên  ";
            pathImg = Application.StartupPath + @"\hinhxucxac\";
            pic1.Image = pic2.Image = pic3.Image = Image.FromFile(pathImg + "6.jpg");
        }
    }
}