
namespace Editor
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
            this.label2 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.lbColor1 = new System.Windows.Forms.Label();
            this.lbColor2 = new System.Windows.Forms.Label();
            this.lbColor3 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
            this.lbColor = new System.Windows.Forms.Label();
            this.rdB = new System.Windows.Forms.RadioButton();
            this.rdI = new System.Windows.Forms.RadioButton();
            this.rdU = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font List:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Content:";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 25;
            this.listBox.Location = new System.Drawing.Point(39, 58);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(275, 479);
            this.listBox.TabIndex = 1;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(353, 58);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(420, 487);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 589);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Size:";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(84, 586);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(101, 33);
            this.comboBox.TabIndex = 3;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // lbColor1
            // 
            this.lbColor1.BackColor = System.Drawing.Color.Red;
            this.lbColor1.Location = new System.Drawing.Point(406, 567);
            this.lbColor1.Name = "lbColor1";
            this.lbColor1.Size = new System.Drawing.Size(38, 22);
            this.lbColor1.TabIndex = 0;
            // 
            // lbColor2
            // 
            this.lbColor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbColor2.Location = new System.Drawing.Point(406, 598);
            this.lbColor2.Name = "lbColor2";
            this.lbColor2.Size = new System.Drawing.Size(38, 22);
            this.lbColor2.TabIndex = 0;
            // 
            // lbColor3
            // 
            this.lbColor3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbColor3.Location = new System.Drawing.Point(406, 631);
            this.lbColor3.Name = "lbColor3";
            this.lbColor3.Size = new System.Drawing.Size(38, 22);
            this.lbColor3.TabIndex = 0;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(466, 567);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(203, 22);
            this.hScrollBar1.TabIndex = 5;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Location = new System.Drawing.Point(466, 598);
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(203, 22);
            this.hScrollBar2.TabIndex = 5;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // hScrollBar3
            // 
            this.hScrollBar3.Location = new System.Drawing.Point(466, 631);
            this.hScrollBar3.Name = "hScrollBar3";
            this.hScrollBar3.Size = new System.Drawing.Size(203, 22);
            this.hScrollBar3.TabIndex = 5;
            this.hScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar3_Scroll);
            // 
            // lbColor
            // 
            this.lbColor.BackColor = System.Drawing.Color.Gainsboro;
            this.lbColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbColor.ForeColor = System.Drawing.SystemColors.Control;
            this.lbColor.Location = new System.Drawing.Point(688, 567);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(85, 84);
            this.lbColor.TabIndex = 0;
            // 
            // rdB
            // 
            this.rdB.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdB.Location = new System.Drawing.Point(217, 589);
            this.rdB.Name = "rdB";
            this.rdB.Size = new System.Drawing.Size(48, 34);
            this.rdB.TabIndex = 6;
            this.rdB.TabStop = true;
            this.rdB.Text = "B";
            this.rdB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdB.UseVisualStyleBackColor = true;
            this.rdB.CheckedChanged += new System.EventHandler(this.rdB_CheckedChanged);
            this.rdB.Click += new System.EventHandler(this.rdB_Click);
            // 
            // rdI
            // 
            this.rdI.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdI.Location = new System.Drawing.Point(271, 589);
            this.rdI.Name = "rdI";
            this.rdI.Size = new System.Drawing.Size(48, 34);
            this.rdI.TabIndex = 6;
            this.rdI.TabStop = true;
            this.rdI.Text = "I";
            this.rdI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdI.UseVisualStyleBackColor = true;
            this.rdI.CheckedChanged += new System.EventHandler(this.rdI_CheckedChanged);
            this.rdI.Click += new System.EventHandler(this.rdI_Click);
            // 
            // rdU
            // 
            this.rdU.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdU.Location = new System.Drawing.Point(325, 589);
            this.rdU.Name = "rdU";
            this.rdU.Size = new System.Drawing.Size(48, 34);
            this.rdU.TabIndex = 6;
            this.rdU.TabStop = true;
            this.rdU.Text = "U";
            this.rdU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdU.UseVisualStyleBackColor = true;
            this.rdU.CheckedChanged += new System.EventHandler(this.rdU_CheckedChanged);
            this.rdU.Click += new System.EventHandler(this.rdU_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 679);
            this.Controls.Add(this.rdU);
            this.Controls.Add(this.rdI);
            this.Controls.Add(this.rdB);
            this.Controls.Add(this.hScrollBar3);
            this.Controls.Add(this.hScrollBar2);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbColor3);
            this.Controls.Add(this.lbColor2);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.lbColor1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label lbColor1;
        private System.Windows.Forms.Label lbColor2;
        private System.Windows.Forms.Label lbColor3;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.HScrollBar hScrollBar3;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.RadioButton rdB;
        private System.Windows.Forms.RadioButton rdI;
        private System.Windows.Forms.RadioButton rdU;
    }
}

