namespace LTGD_C2_BT_LamThem
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.btnChuyenSo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKQ1 = new System.Windows.Forms.TextBox();
            this.txtKyTu = new System.Windows.Forms.TextBox();
            this.btnChuyenKT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(858, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHUYỂN MÃ ASCII";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKQ);
            this.groupBox1.Controls.Add(this.txtSo);
            this.groupBox1.Controls.Add(this.btnChuyenSo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(25, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 402);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chuyển mã ASCII sang ký tự ";
            // 
            // txtKQ
            // 
            this.txtKQ.Enabled = false;
            this.txtKQ.Location = new System.Drawing.Point(189, 294);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(159, 46);
            this.txtKQ.TabIndex = 0;
            this.txtKQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(189, 68);
            this.txtSo.Multiline = true;
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(159, 46);
            this.txtSo.TabIndex = 0;
            // 
            // btnChuyenSo
            // 
            this.btnChuyenSo.Location = new System.Drawing.Point(189, 163);
            this.btnChuyenSo.Name = "btnChuyenSo";
            this.btnChuyenSo.Size = new System.Drawing.Size(159, 60);
            this.btnChuyenSo.TabIndex = 0;
            this.btnChuyenSo.Text = "Chuyển";
            this.btnChuyenSo.UseVisualStyleBackColor = true;
            this.btnChuyenSo.Click += new System.EventHandler(this.btnChuyenSo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kết quả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã ASCII";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKQ1);
            this.groupBox2.Controls.Add(this.txtKyTu);
            this.groupBox2.Controls.Add(this.btnChuyenKT);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(450, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 402);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chuyển ký tự sang mã ASCII";
            // 
            // txtKQ1
            // 
            this.txtKQ1.Enabled = false;
            this.txtKQ1.Location = new System.Drawing.Point(189, 294);
            this.txtKQ1.Multiline = true;
            this.txtKQ1.Name = "txtKQ1";
            this.txtKQ1.Size = new System.Drawing.Size(159, 46);
            this.txtKQ1.TabIndex = 0;
            this.txtKQ1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKyTu
            // 
            this.txtKyTu.Location = new System.Drawing.Point(189, 68);
            this.txtKyTu.Multiline = true;
            this.txtKyTu.Name = "txtKyTu";
            this.txtKyTu.Size = new System.Drawing.Size(159, 46);
            this.txtKyTu.TabIndex = 0;
            // 
            // btnChuyenKT
            // 
            this.btnChuyenKT.Location = new System.Drawing.Point(189, 163);
            this.btnChuyenKT.Name = "btnChuyenKT";
            this.btnChuyenKT.Size = new System.Drawing.Size(159, 60);
            this.btnChuyenKT.TabIndex = 0;
            this.btnChuyenKT.Text = "Chuyển";
            this.btnChuyenKT.UseVisualStyleBackColor = true;
            this.btnChuyenKT.Click += new System.EventHandler(this.btnChuyenKT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kết quả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ký tự ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(25F, 49F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(858, 551);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "Form1";
            this.Text = "Chuyển mã ASCII ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox txtKQ;
        private TextBox txtSo;
        private Button btnChuyenSo;
        private GroupBox groupBox2;
        private TextBox txtKQ1;
        private TextBox txtKyTu;
        private Button btnChuyenKT;
        private Label label4;
        private Label label5;
    }
}