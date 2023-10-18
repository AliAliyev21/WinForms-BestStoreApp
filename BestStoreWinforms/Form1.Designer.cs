namespace BestStoreWinforms
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.addNewProductBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.MaximumSize = new System.Drawing.Size(907, 100);
            this.panel1.MinimumSize = new System.Drawing.Size(907, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 100);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(459, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "h o m e";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "K o n t a k";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BestStoreWinforms.Properties.Resources.kontakimage_removebg_preview__3__removebg_preview_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(158, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.vScrollBar1);
            this.panel2.Controls.Add(this.addNewProductBtn);
            this.panel2.Location = new System.Drawing.Point(3, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 576);
            this.panel2.TabIndex = 1;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 5;
            this.vScrollBar1.Location = new System.Drawing.Point(876, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 565);
            this.vScrollBar1.TabIndex = 1;
            // 
            // addNewProductBtn
            // 
            this.addNewProductBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addNewProductBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addNewProductBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addNewProductBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addNewProductBtn.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewProductBtn.ForeColor = System.Drawing.Color.Navy;
            this.addNewProductBtn.Location = new System.Drawing.Point(10, 516);
            this.addNewProductBtn.Name = "addNewProductBtn";
            this.addNewProductBtn.Size = new System.Drawing.Size(317, 45);
            this.addNewProductBtn.TabIndex = 0;
            this.addNewProductBtn.Text = "Add New Product";
            this.addNewProductBtn.Click += new System.EventHandler(this.addNewProductBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(912, 686);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(930, 660);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button addNewProductBtn;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

