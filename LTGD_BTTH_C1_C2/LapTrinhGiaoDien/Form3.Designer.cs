namespace WinFormsBanDau
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.bntTinh = new System.Windows.Forms.Button();
            this.lbKQ = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdChiaDu = new System.Windows.Forms.RadioButton();
            this.rdChia = new System.Windows.Forms.RadioButton();
            this.rdNhan = new System.Windows.Forms.RadioButton();
            this.rdTru = new System.Windows.Forms.RadioButton();
            this.rdCong = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(782, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Các phép tính đơn giản ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(432, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số thứ 2: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSo2
            // 
            this.txtSo2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSo2.Location = new System.Drawing.Point(557, 102);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(138, 39);
            this.txtSo2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(58, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 35);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số thứ 1: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSo1
            // 
            this.txtSo1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSo1.Location = new System.Drawing.Point(183, 102);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(138, 39);
            this.txtSo1.TabIndex = 5;
            // 
            // bntTinh
            // 
            this.bntTinh.AutoSize = true;
            this.bntTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bntTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntTinh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntTinh.Location = new System.Drawing.Point(524, 340);
            this.bntTinh.Name = "bntTinh";
            this.bntTinh.Size = new System.Drawing.Size(133, 56);
            this.bntTinh.TabIndex = 9;
            this.bntTinh.Text = "Tính";
            this.bntTinh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntTinh.UseVisualStyleBackColor = false;
            this.bntTinh.Click += new System.EventHandler(this.bntTinh_Click);
            // 
            // lbKQ
            // 
            this.lbKQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbKQ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbKQ.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lbKQ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbKQ.Location = new System.Drawing.Point(183, 347);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(317, 49);
            this.lbKQ.TabIndex = 7;
            this.lbKQ.Text = " ";
            this.lbKQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(58, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kết quả: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.rdChiaDu);
            this.groupBox1.Controls.Add(this.rdChia);
            this.groupBox1.Controls.Add(this.rdNhan);
            this.groupBox1.Controls.Add(this.rdTru);
            this.groupBox1.Controls.Add(this.rdCong);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(84, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 150);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán";
            // 
            // rdChiaDu
            // 
            this.rdChiaDu.AutoSize = true;
            this.rdChiaDu.Location = new System.Drawing.Point(454, 58);
            this.rdChiaDu.Name = "rdChiaDu";
            this.rdChiaDu.Size = new System.Drawing.Size(65, 42);
            this.rdChiaDu.TabIndex = 0;
            this.rdChiaDu.Text = "%";
            this.rdChiaDu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdChiaDu.UseVisualStyleBackColor = true;
            // 
            // rdChia
            // 
            this.rdChia.AutoSize = true;
            this.rdChia.Location = new System.Drawing.Point(347, 58);
            this.rdChia.Name = "rdChia";
            this.rdChia.Size = new System.Drawing.Size(53, 42);
            this.rdChia.TabIndex = 0;
            this.rdChia.Text = "/";
            this.rdChia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdChia.UseVisualStyleBackColor = true;
            // 
            // rdNhan
            // 
            this.rdNhan.AutoSize = true;
            this.rdNhan.Location = new System.Drawing.Point(238, 58);
            this.rdNhan.Name = "rdNhan";
            this.rdNhan.Size = new System.Drawing.Size(55, 42);
            this.rdNhan.TabIndex = 0;
            this.rdNhan.Text = "x";
            this.rdNhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdNhan.UseVisualStyleBackColor = true;
            // 
            // rdTru
            // 
            this.rdTru.AutoSize = true;
            this.rdTru.Location = new System.Drawing.Point(131, 58);
            this.rdTru.Name = "rdTru";
            this.rdTru.Size = new System.Drawing.Size(53, 42);
            this.rdTru.TabIndex = 0;
            this.rdTru.Text = "-";
            this.rdTru.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdTru.UseVisualStyleBackColor = true;
            // 
            // rdCong
            // 
            this.rdCong.AutoSize = true;
            this.rdCong.Location = new System.Drawing.Point(16, 58);
            this.rdCong.Name = "rdCong";
            this.rdCong.Size = new System.Drawing.Size(61, 42);
            this.rdCong.TabIndex = 0;
            this.rdCong.Text = "+";
            this.rdCong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdCong.UseVisualStyleBackColor = true;
            this.rdCong.CheckedChanged += new System.EventHandler(this.rdCong_CheckedChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(782, 440);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bntTinh);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Các phép tính ";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label4;
        private TextBox txtSo2;
        private Label label5;
        private TextBox txtSo1;
        private Button bntTinh;
        private Label lbKQ;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton rdChiaDu;
        private RadioButton rdChia;
        private RadioButton rdNhan;
        private RadioButton rdTru;
        private RadioButton rdCong;
    }
}