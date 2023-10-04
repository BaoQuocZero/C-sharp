namespace Groupbox_Checkbox_RadioButton
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
            this.grbThick = new System.Windows.Forms.GroupBox();
            this.grbKoThich = new System.Windows.Forms.GroupBox();
            this.chkNhac = new System.Windows.Forms.CheckBox();
            this.chkGame = new System.Windows.Forms.CheckBox();
            this.chkPhim = new System.Windows.Forms.CheckBox();
            this.chkKoPhim = new System.Windows.Forms.CheckBox();
            this.chkKoGame = new System.Windows.Forms.CheckBox();
            this.chkKoNhac = new System.Windows.Forms.CheckBox();
            this.grbGioiTinh = new System.Windows.Forms.GroupBox();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.grbThick.SuspendLayout();
            this.grbKoThich.SuspendLayout();
            this.grbGioiTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbThick
            // 
            this.grbThick.Controls.Add(this.chkPhim);
            this.grbThick.Controls.Add(this.chkGame);
            this.grbThick.Controls.Add(this.chkNhac);
            this.grbThick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThick.Location = new System.Drawing.Point(12, 12);
            this.grbThick.Name = "grbThick";
            this.grbThick.Size = new System.Drawing.Size(150, 185);
            this.grbThick.TabIndex = 0;
            this.grbThick.TabStop = false;
            this.grbThick.Text = "Thích";
            // 
            // grbKoThich
            // 
            this.grbKoThich.Controls.Add(this.chkKoPhim);
            this.grbKoThich.Controls.Add(this.chkKoNhac);
            this.grbKoThich.Controls.Add(this.chkKoGame);
            this.grbKoThich.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbKoThich.Location = new System.Drawing.Point(168, 12);
            this.grbKoThich.Name = "grbKoThich";
            this.grbKoThich.Size = new System.Drawing.Size(150, 185);
            this.grbKoThich.TabIndex = 1;
            this.grbKoThich.TabStop = false;
            this.grbKoThich.Text = "Không thích";
            // 
            // chkNhac
            // 
            this.chkNhac.AutoSize = true;
            this.chkNhac.Location = new System.Drawing.Point(16, 37);
            this.chkNhac.Name = "chkNhac";
            this.chkNhac.Size = new System.Drawing.Size(88, 17);
            this.chkNhac.TabIndex = 0;
            this.chkNhac.Text = "Nghe nhạc";
            this.chkNhac.UseVisualStyleBackColor = true;
            this.chkNhac.CheckedChanged += new System.EventHandler(this.chkNhac_CheckedChanged);
            // 
            // chkGame
            // 
            this.chkGame.AutoSize = true;
            this.chkGame.Location = new System.Drawing.Point(16, 60);
            this.chkGame.Name = "chkGame";
            this.chkGame.Size = new System.Drawing.Size(58, 17);
            this.chkGame.TabIndex = 1;
            this.chkGame.Text = "Game";
            this.chkGame.UseVisualStyleBackColor = true;
            this.chkGame.CheckedChanged += new System.EventHandler(this.chkGame_CheckedChanged);
            // 
            // chkPhim
            // 
            this.chkPhim.AutoSize = true;
            this.chkPhim.Location = new System.Drawing.Point(16, 83);
            this.chkPhim.Name = "chkPhim";
            this.chkPhim.Size = new System.Drawing.Size(80, 17);
            this.chkPhim.TabIndex = 2;
            this.chkPhim.Text = "Xem phim";
            this.chkPhim.UseVisualStyleBackColor = true;
            this.chkPhim.CheckedChanged += new System.EventHandler(this.chkPhim_CheckedChanged);
            // 
            // chkKoPhim
            // 
            this.chkKoPhim.AutoSize = true;
            this.chkKoPhim.Location = new System.Drawing.Point(21, 83);
            this.chkKoPhim.Name = "chkKoPhim";
            this.chkKoPhim.Size = new System.Drawing.Size(80, 17);
            this.chkKoPhim.TabIndex = 5;
            this.chkKoPhim.Text = "Xem phim";
            this.chkKoPhim.UseVisualStyleBackColor = true;
            this.chkKoPhim.CheckedChanged += new System.EventHandler(this.chkKoPhim_CheckedChanged);
            // 
            // chkKoGame
            // 
            this.chkKoGame.AutoSize = true;
            this.chkKoGame.Location = new System.Drawing.Point(21, 60);
            this.chkKoGame.Name = "chkKoGame";
            this.chkKoGame.Size = new System.Drawing.Size(58, 17);
            this.chkKoGame.TabIndex = 4;
            this.chkKoGame.Text = "Game";
            this.chkKoGame.UseVisualStyleBackColor = true;
            this.chkKoGame.CheckedChanged += new System.EventHandler(this.chkKoGame_CheckedChanged);
            // 
            // chkKoNhac
            // 
            this.chkKoNhac.AutoSize = true;
            this.chkKoNhac.Location = new System.Drawing.Point(21, 37);
            this.chkKoNhac.Name = "chkKoNhac";
            this.chkKoNhac.Size = new System.Drawing.Size(88, 17);
            this.chkKoNhac.TabIndex = 3;
            this.chkKoNhac.Text = "Nghe nhạc";
            this.chkKoNhac.UseVisualStyleBackColor = true;
            this.chkKoNhac.CheckedChanged += new System.EventHandler(this.chkKoNhac_CheckedChanged);
            // 
            // grbGioiTinh
            // 
            this.grbGioiTinh.Controls.Add(this.radNu);
            this.grbGioiTinh.Controls.Add(this.radNam);
            this.grbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGioiTinh.Location = new System.Drawing.Point(324, 12);
            this.grbGioiTinh.Name = "grbGioiTinh";
            this.grbGioiTinh.Size = new System.Drawing.Size(150, 185);
            this.grbGioiTinh.TabIndex = 6;
            this.grbGioiTinh.TabStop = false;
            this.grbGioiTinh.Text = "Giới Tính";
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(18, 37);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(50, 17);
            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(18, 60);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(41, 17);
            this.radNu.TabIndex = 1;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 210);
            this.Controls.Add(this.grbGioiTinh);
            this.Controls.Add(this.grbKoThich);
            this.Controls.Add(this.grbThick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbThick.ResumeLayout(false);
            this.grbThick.PerformLayout();
            this.grbKoThich.ResumeLayout(false);
            this.grbKoThich.PerformLayout();
            this.grbGioiTinh.ResumeLayout(false);
            this.grbGioiTinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThick;
        private System.Windows.Forms.CheckBox chkPhim;
        private System.Windows.Forms.CheckBox chkGame;
        private System.Windows.Forms.CheckBox chkNhac;
        private System.Windows.Forms.GroupBox grbKoThich;
        private System.Windows.Forms.CheckBox chkKoPhim;
        private System.Windows.Forms.CheckBox chkKoNhac;
        private System.Windows.Forms.CheckBox chkKoGame;
        private System.Windows.Forms.GroupBox grbGioiTinh;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
    }
}

