namespace LapTrinhGiaoDien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.bntQuaySo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDiem = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb1.Location = new System.Drawing.Point(85, 41);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(152, 165);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "0";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb2.Location = new System.Drawing.Point(289, 41);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(152, 165);
            this.lb2.TabIndex = 0;
            this.lb2.Text = "0";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb3.Location = new System.Drawing.Point(493, 41);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(152, 165);
            this.lb3.TabIndex = 0;
            this.lb3.Text = "0";
            this.lb3.Click += new System.EventHandler(this.lb3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rd3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(85, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 142);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn: ";
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioButton1.Location = new System.Drawing.Point(361, 57);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(108, 47);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "11-18";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.rd3_CheckedChanged);
            // 
            // rd3
            // 
            this.rd3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rd3.AutoSize = true;
            this.rd3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rd3.Location = new System.Drawing.Point(131, 57);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(93, 47);
            this.rd3.TabIndex = 0;
            this.rd3.TabStop = true;
            this.rd3.Text = "3-10";
            this.rd3.UseVisualStyleBackColor = false;
            this.rd3.CheckedChanged += new System.EventHandler(this.rd3_CheckedChanged);
            // 
            // bntQuaySo
            // 
            this.bntQuaySo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bntQuaySo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntQuaySo.ForeColor = System.Drawing.Color.Blue;
            this.bntQuaySo.Location = new System.Drawing.Point(85, 397);
            this.bntQuaySo.Name = "bntQuaySo";
            this.bntQuaySo.Size = new System.Drawing.Size(150, 51);
            this.bntQuaySo.TabIndex = 2;
            this.bntQuaySo.Text = "Quay số";
            this.bntQuaySo.UseVisualStyleBackColor = false;
            this.bntQuaySo.Click += new System.EventHandler(this.bntQuaySo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(324, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "ĐIỂM:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDiem.ForeColor = System.Drawing.Color.Red;
            this.lbDiem.Location = new System.Drawing.Point(515, 373);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(78, 84);
            this.lbDiem.TabIndex = 4;
            this.lbDiem.Text = "0";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 512);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntQuaySo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Random Number ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb1;
        private Label lb2;
        private Label lb3;
        private GroupBox groupBox1;
        private RadioButton rd3;
        private RadioButton radioButton1;
        private Button bntQuaySo;
        private Label label1;
        private Label lbDiem;
    }
}