namespace WinFormsBanDau
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbKQ = new System.Windows.Forms.Label();
            this.bntCong = new System.Windows.Forms.Button();
            this.bntTru = new System.Windows.Forms.Button();
            this.bntNhan = new System.Windows.Forms.Button();
            this.bntChia = new System.Windows.Forms.Button();
            this.bntDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(673, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các phép tính đơn giản ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(386, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ 2: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSo2
            // 
            this.txtSo2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSo2.Location = new System.Drawing.Point(511, 93);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(138, 39);
            this.txtSo2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số thứ 1: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSo1
            // 
            this.txtSo1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSo1.Location = new System.Drawing.Point(137, 93);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(138, 39);
            this.txtSo1.TabIndex = 2;
            this.txtSo1.TextChanged += new System.EventHandler(this.txtSo1_TextChanged);
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 35);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kết quả: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbKQ
            // 
            this.lbKQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbKQ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbKQ.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lbKQ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbKQ.Location = new System.Drawing.Point(137, 295);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(317, 49);
            this.lbKQ.TabIndex = 1;
            this.lbKQ.Text = " ";
            this.lbKQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bntCong
            // 
            this.bntCong.AutoSize = true;
            this.bntCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bntCong.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntCong.Location = new System.Drawing.Point(87, 171);
            this.bntCong.Name = "bntCong";
            this.bntCong.Size = new System.Drawing.Size(79, 80);
            this.bntCong.TabIndex = 3;
            this.bntCong.Text = "+";
            this.bntCong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntCong.UseVisualStyleBackColor = false;
            this.bntCong.Click += new System.EventHandler(this.bntCong_Click);
            // 
            // bntTru
            // 
            this.bntTru.AutoSize = true;
            this.bntTru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bntTru.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntTru.Location = new System.Drawing.Point(208, 171);
            this.bntTru.Name = "bntTru";
            this.bntTru.Size = new System.Drawing.Size(79, 80);
            this.bntTru.TabIndex = 3;
            this.bntTru.Text = "-";
            this.bntTru.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntTru.UseVisualStyleBackColor = false;
            this.bntTru.Click += new System.EventHandler(this.bntTru_Click);
            // 
            // bntNhan
            // 
            this.bntNhan.AutoSize = true;
            this.bntNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bntNhan.Font = new System.Drawing.Font("Segoe UI Semibold", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntNhan.Location = new System.Drawing.Point(329, 171);
            this.bntNhan.Name = "bntNhan";
            this.bntNhan.Size = new System.Drawing.Size(79, 80);
            this.bntNhan.TabIndex = 3;
            this.bntNhan.Text = "x";
            this.bntNhan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntNhan.UseVisualStyleBackColor = false;
            this.bntNhan.Click += new System.EventHandler(this.bntNhan_Click);
            // 
            // bntChia
            // 
            this.bntChia.AutoSize = true;
            this.bntChia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bntChia.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntChia.Location = new System.Drawing.Point(445, 171);
            this.bntChia.Name = "bntChia";
            this.bntChia.Size = new System.Drawing.Size(79, 80);
            this.bntChia.TabIndex = 3;
            this.bntChia.Text = "/";
            this.bntChia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntChia.UseVisualStyleBackColor = false;
            this.bntChia.Click += new System.EventHandler(this.bntChia_Click);
            // 
            // bntDong
            // 
            this.bntDong.AutoSize = true;
            this.bntDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bntDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntDong.Location = new System.Drawing.Point(479, 295);
            this.bntDong.Name = "bntDong";
            this.bntDong.Size = new System.Drawing.Size(133, 56);
            this.bntDong.TabIndex = 3;
            this.bntDong.Text = "Đóng";
            this.bntDong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntDong.UseVisualStyleBackColor = false;
            this.bntDong.Click += new System.EventHandler(this.bntDong_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(673, 401);
            this.Controls.Add(this.bntDong);
            this.Controls.Add(this.bntChia);
            this.Controls.Add(this.bntNhan);
            this.Controls.Add(this.bntTru);
            this.Controls.Add(this.bntCong);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Các phép tính ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSo2;
        private Label label3;
        private TextBox txtSo1;
        private Label label4;
        private Label lbKQ;
        private Button bntCong;
        private Button bntTru;
        private Button bntNhan;
        private Button bntChia;
        private Button bntDong;
    }
}