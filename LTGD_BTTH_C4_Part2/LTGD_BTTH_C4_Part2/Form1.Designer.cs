namespace LTGD_BTTH_C4_Part2
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
            this.lbname = new System.Windows.Forms.Label();
            this.lbKQ = new System.Windows.Forms.Label();
            this.bntQS = new System.Windows.Forms.Button();
            this.bntDong = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbname
            // 
            this.lbname.BackColor = System.Drawing.Color.Blue;
            this.lbname.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbname.Location = new System.Drawing.Point(0, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(947, 88);
            this.lbname.TabIndex = 0;
            this.lbname.Text = "2151050455_Trần Đặng Mỹ Tiên ";
            this.lbname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbname.Click += new System.EventHandler(this.lbname_Click);
            // 
            // lbKQ
            // 
            this.lbKQ.BackColor = System.Drawing.Color.Blue;
            this.lbKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbKQ.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbKQ.Location = new System.Drawing.Point(380, 419);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(190, 84);
            this.lbKQ.TabIndex = 1;
            this.lbKQ.Text = "0";
            this.lbKQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bntQS
            // 
            this.bntQS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntQS.ForeColor = System.Drawing.Color.Blue;
            this.bntQS.Location = new System.Drawing.Point(140, 459);
            this.bntQS.Name = "bntQS";
            this.bntQS.Size = new System.Drawing.Size(166, 71);
            this.bntQS.TabIndex = 2;
            this.bntQS.Text = "Quay số ";
            this.bntQS.UseVisualStyleBackColor = true;
            this.bntQS.Click += new System.EventHandler(this.bntQS_Click);
            // 
            // bntDong
            // 
            this.bntDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntDong.ForeColor = System.Drawing.Color.Blue;
            this.bntDong.Location = new System.Drawing.Point(628, 459);
            this.bntDong.Name = "bntDong";
            this.bntDong.Size = new System.Drawing.Size(166, 71);
            this.bntDong.TabIndex = 2;
            this.bntDong.Text = "Đóng ";
            this.bntDong.UseVisualStyleBackColor = true;
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(51, 117);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(227, 260);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 3;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(366, 117);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(227, 260);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2.TabIndex = 3;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Location = new System.Drawing.Point(675, 117);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(227, 260);
            this.pic3.TabIndex = 3;
            this.pic3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 608);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.bntDong);
            this.Controls.Add(this.bntQS);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.lbname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Mini game ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbname;
        private Label lbKQ;
        private Button bntQS;
        private Button bntDong;
        private PictureBox pic1;
        private PictureBox pic2;
        private PictureBox pic3;
    }
}