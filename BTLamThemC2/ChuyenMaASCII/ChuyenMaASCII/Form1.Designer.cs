
namespace ChuyenMaASCII
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
            this.btAsKi = new System.Windows.Forms.Button();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.lbKq1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btKiAs = new System.Windows.Forms.Button();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbKq2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(822, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHUYỂN MÃ ASCII";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btAsKi);
            this.groupBox1.Controls.Add(this.txtSo1);
            this.groupBox1.Controls.Add(this.lbKq1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(22, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 210);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chuyển mã ASCII sang ký tự";
            // 
            // btAsKi
            // 
            this.btAsKi.Location = new System.Drawing.Point(152, 98);
            this.btAsKi.Name = "btAsKi";
            this.btAsKi.Size = new System.Drawing.Size(132, 45);
            this.btAsKi.TabIndex = 2;
            this.btAsKi.Text = "Chuyển";
            this.btAsKi.UseVisualStyleBackColor = true;
            this.btAsKi.Click += new System.EventHandler(this.btAsKi_Click);
            // 
            // txtSo1
            // 
            this.txtSo1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSo1.Location = new System.Drawing.Point(152, 46);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(132, 37);
            this.txtSo1.TabIndex = 1;
            this.txtSo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbKq1
            // 
            this.lbKq1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbKq1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbKq1.Location = new System.Drawing.Point(152, 158);
            this.lbKq1.Name = "lbKq1";
            this.lbKq1.Size = new System.Drawing.Size(132, 31);
            this.lbKq1.TabIndex = 0;
            this.lbKq1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(44, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kết quả";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(44, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã ASCII";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btKiAs);
            this.groupBox2.Controls.Add(this.txtSo2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbKq2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(430, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 210);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chuyển ký tự sang mã ASCII";
            // 
            // btKiAs
            // 
            this.btKiAs.Location = new System.Drawing.Point(164, 98);
            this.btKiAs.Name = "btKiAs";
            this.btKiAs.Size = new System.Drawing.Size(132, 45);
            this.btKiAs.TabIndex = 2;
            this.btKiAs.Text = "Chuyển";
            this.btKiAs.UseVisualStyleBackColor = true;
            this.btKiAs.Click += new System.EventHandler(this.btKiAs_Click);
            // 
            // txtSo2
            // 
            this.txtSo2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSo2.Location = new System.Drawing.Point(164, 46);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(132, 37);
            this.txtSo2.TabIndex = 1;
            this.txtSo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(51, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kết quả";
            // 
            // lbKq2
            // 
            this.lbKq2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbKq2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbKq2.Location = new System.Drawing.Point(164, 158);
            this.lbKq2.Name = "lbKq2";
            this.lbKq2.Size = new System.Drawing.Size(132, 31);
            this.lbKq2.TabIndex = 0;
            this.lbKq2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(51, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 35);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ký tự";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(822, 365);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAsKi;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.Label lbKq1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btKiAs;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.Label lbKq2;
    }
}

