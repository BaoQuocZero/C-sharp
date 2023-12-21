namespace QLNV_GianTiep
{
    partial class Frm
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
            this.txtTimKiem = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTenPB = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnPhongBan);
            this.flowLayoutPanel2.Controls.Add(this.txtTimKiem);
            this.flowLayoutPanel2.Controls.Add(this.btnNhapLai);
            this.flowLayoutPanel2.Controls.Add(this.btnThem);
            this.flowLayoutPanel2.Controls.Add(this.btnSua);
            this.flowLayoutPanel2.Controls.Add(this.btnXoa);
            this.flowLayoutPanel2.Controls.Add(this.btnThoat);
            this.flowLayoutPanel2.Controls.Add(this.dgvNhanVien);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 113);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(738, 303);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.Location = new System.Drawing.Point(3, 3);
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.Size = new System.Drawing.Size(75, 36);
            this.btnPhongBan.TabIndex = 6;
            this.btnPhongBan.Text = "Phòng ban";
            this.btnPhongBan.UseVisualStyleBackColor = true;
            this.btnPhongBan.Click += new System.EventHandler(this.btnPhongBan_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(84, 3);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(75, 36);
            this.txtTimKiem.TabIndex = 7;
            this.txtTimKiem.Text = "Tìm Kiếm Nhân Viên";
            this.txtTimKiem.UseVisualStyleBackColor = true;
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Location = new System.Drawing.Point(165, 3);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(75, 36);
            this.btnNhapLai.TabIndex = 5;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(246, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 36);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(327, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 36);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(489, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 36);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 45);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(735, 244);
            this.dgvNhanVien.TabIndex = 4;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblTenNV);
            this.flowLayoutPanel1.Controls.Add(this.txtTenNV);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.cboGioiTinh);
            this.flowLayoutPanel1.Controls.Add(this.lblMaNV);
            this.flowLayoutPanel1.Controls.Add(this.txtMaNV);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.dateTimePicker_NgaySinh);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.txtDiaChi);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.txtSdt);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.cboTenPB);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(738, 95);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // lblTenNV
            // 
            this.lblTenNV.Location = new System.Drawing.Point(3, 0);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(100, 23);
            this.lblTenNV.TabIndex = 2;
            this.lblTenNV.Text = "Tên NV";
            this.lblTenNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // cboGioiTinh
            // 
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cboGioiTinh.Location = new System.Drawing.Point(476, 3);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(140, 21);
            this.cboGioiTinh.TabIndex = 5;
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
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày sinh";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker_NgaySinh
            // 
            this.dateTimePicker_NgaySinh.Location = new System.Drawing.Point(109, 30);
            this.dateTimePicker_NgaySinh.Name = "dateTimePicker_NgaySinh";
            this.dateTimePicker_NgaySinh.Size = new System.Drawing.Size(255, 20);
            this.dateTimePicker_NgaySinh.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(370, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Địa chỉ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(476, 30);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(255, 20);
            this.txtDiaChi.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sđt";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(109, 56);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(255, 20);
            this.txtSdt.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(370, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mã PB";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboTenPB
            // 
            this.cboTenPB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenPB.FormattingEnabled = true;
            this.cboTenPB.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cboTenPB.Location = new System.Drawing.Point(476, 56);
            this.cboTenPB.Name = "cboTenPB";
            this.cboTenPB.Size = new System.Drawing.Size(255, 21);
            this.cboTenPB.TabIndex = 6;
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 427);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTenPB;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnPhongBan;
        private System.Windows.Forms.Button txtTimKiem;
    }
}

