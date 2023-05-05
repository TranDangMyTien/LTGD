
namespace BTH7
{
    partial class FrmOption
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btTrian = new System.Windows.Forms.RadioButton();
            this.btEllipse = new System.Windows.Forms.RadioButton();
            this.btRect = new System.Windows.Forms.RadioButton();
            this.btColor = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btTrian);
            this.groupBox1.Controls.Add(this.btEllipse);
            this.groupBox1.Controls.Add(this.btRect);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(53, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // btTrian
            // 
            this.btTrian.AutoSize = true;
            this.btTrian.Location = new System.Drawing.Point(42, 174);
            this.btTrian.Name = "btTrian";
            this.btTrian.Size = new System.Drawing.Size(146, 45);
            this.btTrian.TabIndex = 0;
            this.btTrian.Text = "Triangle";
            this.btTrian.UseVisualStyleBackColor = true;
            // 
            // btEllipse
            // 
            this.btEllipse.AutoSize = true;
            this.btEllipse.Location = new System.Drawing.Point(42, 110);
            this.btEllipse.Name = "btEllipse";
            this.btEllipse.Size = new System.Drawing.Size(126, 45);
            this.btEllipse.TabIndex = 0;
            this.btEllipse.Text = "Ellipse";
            this.btEllipse.UseVisualStyleBackColor = true;
            // 
            // btRect
            // 
            this.btRect.AutoSize = true;
            this.btRect.Checked = true;
            this.btRect.Location = new System.Drawing.Point(42, 46);
            this.btRect.Name = "btRect";
            this.btRect.Size = new System.Drawing.Size(173, 45);
            this.btRect.TabIndex = 0;
            this.btRect.TabStop = true;
            this.btRect.Text = "Rectangle";
            this.btRect.UseVisualStyleBackColor = true;
            // 
            // btColor
            // 
            this.btColor.BackColor = System.Drawing.Color.Red;
            this.btColor.Location = new System.Drawing.Point(53, 289);
            this.btColor.Name = "btColor";
            this.btColor.Size = new System.Drawing.Size(342, 42);
            this.btColor.TabIndex = 1;
            this.btColor.UseVisualStyleBackColor = false;
            this.btColor.Click += new System.EventHandler(this.btColor_Click);
            // 
            // btOk
            // 
            this.btOk.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btOk.Location = new System.Drawing.Point(53, 347);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(124, 51);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCancel.Location = new System.Drawing.Point(269, 347);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(126, 51);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // FrmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 410);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btColor);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOption";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btTrian;
        private System.Windows.Forms.RadioButton btEllipse;
        private System.Windows.Forms.RadioButton btRect;
        private System.Windows.Forms.Button btColor;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
    }
}