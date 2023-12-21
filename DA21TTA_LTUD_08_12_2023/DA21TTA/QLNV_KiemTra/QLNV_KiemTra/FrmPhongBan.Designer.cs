namespace QLNV_KiemTra
{
    partial class FrmPhongBan
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
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMaPB = new System.Windows.Forms.Label();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.lblTenPB = new System.Windows.Forms.Label();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnNhanVien);
            this.flowLayoutPanel2.Controls.Add(this.btnNhapLai);
            this.flowLayoutPanel2.Controls.Add(this.btnThem);
            this.flowLayoutPanel2.Controls.Add(this.btnSua);
            this.flowLayoutPanel2.Controls.Add(this.btnXoa);
            this.flowLayoutPanel2.Controls.Add(this.btnThoat);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(13, 58);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(555, 50);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(3, 3);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(75, 36);
            this.btnNhanVien.TabIndex = 4;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Location = new System.Drawing.Point(84, 3);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(75, 36);
            this.btnNhapLai.TabIndex = 5;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(165, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 36);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(246, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 36);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(327, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 36);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(408, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 36);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblMaPB);
            this.flowLayoutPanel1.Controls.Add(this.txtMaPB);
            this.flowLayoutPanel1.Controls.Add(this.lblTenPB);
            this.flowLayoutPanel1.Controls.Add(this.txtTenPB);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(555, 39);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // lblMaPB
            // 
            this.lblMaPB.Location = new System.Drawing.Point(3, 0);
            this.lblMaPB.Name = "lblMaPB";
            this.lblMaPB.Size = new System.Drawing.Size(100, 23);
            this.lblMaPB.TabIndex = 0;
            this.lblMaPB.Text = "Mã PB";
            this.lblMaPB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaPB
            // 
            this.txtMaPB.Location = new System.Drawing.Point(109, 3);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.ReadOnly = true;
            this.txtMaPB.Size = new System.Drawing.Size(54, 20);
            this.txtMaPB.TabIndex = 1;
            // 
            // lblTenPB
            // 
            this.lblTenPB.Location = new System.Drawing.Point(169, 0);
            this.lblTenPB.Name = "lblTenPB";
            this.lblTenPB.Size = new System.Drawing.Size(100, 23);
            this.lblTenPB.TabIndex = 2;
            this.lblTenPB.Text = "Tên PB";
            this.lblTenPB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenPB
            // 
            this.txtTenPB.Location = new System.Drawing.Point(275, 3);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(231, 20);
            this.txtTenPB.TabIndex = 3;
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.Location = new System.Drawing.Point(13, 114);
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.Size = new System.Drawing.Size(555, 244);
            this.dgvPhongBan.TabIndex = 6;
            this.dgvPhongBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongBan_CellClick);
            // 
            // FrmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 370);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dgvPhongBan);
            this.Name = "FrmPhongBan";
            this.Text = "FrmPhongBan";
            this.Load += new System.EventHandler(this.FrmPhongBan_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblMaPB;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.Label lblTenPB;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.DataGridView dgvPhongBan;
    }
}