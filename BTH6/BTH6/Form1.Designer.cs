
namespace BTH6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Tv1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.layOut1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tv1
            // 
            this.Tv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tv1.ImageIndex = 0;
            this.Tv1.ImageList = this.imageList1;
            this.Tv1.Location = new System.Drawing.Point(12, 21);
            this.Tv1.Name = "Tv1";
            this.Tv1.SelectedImageIndex = 0;
            this.Tv1.Size = new System.Drawing.Size(364, 592);
            this.Tv1.TabIndex = 0;
            this.Tv1.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.Tv1_BeforeCollapse);
            this.Tv1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.Tv1_BeforeExpand);
            this.Tv1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Tv1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "folder expand.png");
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pic1.Location = new System.Drawing.Point(411, 21);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(617, 439);
            this.pic1.TabIndex = 1;
            this.pic1.TabStop = false;
            // 
            // layOut1
            // 
            this.layOut1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.layOut1.Location = new System.Drawing.Point(411, 484);
            this.layOut1.Name = "layOut1";
            this.layOut1.Size = new System.Drawing.Size(617, 132);
            this.layOut1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 625);
            this.Controls.Add(this.layOut1);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.Tv1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView Tv1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.FlowLayoutPanel layOut1;
    }
}

