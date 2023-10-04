namespace Bài_tập_Groupbox__Checkbox__RadioButton
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
            this.components = new System.ComponentModel.Container();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grbMauChu = new System.Windows.Forms.GroupBox();
            this.grbDinhDang = new System.Windows.Forms.GroupBox();
            this.btnApDung = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.radDo = new System.Windows.Forms.RadioButton();
            this.radDen = new System.Windows.Forms.RadioButton();
            this.radXanh = new System.Windows.Forms.RadioButton();
            this.radVang = new System.Windows.Forms.RadioButton();
            this.chkDam = new System.Windows.Forms.CheckBox();
            this.chkNghieng = new System.Windows.Forms.CheckBox();
            this.chkBinhThuong = new System.Windows.Forms.CheckBox();
            this.chkGachChan = new System.Windows.Forms.CheckBox();
            this.lblA = new System.Windows.Forms.Label();
            this.grbMauChu.SuspendLayout();
            this.grbDinhDang.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(528, 20);
            this.txtInput.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // grbMauChu
            // 
            this.grbMauChu.Controls.Add(this.radDen);
            this.grbMauChu.Controls.Add(this.radXanh);
            this.grbMauChu.Controls.Add(this.radVang);
            this.grbMauChu.Controls.Add(this.radDo);
            this.grbMauChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMauChu.Location = new System.Drawing.Point(12, 60);
            this.grbMauChu.Name = "grbMauChu";
            this.grbMauChu.Size = new System.Drawing.Size(243, 144);
            this.grbMauChu.TabIndex = 2;
            this.grbMauChu.TabStop = false;
            this.grbMauChu.Text = "Màu chữ";
            // 
            // grbDinhDang
            // 
            this.grbDinhDang.Controls.Add(this.chkGachChan);
            this.grbDinhDang.Controls.Add(this.chkBinhThuong);
            this.grbDinhDang.Controls.Add(this.chkNghieng);
            this.grbDinhDang.Controls.Add(this.chkDam);
            this.grbDinhDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDinhDang.Location = new System.Drawing.Point(297, 60);
            this.grbDinhDang.Name = "grbDinhDang";
            this.grbDinhDang.Size = new System.Drawing.Size(243, 144);
            this.grbDinhDang.TabIndex = 4;
            this.grbDinhDang.TabStop = false;
            this.grbDinhDang.Text = "Định dạng";
            // 
            // btnApDung
            // 
            this.btnApDung.Location = new System.Drawing.Point(182, 215);
            this.btnApDung.Name = "btnApDung";
            this.btnApDung.Size = new System.Drawing.Size(73, 24);
            this.btnApDung.TabIndex = 5;
            this.btnApDung.Text = "Áp dụng";
            this.btnApDung.UseVisualStyleBackColor = true;
            this.btnApDung.Click += new System.EventHandler(this.btnApDung_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(297, 215);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(73, 24);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // radDo
            // 
            this.radDo.AutoSize = true;
            this.radDo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radDo.Location = new System.Drawing.Point(33, 19);
            this.radDo.Name = "radDo";
            this.radDo.Size = new System.Drawing.Size(41, 17);
            this.radDo.TabIndex = 0;
            this.radDo.TabStop = true;
            this.radDo.Text = "Đỏ";
            this.radDo.UseVisualStyleBackColor = true;
            // 
            // radDen
            // 
            this.radDen.AutoSize = true;
            this.radDen.Location = new System.Drawing.Point(33, 88);
            this.radDen.Name = "radDen";
            this.radDen.Size = new System.Drawing.Size(48, 17);
            this.radDen.TabIndex = 3;
            this.radDen.TabStop = true;
            this.radDen.Text = "Đen";
            this.radDen.UseVisualStyleBackColor = true;
            // 
            // radXanh
            // 
            this.radXanh.AutoSize = true;
            this.radXanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radXanh.Location = new System.Drawing.Point(33, 65);
            this.radXanh.Name = "radXanh";
            this.radXanh.Size = new System.Drawing.Size(54, 17);
            this.radXanh.TabIndex = 2;
            this.radXanh.TabStop = true;
            this.radXanh.Text = "Xanh";
            this.radXanh.UseVisualStyleBackColor = true;
            // 
            // radVang
            // 
            this.radVang.AutoSize = true;
            this.radVang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radVang.Location = new System.Drawing.Point(33, 42);
            this.radVang.Name = "radVang";
            this.radVang.Size = new System.Drawing.Size(54, 17);
            this.radVang.TabIndex = 1;
            this.radVang.TabStop = true;
            this.radVang.Text = "Vàng";
            this.radVang.UseVisualStyleBackColor = true;
            // 
            // chkDam
            // 
            this.chkDam.AutoSize = true;
            this.chkDam.Location = new System.Drawing.Point(33, 19);
            this.chkDam.Name = "chkDam";
            this.chkDam.Size = new System.Drawing.Size(51, 17);
            this.chkDam.TabIndex = 3;
            this.chkDam.Text = "Đậm";
            this.chkDam.UseVisualStyleBackColor = true;
            // 
            // chkNghieng
            // 
            this.chkNghieng.AutoSize = true;
            this.chkNghieng.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNghieng.Location = new System.Drawing.Point(33, 42);
            this.chkNghieng.Name = "chkNghieng";
            this.chkNghieng.Size = new System.Drawing.Size(66, 17);
            this.chkNghieng.TabIndex = 4;
            this.chkNghieng.Text = "Nghiêng";
            this.chkNghieng.UseVisualStyleBackColor = true;
            // 
            // chkBinhThuong
            // 
            this.chkBinhThuong.AutoSize = true;
            this.chkBinhThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBinhThuong.Location = new System.Drawing.Point(33, 88);
            this.chkBinhThuong.Name = "chkBinhThuong";
            this.chkBinhThuong.Size = new System.Drawing.Size(83, 17);
            this.chkBinhThuong.TabIndex = 5;
            this.chkBinhThuong.Text = "Bình thường";
            this.chkBinhThuong.UseVisualStyleBackColor = true;
            // 
            // chkGachChan
            // 
            this.chkGachChan.AutoSize = true;
            this.chkGachChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGachChan.Location = new System.Drawing.Point(33, 65);
            this.chkGachChan.Name = "chkGachChan";
            this.chkGachChan.Size = new System.Drawing.Size(79, 17);
            this.chkGachChan.TabIndex = 6;
            this.chkGachChan.Text = "Gạch chân";
            this.chkGachChan.UseVisualStyleBackColor = true;
            // 
            // lblA
            // 
            this.lblA.Location = new System.Drawing.Point(12, 34);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(528, 23);
            this.lblA.TabIndex = 7;
            this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 251);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnApDung);
            this.Controls.Add(this.grbDinhDang);
            this.Controls.Add(this.grbMauChu);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbMauChu.ResumeLayout(false);
            this.grbMauChu.PerformLayout();
            this.grbDinhDang.ResumeLayout(false);
            this.grbDinhDang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox grbMauChu;
        private System.Windows.Forms.GroupBox grbDinhDang;
        private System.Windows.Forms.Button btnApDung;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.RadioButton radDen;
        private System.Windows.Forms.RadioButton radXanh;
        private System.Windows.Forms.RadioButton radVang;
        private System.Windows.Forms.RadioButton radDo;
        private System.Windows.Forms.CheckBox chkBinhThuong;
        private System.Windows.Forms.CheckBox chkNghieng;
        private System.Windows.Forms.CheckBox chkDam;
        private System.Windows.Forms.CheckBox chkGachChan;
        private System.Windows.Forms.Label lblA;
    }
}

