﻿namespace QLNV_KiemTra
{
    partial class FrmNhanVien
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPhongBan = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMaPB = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnTimTen = new System.Windows.Forms.Button();
            this.btnTimPB = new System.Windows.Forms.Button();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnPhongBan);
            this.flowLayoutPanel2.Controls.Add(this.btnTimTen);
            this.flowLayoutPanel2.Controls.Add(this.btnTimPB);
            this.flowLayoutPanel2.Controls.Add(this.btnThongKe);
            this.flowLayoutPanel2.Controls.Add(this.btnThem);
            this.flowLayoutPanel2.Controls.Add(this.btnXoa);
            this.flowLayoutPanel2.Controls.Add(this.btnSua);
            this.flowLayoutPanel2.Controls.Add(this.btnThoat);
            this.flowLayoutPanel2.Controls.Add(this.lblTieuDe);
            this.flowLayoutPanel2.Controls.Add(this.dgv);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 86);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1160, 303);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.Location = new System.Drawing.Point(3, 3);
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.Size = new System.Drawing.Size(75, 36);
            this.btnPhongBan.TabIndex = 5;
            this.btnPhongBan.Text = "Phòng ban";
            this.btnPhongBan.UseVisualStyleBackColor = true;
            this.btnPhongBan.Click += new System.EventHandler(this.btnPhongBan_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(327, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 36);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(408, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 36);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(489, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 36);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(570, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 36);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(3, 73);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1160, 244);
            this.dgv.TabIndex = 4;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblTenNV);
            this.flowLayoutPanel1.Controls.Add(this.txtTenNV);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.txtGioiTinh);
            this.flowLayoutPanel1.Controls.Add(this.lblMaNV);
            this.flowLayoutPanel1.Controls.Add(this.txtMaNV);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.dateTimePicker_NgaySinh);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.txtDiaChi);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.txtSdt);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.cboMaPB);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1160, 68);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // lblTenNV
            // 
            this.lblTenNV.Location = new System.Drawing.Point(3, 0);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(100, 23);
            this.lblTenNV.TabIndex = 2;
            this.lblTenNV.Text = "Tên NV";
            this.lblTenNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(109, 3);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(255, 20);
            this.txtTenNV.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(370, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Giới tính";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGioiTinh.FormattingEnabled = true;
            this.txtGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.txtGioiTinh.Location = new System.Drawing.Point(476, 3);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(140, 21);
            this.txtGioiTinh.TabIndex = 5;
            // 
            // lblMaNV
            // 
            this.lblMaNV.Location = new System.Drawing.Point(622, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(49, 23);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã NV";
            this.lblMaNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(677, 3);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(54, 20);
            this.txtMaNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(737, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày sinh";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker_NgaySinh
            // 
            this.dateTimePicker_NgaySinh.Location = new System.Drawing.Point(843, 3);
            this.dateTimePicker_NgaySinh.Name = "dateTimePicker_NgaySinh";
            this.dateTimePicker_NgaySinh.Size = new System.Drawing.Size(255, 20);
            this.dateTimePicker_NgaySinh.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Địa chỉ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(109, 30);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(255, 20);
            this.txtDiaChi.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(370, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sđt";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(476, 30);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(255, 20);
            this.txtSdt.TabIndex = 11;
            this.txtSdt.TextChanged += new System.EventHandler(this.txtSdt_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(737, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Phòng ban";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboMaPB
            // 
            this.cboMaPB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaPB.FormattingEnabled = true;
            this.cboMaPB.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cboMaPB.Location = new System.Drawing.Point(843, 30);
            this.cboMaPB.Name = "cboMaPB";
            this.cboMaPB.Size = new System.Drawing.Size(255, 21);
            this.cboMaPB.TabIndex = 6;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(246, 3);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 36);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(3, 42);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(748, 28);
            this.lblTieuDe.TabIndex = 7;
            this.lblTieuDe.Text = "Nhân viên";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTieuDe.Click += new System.EventHandler(this.lblTieuDe_Click);
            // 
            // btnTimTen
            // 
            this.btnTimTen.Location = new System.Drawing.Point(84, 3);
            this.btnTimTen.Name = "btnTimTen";
            this.btnTimTen.Size = new System.Drawing.Size(75, 36);
            this.btnTimTen.TabIndex = 8;
            this.btnTimTen.Text = "Tìm tên";
            this.btnTimTen.UseVisualStyleBackColor = true;
            this.btnTimTen.Click += new System.EventHandler(this.btnTimTen_Click);
            // 
            // btnTimPB
            // 
            this.btnTimPB.Location = new System.Drawing.Point(165, 3);
            this.btnTimPB.Name = "btnTimPB";
            this.btnTimPB.Size = new System.Drawing.Size(75, 36);
            this.btnTimPB.TabIndex = 9;
            this.btnTimPB.Text = "Tìm phòng ban";
            this.btnTimPB.UseVisualStyleBackColor = true;
            this.btnTimPB.Click += new System.EventHandler(this.btnTimPB_Click);
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 444);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FrmNhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtGioiTinh;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMaPB;
        private System.Windows.Forms.Button btnPhongBan;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnTimTen;
        private System.Windows.Forms.Button btnTimPB;
    }
}