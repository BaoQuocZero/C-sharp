namespace QuanLyNhanKhauHoKhau
{
    partial class FormHoKhau
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMa = new System.Windows.Forms.Label();
            this.txtMaDD = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblSoSo = new System.Windows.Forms.Label();
            this.txtSoSo = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.timeNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblMa);
            this.flowLayoutPanel1.Controls.Add(this.txtMaDD);
            this.flowLayoutPanel1.Controls.Add(this.lblHoTen);
            this.flowLayoutPanel1.Controls.Add(this.txtHoTen);
            this.flowLayoutPanel1.Controls.Add(this.lblGioiTinh);
            this.flowLayoutPanel1.Controls.Add(this.cboGioiTinh);
            this.flowLayoutPanel1.Controls.Add(this.lblNgaySinh);
            this.flowLayoutPanel1.Controls.Add(this.timeNgaySinh);
            this.flowLayoutPanel1.Controls.Add(this.lblSoSo);
            this.flowLayoutPanel1.Controls.Add(this.txtSoSo);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(636, 142);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // lblMa
            // 
            this.lblMa.Location = new System.Drawing.Point(3, 0);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(93, 52);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã ĐD";
            this.lblMa.Click += new System.EventHandler(this.lblMa_Click);
            // 
            // txtMaDD
            // 
            this.txtMaDD.Location = new System.Drawing.Point(102, 3);
            this.txtMaDD.Name = "txtMaDD";
            this.txtMaDD.Size = new System.Drawing.Size(165, 20);
            this.txtMaDD.TabIndex = 1;
            this.txtMaDD.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblHoTen
            // 
            this.lblHoTen.Location = new System.Drawing.Point(273, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(93, 52);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(372, 3);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(165, 20);
            this.txtHoTen.TabIndex = 3;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Location = new System.Drawing.Point(3, 52);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(93, 52);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Location = new System.Drawing.Point(273, 52);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(93, 52);
            this.lblNgaySinh.TabIndex = 6;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblSoSo
            // 
            this.lblSoSo.Location = new System.Drawing.Point(3, 104);
            this.lblSoSo.Name = "lblSoSo";
            this.lblSoSo.Size = new System.Drawing.Size(93, 52);
            this.lblSoSo.TabIndex = 8;
            this.lblSoSo.Text = "Số sổ";
            // 
            // txtSoSo
            // 
            this.txtSoSo.Location = new System.Drawing.Point(102, 107);
            this.txtSoSo.Name = "txtSoSo";
            this.txtSoSo.Size = new System.Drawing.Size(165, 20);
            this.txtSoSo.TabIndex = 9;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(13, 161);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(636, 232);
            this.dgv.TabIndex = 1;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // timeNgaySinh
            // 
            this.timeNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeNgaySinh.Location = new System.Drawing.Point(372, 55);
            this.timeNgaySinh.Name = "timeNgaySinh";
            this.timeNgaySinh.Size = new System.Drawing.Size(165, 20);
            this.timeNgaySinh.TabIndex = 10;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cboGioiTinh.Location = new System.Drawing.Point(102, 55);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(165, 21);
            this.cboGioiTinh.TabIndex = 11;
            // 
            // FormHoKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 501);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormHoKhau";
            this.Text = "Hộ khẩu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMaDD;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblSoSo;
        private System.Windows.Forms.TextBox txtSoSo;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DateTimePicker timeNgaySinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
    }
}