namespace c4b1
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
            this.btnTrai2 = new System.Windows.Forms.Button();
            this.btnPhai2 = new System.Windows.Forms.Button();
            this.lbDaChon = new System.Windows.Forms.ListBox();
            this.lbDanhSach = new System.Windows.Forms.ListBox();
            this.btnTrai1 = new System.Windows.Forms.Button();
            this.btnPhai1 = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtThem = new System.Windows.Forms.TextBox();
            this.lblTieuDePhais = new System.Windows.Forms.Label();
            this.lblTieuDeTrai = new System.Windows.Forms.Label();
            this.lblThem = new System.Windows.Forms.Label();
            this.btnLen = new System.Windows.Forms.Button();
            this.btnXuong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTrai2
            // 
            this.btnTrai2.Location = new System.Drawing.Point(372, 244);
            this.btnTrai2.Name = "btnTrai2";
            this.btnTrai2.Size = new System.Drawing.Size(75, 23);
            this.btnTrai2.TabIndex = 27;
            this.btnTrai2.Text = "<<";
            this.btnTrai2.UseVisualStyleBackColor = true;
            this.btnTrai2.Click += new System.EventHandler(this.btnTrai2_Click);
            // 
            // btnPhai2
            // 
            this.btnPhai2.Location = new System.Drawing.Point(372, 186);
            this.btnPhai2.Name = "btnPhai2";
            this.btnPhai2.Size = new System.Drawing.Size(75, 23);
            this.btnPhai2.TabIndex = 26;
            this.btnPhai2.Text = ">>";
            this.btnPhai2.UseVisualStyleBackColor = true;
            this.btnPhai2.Click += new System.EventHandler(this.btnPhai2_Click);
            // 
            // lbDaChon
            // 
            this.lbDaChon.FormattingEnabled = true;
            this.lbDaChon.Location = new System.Drawing.Point(453, 131);
            this.lbDaChon.Name = "lbDaChon";
            this.lbDaChon.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDaChon.Size = new System.Drawing.Size(218, 238);
            this.lbDaChon.TabIndex = 25;
            // 
            // lbDanhSach
            // 
            this.lbDanhSach.FormattingEnabled = true;
            this.lbDanhSach.Location = new System.Drawing.Point(159, 131);
            this.lbDanhSach.MultiColumn = true;
            this.lbDanhSach.Name = "lbDanhSach";
            this.lbDanhSach.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDanhSach.Size = new System.Drawing.Size(207, 238);
            this.lbDanhSach.TabIndex = 24;
            // 
            // btnTrai1
            // 
            this.btnTrai1.Location = new System.Drawing.Point(372, 215);
            this.btnTrai1.Name = "btnTrai1";
            this.btnTrai1.Size = new System.Drawing.Size(75, 23);
            this.btnTrai1.TabIndex = 22;
            this.btnTrai1.Text = "<";
            this.btnTrai1.UseVisualStyleBackColor = true;
            this.btnTrai1.Click += new System.EventHandler(this.btnTrai1_Click);
            // 
            // btnPhai1
            // 
            this.btnPhai1.Location = new System.Drawing.Point(372, 157);
            this.btnPhai1.Name = "btnPhai1";
            this.btnPhai1.Size = new System.Drawing.Size(75, 23);
            this.btnPhai1.TabIndex = 20;
            this.btnPhai1.Text = ">";
            this.btnPhai1.UseVisualStyleBackColor = true;
            this.btnPhai1.Click += new System.EventHandler(this.btnPhai1_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(527, 48);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtThem
            // 
            this.txtThem.Location = new System.Drawing.Point(331, 50);
            this.txtThem.Name = "txtThem";
            this.txtThem.Size = new System.Drawing.Size(178, 20);
            this.txtThem.TabIndex = 18;
            // 
            // lblTieuDePhais
            // 
            this.lblTieuDePhais.AutoSize = true;
            this.lblTieuDePhais.Location = new System.Drawing.Point(450, 101);
            this.lblTieuDePhais.Name = "lblTieuDePhais";
            this.lblTieuDePhais.Size = new System.Drawing.Size(92, 13);
            this.lblTieuDePhais.TabIndex = 17;
            this.lblTieuDePhais.Text = "Các món đã chọn";
            // 
            // lblTieuDeTrai
            // 
            this.lblTieuDeTrai.AutoSize = true;
            this.lblTieuDeTrai.Location = new System.Drawing.Point(156, 101);
            this.lblTieuDeTrai.Name = "lblTieuDeTrai";
            this.lblTieuDeTrai.Size = new System.Drawing.Size(97, 13);
            this.lblTieuDeTrai.TabIndex = 16;
            this.lblTieuDeTrai.Text = "Danh sách món ăn";
            // 
            // lblThem
            // 
            this.lblThem.AutoSize = true;
            this.lblThem.Location = new System.Drawing.Point(229, 53);
            this.lblThem.Name = "lblThem";
            this.lblThem.Size = new System.Drawing.Size(75, 13);
            this.lblThem.TabIndex = 15;
            this.lblThem.Text = "Thêm món ăn:";
            // 
            // btnLen
            // 
            this.btnLen.Location = new System.Drawing.Point(677, 131);
            this.btnLen.Name = "btnLen";
            this.btnLen.Size = new System.Drawing.Size(75, 23);
            this.btnLen.TabIndex = 28;
            this.btnLen.Text = "Lên";
            this.btnLen.UseVisualStyleBackColor = true;
            this.btnLen.Click += new System.EventHandler(this.btnLen_Click);
            // 
            // btnXuong
            // 
            this.btnXuong.Location = new System.Drawing.Point(677, 160);
            this.btnXuong.Name = "btnXuong";
            this.btnXuong.Size = new System.Drawing.Size(75, 23);
            this.btnXuong.TabIndex = 29;
            this.btnXuong.Text = "Xuống";
            this.btnXuong.UseVisualStyleBackColor = true;
            this.btnXuong.Click += new System.EventHandler(this.btnXuong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 475);
            this.Controls.Add(this.btnXuong);
            this.Controls.Add(this.btnLen);
            this.Controls.Add(this.btnTrai2);
            this.Controls.Add(this.btnPhai2);
            this.Controls.Add(this.lbDaChon);
            this.Controls.Add(this.lbDanhSach);
            this.Controls.Add(this.btnTrai1);
            this.Controls.Add(this.btnPhai1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtThem);
            this.Controls.Add(this.lblTieuDePhais);
            this.Controls.Add(this.lblTieuDeTrai);
            this.Controls.Add(this.lblThem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrai2;
        private System.Windows.Forms.Button btnPhai2;
        private System.Windows.Forms.ListBox lbDaChon;
        private System.Windows.Forms.ListBox lbDanhSach;
        private System.Windows.Forms.Button btnTrai1;
        private System.Windows.Forms.Button btnPhai1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtThem;
        private System.Windows.Forms.Label lblTieuDePhais;
        private System.Windows.Forms.Label lblTieuDeTrai;
        private System.Windows.Forms.Label lblThem;
        private System.Windows.Forms.Button btnLen;
        private System.Windows.Forms.Button btnXuong;
    }
}

