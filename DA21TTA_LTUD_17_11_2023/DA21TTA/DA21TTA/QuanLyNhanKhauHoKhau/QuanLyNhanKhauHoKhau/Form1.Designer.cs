namespace QuanLyNhanKhauHoKhau
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
            this.mnuTop = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLuuTru = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLuuTru_HoKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuTop
            // 
            this.mnuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.mnuLuuTru,
            this.traCứuToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.kếtXuấtToolStripMenuItem});
            this.mnuTop.Location = new System.Drawing.Point(0, 0);
            this.mnuTop.Name = "mnuTop";
            this.mnuTop.Size = new System.Drawing.Size(667, 24);
            this.mnuTop.TabIndex = 0;
            this.mnuTop.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "&Hệ thống";
            // 
            // mnuLuuTru
            // 
            this.mnuLuuTru.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLuuTru_HoKhau,
            this.nhânKhẩuToolStripMenuItem,
            this.danhMụcToolStripMenuItem});
            this.mnuLuuTru.Name = "mnuLuuTru";
            this.mnuLuuTru.Size = new System.Drawing.Size(57, 20);
            this.mnuLuuTru.Text = "&Lưu trữ";
            // 
            // traCứuToolStripMenuItem
            // 
            this.traCứuToolStripMenuItem.Name = "traCứuToolStripMenuItem";
            this.traCứuToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.traCứuToolStripMenuItem.Text = "&Tra cứu";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.thốngKêToolStripMenuItem.Text = "Thố&ng kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // kếtXuấtToolStripMenuItem
            // 
            this.kếtXuấtToolStripMenuItem.Name = "kếtXuấtToolStripMenuItem";
            this.kếtXuấtToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.kếtXuấtToolStripMenuItem.Text = "&Kết xuất";
            this.kếtXuấtToolStripMenuItem.Click += new System.EventHandler(this.kếtXuấtToolStripMenuItem_Click);
            // 
            // mnuLuuTru_HoKhau
            // 
            this.mnuLuuTru_HoKhau.Name = "mnuLuuTru_HoKhau";
            this.mnuLuuTru_HoKhau.Size = new System.Drawing.Size(152, 22);
            this.mnuLuuTru_HoKhau.Text = "Hộ khẩu";
            this.mnuLuuTru_HoKhau.Click += new System.EventHandler(this.hộKhẩuToolStripMenuItem_Click);
            // 
            // nhânKhẩuToolStripMenuItem
            // 
            this.nhânKhẩuToolStripMenuItem.Name = "nhânKhẩuToolStripMenuItem";
            this.nhânKhẩuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nhânKhẩuToolStripMenuItem.Text = "Nhân khẩu";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 487);
            this.Controls.Add(this.mnuTop);
            this.MainMenuStrip = this.mnuTop;
            this.Name = "Form1";
            this.Text = "Quản lý nhân khẩu hộ khẩu";
            this.mnuTop.ResumeLayout(false);
            this.mnuTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuTop;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLuuTru;
        private System.Windows.Forms.ToolStripMenuItem mnuLuuTru_HoKhau;
        private System.Windows.Forms.ToolStripMenuItem nhânKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtXuấtToolStripMenuItem;
    }
}

