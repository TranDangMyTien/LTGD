namespace CommonDialog
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnMTT = new System.Windows.Forms.Button();
            this.btnNTT = new System.Windows.Forms.Button();
            this.btnThuMuc = new System.Windows.Forms.Button();
            this.btnNen = new System.Windows.Forms.Button();
            this.btnChu = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.listKetQua = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.timerOut = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnMTT
            // 
            this.btnMTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMTT.Location = new System.Drawing.Point(14, 38);
            this.btnMTT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMTT.Name = "btnMTT";
            this.btnMTT.Size = new System.Drawing.Size(243, 54);
            this.btnMTT.TabIndex = 0;
            this.btnMTT.Text = "Chọn một tập tin";
            this.btnMTT.UseVisualStyleBackColor = true;
            this.btnMTT.Click += new System.EventHandler(this.btnMTT_Click);
            // 
            // btnNTT
            // 
            this.btnNTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNTT.Location = new System.Drawing.Point(14, 121);
            this.btnNTT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNTT.Name = "btnNTT";
            this.btnNTT.Size = new System.Drawing.Size(243, 54);
            this.btnNTT.TabIndex = 0;
            this.btnNTT.Text = "Chọn nhiều tập tin";
            this.btnNTT.UseVisualStyleBackColor = true;
            this.btnNTT.Click += new System.EventHandler(this.btnNTT_Click);
            // 
            // btnThuMuc
            // 
            this.btnThuMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuMuc.Location = new System.Drawing.Point(14, 205);
            this.btnThuMuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThuMuc.Name = "btnThuMuc";
            this.btnThuMuc.Size = new System.Drawing.Size(243, 54);
            this.btnThuMuc.TabIndex = 0;
            this.btnThuMuc.Text = "Chọn thư mục";
            this.btnThuMuc.UseVisualStyleBackColor = true;
            this.btnThuMuc.Click += new System.EventHandler(this.btnThuMuc_Click);
            // 
            // btnNen
            // 
            this.btnNen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNen.Location = new System.Drawing.Point(14, 289);
            this.btnNen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNen.Name = "btnNen";
            this.btnNen.Size = new System.Drawing.Size(243, 54);
            this.btnNen.TabIndex = 0;
            this.btnNen.Text = "Chọn màu nền";
            this.btnNen.UseVisualStyleBackColor = true;
            this.btnNen.Click += new System.EventHandler(this.btnNen_Click);
            // 
            // btnChu
            // 
            this.btnChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChu.Location = new System.Drawing.Point(14, 372);
            this.btnChu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChu.Name = "btnChu";
            this.btnChu.Size = new System.Drawing.Size(243, 54);
            this.btnChu.TabIndex = 0;
            this.btnChu.Text = "Chọn màu chữ";
            this.btnChu.UseVisualStyleBackColor = true;
            this.btnChu.Click += new System.EventHandler(this.btnChu_Click);
            // 
            // btnFont
            // 
            this.btnFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFont.Location = new System.Drawing.Point(14, 456);
            this.btnFont.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(243, 54);
            this.btnFont.TabIndex = 0;
            this.btnFont.Text = "Chọn font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // listKetQua
            // 
            this.listKetQua.FormattingEnabled = true;
            this.listKetQua.ItemHeight = 20;
            this.listKetQua.Location = new System.Drawing.Point(282, 45);
            this.listKetQua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listKetQua.Name = "listKetQua";
            this.listKetQua.Size = new System.Drawing.Size(604, 384);
            this.listKetQua.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(328, 456);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(243, 54);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(608, 456);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(243, 54);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // timerLoad
            // 
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // timerOut
            // 
            this.timerOut.Tick += new System.EventHandler(this.timerOut_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 529);
            this.Controls.Add(this.listKetQua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnChu);
            this.Controls.Add(this.btnNen);
            this.Controls.Add(this.btnThuMuc);
            this.Controls.Add(this.btnNTT);
            this.Controls.Add(this.btnMTT);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMTT;
        private System.Windows.Forms.Button btnNTT;
        private System.Windows.Forms.Button btnThuMuc;
        private System.Windows.Forms.Button btnNen;
        private System.Windows.Forms.Button btnChu;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.ListBox listKetQua;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Timer timerLoad;
        private System.Windows.Forms.Timer timerOut;
    }
}

