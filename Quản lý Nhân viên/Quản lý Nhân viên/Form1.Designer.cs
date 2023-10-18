namespace Quản_lý_Nhân_viên
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pnChinh = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblNamSinh = new System.Windows.Forms.Label();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.cboGoiTinh = new System.Windows.Forms.ComboBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.pnButton = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTimMa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnChinh.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(19, 182);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(761, 180);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(800, 48);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "THÔNG TIN NHÂN VIÊN";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnChinh
            // 
            this.pnChinh.Controls.Add(this.lblMaNV);
            this.pnChinh.Controls.Add(this.txtMaNV);
            this.pnChinh.Controls.Add(this.lblNamSinh);
            this.pnChinh.Controls.Add(this.txtNamSinh);
            this.pnChinh.Controls.Add(this.lblDiaChi);
            this.pnChinh.Controls.Add(this.txtDiaChi);
            this.pnChinh.Controls.Add(this.lblHoTen);
            this.pnChinh.Controls.Add(this.txtHoTen);
            this.pnChinh.Controls.Add(this.lblGioiTinh);
            this.pnChinh.Controls.Add(this.cboGoiTinh);
            this.pnChinh.Controls.Add(this.lblDienThoai);
            this.pnChinh.Controls.Add(this.txtDienThoai);
            this.pnChinh.Location = new System.Drawing.Point(19, 51);
            this.pnChinh.Name = "pnChinh";
            this.pnChinh.Size = new System.Drawing.Size(761, 116);
            this.pnChinh.TabIndex = 2;
            // 
            // lblMaNV
            // 
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(3, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(100, 64);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã NV";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(109, 3);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(140, 20);
            this.txtMaNV.TabIndex = 6;
            // 
            // lblNamSinh
            // 
            this.lblNamSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamSinh.Location = new System.Drawing.Point(255, 0);
            this.lblNamSinh.Name = "lblNamSinh";
            this.lblNamSinh.Size = new System.Drawing.Size(100, 64);
            this.lblNamSinh.TabIndex = 7;
            this.lblNamSinh.Text = "Năm sinh";
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Location = new System.Drawing.Point(361, 3);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(140, 20);
            this.txtNamSinh.TabIndex = 8;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(507, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(100, 64);
            this.lblDiaChi.TabIndex = 9;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(613, 3);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(140, 20);
            this.txtDiaChi.TabIndex = 10;
            // 
            // lblHoTen
            // 
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(3, 64);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(100, 64);
            this.lblHoTen.TabIndex = 11;
            this.lblHoTen.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(109, 67);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(140, 20);
            this.txtHoTen.TabIndex = 12;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(255, 64);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(100, 64);
            this.lblGioiTinh.TabIndex = 13;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // cboGoiTinh
            // 
            this.cboGoiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGoiTinh.FormattingEnabled = true;
            this.cboGoiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cboGoiTinh.Location = new System.Drawing.Point(361, 67);
            this.cboGoiTinh.Name = "cboGoiTinh";
            this.cboGoiTinh.Size = new System.Drawing.Size(140, 21);
            this.cboGoiTinh.TabIndex = 17;
            this.cboGoiTinh.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienThoai.Location = new System.Drawing.Point(507, 64);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(100, 64);
            this.lblDienThoai.TabIndex = 15;
            this.lblDienThoai.Text = "Điện thoại";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(613, 67);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(140, 20);
            this.txtDienThoai.TabIndex = 16;
            // 
            // pnButton
            // 
            this.pnButton.Controls.Add(this.btnTimMa);
            this.pnButton.Controls.Add(this.button1);
            this.pnButton.Controls.Add(this.button2);
            this.pnButton.Controls.Add(this.button3);
            this.pnButton.Controls.Add(this.button4);
            this.pnButton.Controls.Add(this.button5);
            this.pnButton.Controls.Add(this.button6);
            this.pnButton.Location = new System.Drawing.Point(19, 368);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(761, 62);
            this.pnButton.TabIndex = 3;
            // 
            // btnTimMa
            // 
            this.btnTimMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimMa.Location = new System.Drawing.Point(3, 3);
            this.btnTimMa.Name = "btnTimMa";
            this.btnTimMa.Size = new System.Drawing.Size(100, 37);
            this.btnTimMa.TabIndex = 0;
            this.btnTimMa.Text = "Tìm Mã";
            this.btnTimMa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimMa.UseVisualStyleBackColor = true;
            this.btnTimMa.Click += new System.EventHandler(this.btnTimMa_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(109, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tìm tên";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(215, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Đếm SL";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(321, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Thêm";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(427, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 37);
            this.button4.TabIndex = 4;
            this.button4.Text = "Xóa";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(533, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 37);
            this.button5.TabIndex = 5;
            this.button5.Text = "Sửa";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(639, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 37);
            this.button6.TabIndex = 6;
            this.button6.Text = "Thoát";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.pnButton);
            this.Controls.Add(this.pnChinh);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnChinh.ResumeLayout(false);
            this.pnChinh.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.FlowLayoutPanel pnChinh;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblNamSinh;
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.ComboBox cboGoiTinh;
        private System.Windows.Forms.FlowLayoutPanel pnButton;
        private System.Windows.Forms.Button btnTimMa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

