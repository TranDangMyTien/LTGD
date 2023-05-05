
namespace BTH5
{
    partial class Form4
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
            this.lsSv = new System.Windows.Forms.ListView();
            this.hoTen = new System.Windows.Forms.ColumnHeader();
            this.Maso = new System.Windows.Forms.ColumnHeader();
            this.btThem = new System.Windows.Forms.Button();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaso = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbResultName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.btTimName = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbResultNum = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSearchNum = new System.Windows.Forms.TextBox();
            this.btTimNum = new System.Windows.Forms.Button();
            this.btSort = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsSv
            // 
            this.lsSv.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lsSv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hoTen,
            this.Maso});
            this.lsSv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lsSv.HideSelection = false;
            this.lsSv.HotTracking = true;
            this.lsSv.HoverSelection = true;
            this.lsSv.Location = new System.Drawing.Point(498, 101);
            this.lsSv.Name = "lsSv";
            this.lsSv.Size = new System.Drawing.Size(504, 240);
            this.lsSv.TabIndex = 15;
            this.lsSv.UseCompatibleStateImageBehavior = false;
            this.lsSv.View = System.Windows.Forms.View.Details;
            // 
            // hoTen
            // 
            this.hoTen.Text = "Họ Tên";
            this.hoTen.Width = 250;
            // 
            // Maso
            // 
            this.Maso.Text = "MSSV";
            this.Maso.Width = 250;
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btThem.Location = new System.Drawing.Point(58, 300);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(148, 41);
            this.btThem.TabIndex = 14;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // tbTen
            // 
            this.tbTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTen.Location = new System.Drawing.Point(136, 159);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(327, 39);
            this.tbTen.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "MSSV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1036, 84);
            this.label1.TabIndex = 10;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbMaso
            // 
            this.tbMaso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMaso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMaso.Location = new System.Drawing.Point(136, 224);
            this.tbMaso.Name = "tbMaso";
            this.tbMaso.Size = new System.Drawing.Size(327, 39);
            this.tbMaso.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbResultName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbSearchName);
            this.groupBox1.Controls.Add(this.btTimName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 368);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 251);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Sinh Viên Theo Tên";
            // 
            // lbResultName
            // 
            this.lbResultName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbResultName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbResultName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbResultName.Location = new System.Drawing.Point(131, 161);
            this.lbResultName.Name = "lbResultName";
            this.lbResultName.Size = new System.Drawing.Size(327, 43);
            this.lbResultName.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kết quả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nhập tên:";
            // 
            // tbSearchName
            // 
            this.tbSearchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearchName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSearchName.Location = new System.Drawing.Point(131, 69);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(228, 39);
            this.tbSearchName.TabIndex = 13;
            // 
            // btTimName
            // 
            this.btTimName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTimName.Location = new System.Drawing.Point(365, 69);
            this.btTimName.Name = "btTimName";
            this.btTimName.Size = new System.Drawing.Size(93, 41);
            this.btTimName.TabIndex = 14;
            this.btTimName.Text = "Tìm";
            this.btTimName.UseVisualStyleBackColor = true;
            this.btTimName.Click += new System.EventHandler(this.btTimName_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbResultNum);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbSearchNum);
            this.groupBox2.Controls.Add(this.btTimNum);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(516, 368);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 251);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm Sinh Viên Theo MSSV";
            // 
            // lbResultNum
            // 
            this.lbResultNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbResultNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbResultNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbResultNum.Location = new System.Drawing.Point(159, 161);
            this.lbResultNum.Name = "lbResultNum";
            this.lbResultNum.Size = new System.Drawing.Size(327, 43);
            this.lbResultNum.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(0, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 32);
            this.label8.TabIndex = 12;
            this.label8.Text = "Kết quả:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 32);
            this.label9.TabIndex = 12;
            this.label9.Text = "Nhập MSSV:";
            // 
            // tbSearchNum
            // 
            this.tbSearchNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearchNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSearchNum.Location = new System.Drawing.Point(159, 69);
            this.tbSearchNum.Name = "tbSearchNum";
            this.tbSearchNum.Size = new System.Drawing.Size(228, 39);
            this.tbSearchNum.TabIndex = 13;
            // 
            // btTimNum
            // 
            this.btTimNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTimNum.Location = new System.Drawing.Point(393, 69);
            this.btTimNum.Name = "btTimNum";
            this.btTimNum.Size = new System.Drawing.Size(93, 41);
            this.btTimNum.TabIndex = 14;
            this.btTimNum.Text = "Tìm";
            this.btTimNum.UseVisualStyleBackColor = true;
            this.btTimNum.Click += new System.EventHandler(this.btTimNum_Click);
            // 
            // btSort
            // 
            this.btSort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSort.Location = new System.Drawing.Point(281, 300);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(148, 41);
            this.btSort.TabIndex = 14;
            this.btSort.Text = "Sắp xếp";
            this.btSort.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 631);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lsSv);
            this.Controls.Add(this.btSort);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.tbMaso);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsSv;
        private System.Windows.Forms.ColumnHeader hoTen;
        private System.Windows.Forms.ColumnHeader Maso;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbResultName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.Button btTimName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbResultNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSearchNum;
        private System.Windows.Forms.Button btTimNum;
        private System.Windows.Forms.Button btSort;
    }
}