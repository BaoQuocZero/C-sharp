namespace QLNV_GianTiep
{
    partial class FrmTimKiemNV
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
            this.txtTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTenPB = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnNhanVien);
            this.flowLayoutPanel2.Controls.Add(this.txtTimKiem);
            this.flowLayoutPanel2.Controls.Add(this.btnThoat);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.dgvNhanVien);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(13, 112);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(738, 303);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(3, 3);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(75, 36);
            this.btnNhanVien.TabIndex = 6;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.s_Click);
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
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(165, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 36);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tìm Thấy: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 68);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(735, 244);
            this.dgvNhanVien.TabIndex = 4;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblMaNV);
            this.flowLayoutPanel1.Controls.Add(this.txtMaNV);
            this.flowLayoutPanel1.Controls.Add(this.lblTenNV);
            this.flowLayoutPanel1.Controls.Add(this.txtTenNV);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.cboTenPB);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 11);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(738, 95);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // lblMaNV
            // 
            this.lblMaNV.Location = new System.Drawing.Point(3, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(100, 23);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã NV";
            this.lblMaNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(109, 3);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(255, 20);
            this.txtMaNV.TabIndex = 1;
            // 
            // lblTenNV
            // 
            this.lblTenNV.Location = new System.Drawing.Point(370, 0);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(100, 23);
            this.lblTenNV.TabIndex = 2;
            this.lblTenNV.Text = "Tên NV";
            this.lblTenNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(476, 3);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(255, 20);
            this.txtTenNV.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 26);
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
            this.cboTenPB.Location = new System.Drawing.Point(109, 29);
            this.cboTenPB.Name = "cboTenPB";
            this.cboTenPB.Size = new System.Drawing.Size(255, 21);
            this.cboTenPB.TabIndex = 6;
            this.cboTenPB.SelectedIndexChanged += new System.EventHandler(this.cboTenPB_SelectedIndexChanged);
            // 
            // FrmTimKiemNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 427);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FrmTimKiemNV";
            this.Text = "FrmTimKiemNV";
            this.Load += new System.EventHandler(this.FrmTimKiemNV_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button txtTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTenPB;
        private System.Windows.Forms.Label label1;
    }
}