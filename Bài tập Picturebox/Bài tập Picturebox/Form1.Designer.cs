namespace Bài_tập_Picturebox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picHaTa = new System.Windows.Forms.PictureBox();
            this.picNangTa = new System.Windows.Forms.PictureBox();
            this.txtIntPut = new System.Windows.Forms.TextBox();
            this.lblNhapTen = new System.Windows.Forms.Label();
            this.chkNhac = new System.Windows.Forms.CheckBox();
            this.btnTap = new System.Windows.Forms.Button();
            this.lblSoLanTap = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.picGigaChar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHaTa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNangTa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGigaChar)).BeginInit();
            this.SuspendLayout();
            // 
            // picHaTa
            // 
            this.picHaTa.Image = ((System.Drawing.Image)(resources.GetObject("picHaTa.Image")));
            this.picHaTa.Location = new System.Drawing.Point(66, 102);
            this.picHaTa.Name = "picHaTa";
            this.picHaTa.Size = new System.Drawing.Size(325, 214);
            this.picHaTa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHaTa.TabIndex = 0;
            this.picHaTa.TabStop = false;
            // 
            // picNangTa
            // 
            this.picNangTa.Image = ((System.Drawing.Image)(resources.GetObject("picNangTa.Image")));
            this.picNangTa.Location = new System.Drawing.Point(66, 102);
            this.picNangTa.Name = "picNangTa";
            this.picNangTa.Size = new System.Drawing.Size(325, 214);
            this.picNangTa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNangTa.TabIndex = 1;
            this.picNangTa.TabStop = false;
            // 
            // txtIntPut
            // 
            this.txtIntPut.Location = new System.Drawing.Point(66, 76);
            this.txtIntPut.Name = "txtIntPut";
            this.txtIntPut.Size = new System.Drawing.Size(325, 20);
            this.txtIntPut.TabIndex = 2;
            this.txtIntPut.TextChanged += new System.EventHandler(this.txtIntPut_TextChanged);
            // 
            // lblNhapTen
            // 
            this.lblNhapTen.Location = new System.Drawing.Point(66, 51);
            this.lblNhapTen.Name = "lblNhapTen";
            this.lblNhapTen.Size = new System.Drawing.Size(100, 19);
            this.lblNhapTen.TabIndex = 3;
            this.lblNhapTen.Text = "Nhập tên";
            this.lblNhapTen.Click += new System.EventHandler(this.label1_Click);
            // 
            // chkNhac
            // 
            this.chkNhac.AutoSize = true;
            this.chkNhac.Location = new System.Drawing.Point(311, 53);
            this.chkNhac.Name = "chkNhac";
            this.chkNhac.Size = new System.Drawing.Size(52, 17);
            this.chkNhac.TabIndex = 4;
            this.chkNhac.Text = "Nhạc";
            this.chkNhac.UseVisualStyleBackColor = true;
            this.chkNhac.CheckedChanged += new System.EventHandler(this.chkNhac_CheckedChanged);
            // 
            // btnTap
            // 
            this.btnTap.Location = new System.Drawing.Point(316, 375);
            this.btnTap.Name = "btnTap";
            this.btnTap.Size = new System.Drawing.Size(75, 23);
            this.btnTap.TabIndex = 6;
            this.btnTap.Text = "Tập";
            this.btnTap.UseVisualStyleBackColor = true;
            this.btnTap.Click += new System.EventHandler(this.btnTap_Click);
            // 
            // lblSoLanTap
            // 
            this.lblSoLanTap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblSoLanTap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLanTap.Location = new System.Drawing.Point(66, 370);
            this.lblSoLanTap.Name = "lblSoLanTap";
            this.lblSoLanTap.Size = new System.Drawing.Size(244, 28);
            this.lblSoLanTap.TabIndex = 7;
            this.lblSoLanTap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSoLanTap.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(66, 324);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(325, 43);
            this.btnClick.TabIndex = 8;
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // picGigaChar
            // 
            this.picGigaChar.Image = ((System.Drawing.Image)(resources.GetObject("picGigaChar.Image")));
            this.picGigaChar.Location = new System.Drawing.Point(66, 102);
            this.picGigaChar.Name = "picGigaChar";
            this.picGigaChar.Size = new System.Drawing.Size(325, 214);
            this.picGigaChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGigaChar.TabIndex = 9;
            this.picGigaChar.TabStop = false;
            this.picGigaChar.Click += new System.EventHandler(this.pĩcGigaChar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 450);
            this.Controls.Add(this.picGigaChar);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lblSoLanTap);
            this.Controls.Add(this.btnTap);
            this.Controls.Add(this.chkNhac);
            this.Controls.Add(this.lblNhapTen);
            this.Controls.Add(this.txtIntPut);
            this.Controls.Add(this.picNangTa);
            this.Controls.Add(this.picHaTa);
            this.Name = "Form1";
            this.Text = "Tập tạ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHaTa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNangTa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGigaChar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHaTa;
        private System.Windows.Forms.PictureBox picNangTa;
        private System.Windows.Forms.TextBox txtIntPut;
        private System.Windows.Forms.Label lblNhapTen;
        private System.Windows.Forms.CheckBox chkNhac;
        private System.Windows.Forms.Button btnTap;
        private System.Windows.Forms.Label lblSoLanTap;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.PictureBox picGigaChar;
    }
}

