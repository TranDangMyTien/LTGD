namespace LTGD_BTTH_C5
{
    public partial class Form1 : Form
    {
        string path;
        Random r = new Random();
        Point d;
        PictureBox Hinh;

        public Form1()
        {
            InitializeComponent();
        }
        public void AddNewPicture()
        {
            Hinh = new PictureBox();
            int so = r.Next(1, 7);
            Hinh.Image = Image.FromFile(path + so.ToString() + ".jpg");
            Hinh.Location = new Point(30, 40); //Vị trí khởi tạo ban đầu cho hình xuất hiện 
            Hinh.Size = new Size(60, 70); //Khởi tạo kích thước cho hình 
            Hinh.SizeMode = PictureBoxSizeMode.StretchImage;
            Hinh.MouseDown += new MouseEventHandler(Hinh_MouseDown);
            Hinh.MouseMove += new MouseEventHandler(Hinh_MouseMove);
            Hinh.MouseUp += new MouseEventHandler(Hinh_MouseUp);
            Controls.Add(Hinh);
        }
        private void Hinh_MouseDown(object sender, MouseEventArgs e)
        {
            d = e.Location;
        }
        private void Hinh_MouseMove(object sender, MouseEventArgs e)
        {
            int dx = e.X - d.X;
            int dy = e.Y - d.Y;
            Hinh.Left += dx;
            Hinh.Top += dy;
        }
        private void Hinh_MouseUp(object sender, MouseEventArgs e)
        {
            if (pnBound.Bounds.Contains(Hinh.Bounds)) 
            {
                PictureBox a = (PictureBox)sender;
                pnBound.Controls.Add(a);
                AddNewPicture();
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cách lấy đường dẫn, mặc định là vào Debug 
            path = Application.StartupPath + @"\IMAGES\";
            AddNewPicture();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    d = Hinh.Location;
                    Hinh.Left -= 5;
                    Hinh.Top += 0;
                    break;
                case Keys.Up:
                    d = Hinh.Location;
                    Hinh.Left += 0;
                    Hinh.Top -= 5;
                    break;
                case Keys.Down:
                    d = Hinh.Location;
                    Hinh.Left += 0;
                    Hinh.Top += 5 ;
                    break;
                case Keys.Right:
                    d = Hinh.Location;
                    Hinh.Left += 5;
                    Hinh.Top += 0;
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}