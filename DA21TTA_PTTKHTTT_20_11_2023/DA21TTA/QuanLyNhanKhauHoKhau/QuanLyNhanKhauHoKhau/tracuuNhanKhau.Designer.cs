namespace QuanLyNhanKhauHoKhau
{
    partial class FromTraCuuNhanKhau
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
            System.Windows.Forms.Label hOTENLabel;
            this.qLHoKhauNhanKhauDataSet = new QuanLyNhanKhauHoKhau.QLHoKhauNhanKhauDataSet();
            this.nHANKHAUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANKHAUTableAdapter = new QuanLyNhanKhauHoKhau.QLHoKhauNhanKhauDataSetTableAdapters.NHANKHAUTableAdapter();
            this.tableAdapterManager = new QuanLyNhanKhauHoKhau.QLHoKhauNhanKhauDataSetTableAdapters.TableAdapterManager();
            this.nHANKHAUDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            hOTENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLHoKhauNhanKhauDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANKHAUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANKHAUDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // qLHoKhauNhanKhauDataSet
            // 
            this.qLHoKhauNhanKhauDataSet.DataSetName = "QLHoKhauNhanKhauDataSet";
            this.qLHoKhauNhanKhauDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANKHAUBindingSource
            // 
            this.nHANKHAUBindingSource.DataMember = "NHANKHAU";
            this.nHANKHAUBindingSource.DataSource = this.qLHoKhauNhanKhauDataSet;
            // 
            // nHANKHAUTableAdapter
            // 
            this.nHANKHAUTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HOKHAUTableAdapter = null;
            this.tableAdapterManager.NHANKHAUTableAdapter = this.nHANKHAUTableAdapter;
            this.tableAdapterManager.PHUONGXATableAdapter = null;
            this.tableAdapterManager.QUANHUYENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyNhanKhauHoKhau.QLHoKhauNhanKhauDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nHANKHAUDataGridView
            // 
            this.nHANKHAUDataGridView.AutoGenerateColumns = false;
            this.nHANKHAUDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nHANKHAUDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.nHANKHAUDataGridView.DataSource = this.nHANKHAUBindingSource;
            this.nHANKHAUDataGridView.Location = new System.Drawing.Point(0, 128);
            this.nHANKHAUDataGridView.Name = "nHANKHAUDataGridView";
            this.nHANKHAUDataGridView.Size = new System.Drawing.Size(683, 220);
            this.nHANKHAUDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MASOTT";
            this.dataGridViewTextBoxColumn1.HeaderText = "MASOTT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SOSO";
            this.dataGridViewTextBoxColumn2.HeaderText = "SOSO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HOTEN";
            this.dataGridViewTextBoxColumn3.HeaderText = "HOTEN";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GOITINH";
            this.dataGridViewTextBoxColumn4.HeaderText = "GOITINH";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NGAYSINH";
            this.dataGridViewTextBoxColumn5.HeaderText = "NGAYSINH";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(164, 59);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(48, 13);
            hOTENLabel.TabIndex = 1;
            hOTENLabel.Text = "HOTEN:";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(324, 54);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(219, 56);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(100, 20);
            this.txtTim.TabIndex = 4;
            // 
            // FromTraCuuNhanKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 368);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(hOTENLabel);
            this.Controls.Add(this.nHANKHAUDataGridView);
            this.Name = "FromTraCuuNhanKhau";
            this.Text = "Tra cứu nhân khẩu";
            this.Load += new System.EventHandler(this.FromTraCuuNhanKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLHoKhauNhanKhauDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANKHAUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANKHAUDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLHoKhauNhanKhauDataSet qLHoKhauNhanKhauDataSet;
        private System.Windows.Forms.BindingSource nHANKHAUBindingSource;
        private QLHoKhauNhanKhauDataSetTableAdapters.NHANKHAUTableAdapter nHANKHAUTableAdapter;
        private QLHoKhauNhanKhauDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView nHANKHAUDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
    }
}