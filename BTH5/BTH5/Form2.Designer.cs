
namespace BTH5
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbSoPt = new System.Windows.Forms.TextBox();
            this.btInit = new System.Windows.Forms.Button();
            this.btSort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMang = new System.Windows.Forms.TextBox();
            this.tbMangTang = new System.Windows.Forms.TextBox();
            this.tbMangGiam = new System.Windows.Forms.TextBox();
            this.tbMangDao = new System.Windows.Forms.TextBox();
            this.tbMangCuoi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phần tử:";
            // 
            // tbSoPt
            // 
            this.tbSoPt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSoPt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSoPt.Location = new System.Drawing.Point(154, 25);
            this.tbSoPt.Name = "tbSoPt";
            this.tbSoPt.Size = new System.Drawing.Size(105, 39);
            this.tbSoPt.TabIndex = 1;
            this.tbSoPt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btInit
            // 
            this.btInit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btInit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btInit.Location = new System.Drawing.Point(349, 12);
            this.btInit.Name = "btInit";
            this.btInit.Size = new System.Drawing.Size(279, 61);
            this.btInit.TabIndex = 2;
            this.btInit.Text = "Tạo mảng ngẫu nhiên";
            this.btInit.UseVisualStyleBackColor = false;
            this.btInit.Click += new System.EventHandler(this.btInit_Click);
            // 
            // btSort
            // 
            this.btSort.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btSort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSort.Location = new System.Drawing.Point(665, 14);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(279, 61);
            this.btSort.TabIndex = 2;
            this.btSort.Text = "Sắp xếp";
            this.btSort.UseVisualStyleBackColor = false;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mảng ban đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mảng tăng dần:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mảng giảm dần:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mảng đảo ngược:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mảng chẵn tăng, lẻ giảm:";
            // 
            // tbMang
            // 
            this.tbMang.BackColor = System.Drawing.SystemColors.Info;
            this.tbMang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMang.Location = new System.Drawing.Point(321, 147);
            this.tbMang.Name = "tbMang";
            this.tbMang.Size = new System.Drawing.Size(623, 39);
            this.tbMang.TabIndex = 1;
            // 
            // tbMangTang
            // 
            this.tbMangTang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMangTang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMangTang.Location = new System.Drawing.Point(321, 218);
            this.tbMangTang.Name = "tbMangTang";
            this.tbMangTang.Size = new System.Drawing.Size(623, 39);
            this.tbMangTang.TabIndex = 1;
            // 
            // tbMangGiam
            // 
            this.tbMangGiam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMangGiam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMangGiam.Location = new System.Drawing.Point(321, 289);
            this.tbMangGiam.Name = "tbMangGiam";
            this.tbMangGiam.Size = new System.Drawing.Size(623, 39);
            this.tbMangGiam.TabIndex = 1;
            // 
            // tbMangDao
            // 
            this.tbMangDao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMangDao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMangDao.Location = new System.Drawing.Point(321, 360);
            this.tbMangDao.Name = "tbMangDao";
            this.tbMangDao.Size = new System.Drawing.Size(623, 39);
            this.tbMangDao.TabIndex = 1;
            // 
            // tbMangCuoi
            // 
            this.tbMangCuoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMangCuoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMangCuoi.Location = new System.Drawing.Point(321, 431);
            this.tbMangCuoi.Name = "tbMangCuoi";
            this.tbMangCuoi.Size = new System.Drawing.Size(623, 39);
            this.tbMangCuoi.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 519);
            this.Controls.Add(this.btSort);
            this.Controls.Add(this.btInit);
            this.Controls.Add(this.tbMangCuoi);
            this.Controls.Add(this.tbMangDao);
            this.Controls.Add(this.tbMangGiam);
            this.Controls.Add(this.tbMangTang);
            this.Controls.Add(this.tbMang);
            this.Controls.Add(this.tbSoPt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSoPt;
        private System.Windows.Forms.Button btInit;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMang;
        private System.Windows.Forms.TextBox tbMangTang;
        private System.Windows.Forms.TextBox tbMangGiam;
        private System.Windows.Forms.TextBox tbMangDao;
        private System.Windows.Forms.TextBox tbMangCuoi;
    }
}