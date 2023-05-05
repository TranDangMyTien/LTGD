namespace LTGD_BTTH_C4_Part3
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.bntThem = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.txtDN = new System.Windows.Forms.TextBox();
            this.listNhanVien = new System.Windows.Forms.ListView();
            this.Hoten = new System.Windows.Forms.ColumnHeader();
            this.Ngaysinh = new System.Windows.Forms.ColumnHeader();
            this.Gioitinh = new System.Windows.Forms.ColumnHeader();
            this.imageLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageSmall = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1094, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý nhân viên ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên: ";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHoTen.Location = new System.Drawing.Point(162, 110);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(338, 38);
            this.txtHoTen.TabIndex = 0;
            //this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày sinh: ";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(164, 203);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(338, 35);
            this.dtNgaySinh.TabIndex = 1;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Checked = true;
            this.rbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNam.Location = new System.Drawing.Point(162, 294);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(89, 33);
            this.rbNam.TabIndex = 2;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            //this.rbNam.CheckedChanged += new System.EventHandler(this.rbNam_CheckedChanged);
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNu.Location = new System.Drawing.Point(325, 294);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(69, 33);
            this.rbNu.TabIndex = 3;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // bntThem
            // 
            this.bntThem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bntThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntThem.Location = new System.Drawing.Point(156, 387);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(155, 52);
            this.bntThem.TabIndex = 4;
            this.bntThem.Text = "Thêm ";
            this.bntThem.UseVisualStyleBackColor = false;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // bntXoa
            // 
            this.bntXoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bntXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntXoa.Location = new System.Drawing.Point(347, 387);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(155, 52);
            this.bntXoa.TabIndex = 5;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.UseVisualStyleBackColor = false;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // txtDN
            // 
            this.txtDN.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDN.Enabled = false;
            this.txtDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDN.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDN.Location = new System.Drawing.Point(25, 534);
            this.txtDN.Multiline = true;
            this.txtDN.Name = "txtDN";
            this.txtDN.Size = new System.Drawing.Size(475, 49);
            this.txtDN.TabIndex = 2;
            this.txtDN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //this.txtDN.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // listNhanVien
            // 
            this.listNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Hoten,
            this.Ngaysinh,
            this.Gioitinh});
            this.listNhanVien.LargeImageList = this.imageLarge;
            this.listNhanVien.Location = new System.Drawing.Point(544, 110);
            this.listNhanVien.Name = "listNhanVien";
            this.listNhanVien.Size = new System.Drawing.Size(521, 508);
            this.listNhanVien.SmallImageList = this.imageSmall;
            this.listNhanVien.TabIndex = 6;
            this.listNhanVien.UseCompatibleStateImageBehavior = false;
            this.listNhanVien.View = System.Windows.Forms.View.Details;
            // 
            // Hoten
            // 
            this.Hoten.Text = "Họ tên ";
            this.Hoten.Width = 200;
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.Text = "Ngày sinh ";
            this.Ngaysinh.Width = 190;
            // 
            // Gioitinh
            // 
            this.Gioitinh.Text = "Giới tính ";
            this.Gioitinh.Width = 160;
            // 
            // imageLarge
            // 
            this.imageLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageLarge.ImageStream")));
            this.imageLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageLarge.Images.SetKeyName(0, "boy.png");
            this.imageLarge.Images.SetKeyName(1, "girl.png");
            // 
            // imageSmall
            // 
            this.imageSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageSmall.ImageStream")));
            this.imageSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageSmall.Images.SetKeyName(0, "boy.png");
            this.imageSmall.Images.SetKeyName(1, "girl.png");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1094, 642);
            this.Controls.Add(this.listNhanVien);
            this.Controls.Add(this.bntXoa);
            this.Controls.Add(this.bntThem);
            this.Controls.Add(this.rbNu);
            this.Controls.Add(this.rbNam);
            this.Controls.Add(this.dtNgaySinh);
            this.Controls.Add(this.txtDN);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtHoTen;
        private Label label3;
        private DateTimePicker dtNgaySinh;
        private RadioButton rbNam;
        private RadioButton rbNu;
        private Button bntThem;
        private Button bntXoa;
        private TextBox txtDN;
        private ListView listNhanVien;
        private ColumnHeader Hoten;
        private ColumnHeader Ngaysinh;
        private ColumnHeader Gioitinh;
        private ImageList imageLarge;
        private ImageList imageSmall;
        private System.Windows.Forms.Timer timer1;
    }
}