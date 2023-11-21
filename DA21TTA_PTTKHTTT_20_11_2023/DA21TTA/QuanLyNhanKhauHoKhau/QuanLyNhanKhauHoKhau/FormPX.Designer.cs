namespace QuanLyNhanKhauHoKhau
{
    partial class FormPX
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
            System.Windows.Forms.Label mAPXLabel;
            System.Windows.Forms.Label mAQHLabel;
            System.Windows.Forms.Label tENPXLabel;
            this.pHUONGXABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHoKhauNhanKhauDataSet = new QuanLyNhanKhauHoKhau.QLHoKhauNhanKhauDataSet();
            this.qUANHUYENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHUONGXATableAdapter = new QuanLyNhanKhauHoKhau.QLHoKhauNhanKhauDataSetTableAdapters.PHUONGXATableAdapter();
            this.tableAdapterManager = new QuanLyNhanKhauHoKhau.QLHoKhauNhanKhauDataSetTableAdapters.TableAdapterManager();
            this.qUANHUYENTableAdapter = new QuanLyNhanKhauHoKhau.QLHoKhauNhanKhauDataSetTableAdapters.QUANHUYENTableAdapter();
            this.quanlynkhkDataSet = new QuanLyNhanKhauHoKhau.quanlynkhkDataSet();
            this.pHUONGXABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pHUONGXATableAdapter1 = new QuanLyNhanKhauHoKhau.quanlynkhkDataSetTableAdapters.PHUONGXATableAdapter();
            this.tableAdapterManager1 = new QuanLyNhanKhauHoKhau.quanlynkhkDataSetTableAdapters.TableAdapterManager();
            this.mAPXTextBox = new System.Windows.Forms.TextBox();
            this.mAQHTextBox = new System.Windows.Forms.TextBox();
            this.tENPXTextBox = new System.Windows.Forms.TextBox();
            this.pHUONGXADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mAPXLabel = new System.Windows.Forms.Label();
            mAQHLabel = new System.Windows.Forms.Label();
            tENPXLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pHUONGXABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHoKhauNhanKhauDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANHUYENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlynkhkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUONGXABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUONGXADataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pHUONGXABindingSource
            // 
            this.pHUONGXABindingSource.DataMember = "PHUONGXA";
            this.pHUONGXABindingSource.DataSource = this.qLHoKhauNhanKhauDataSet;
            // 
            // qLHoKhauNhanKhauDataSet
            // 
            this.qLHoKhauNhanKhauDataSet.DataSetName = "QLHoKhauNhanKhauDataSet";
            this.qLHoKhauNhanKhauDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qUANHUYENBindingSource
            // 
            this.qUANHUYENBindingSource.DataMember = "QUANHUYEN";
            this.qUANHUYENBindingSource.DataSource = this.qLHoKhauNhanKhauDataSet;
            // 
            // pHUONGXATableAdapter
            // 
            this.pHUONGXATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HOKHAUTableAdapter = null;
            this.tableAdapterManager.NHANKHAUTableAdapter = null;
            this.tableAdapterManager.PHUONGXATableAdapter = this.pHUONGXATableAdapter;
            this.tableAdapterManager.QUANHUYENTableAdapter = this.qUANHUYENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QuanLyNhanKhauHoKhau.QLHoKhauNhanKhauDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qUANHUYENTableAdapter
            // 
            this.qUANHUYENTableAdapter.ClearBeforeFill = true;
            // 
            // quanlynkhkDataSet
            // 
            this.quanlynkhkDataSet.DataSetName = "quanlynkhkDataSet";
            this.quanlynkhkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHUONGXABindingSource1
            // 
            this.pHUONGXABindingSource1.DataMember = "PHUONGXA";
            this.pHUONGXABindingSource1.DataSource = this.quanlynkhkDataSet;
            // 
            // pHUONGXATableAdapter1
            // 
            this.pHUONGXATableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.HOKHAUTableAdapter = null;
            this.tableAdapterManager1.NHANKHAUTableAdapter = null;
            this.tableAdapterManager1.PHUONGXATableAdapter = this.pHUONGXATableAdapter1;
            this.tableAdapterManager1.QUANHUYENTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QuanLyNhanKhauHoKhau.quanlynkhkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mAPXLabel
            // 
            mAPXLabel.AutoSize = true;
            mAPXLabel.Location = new System.Drawing.Point(250, 70);
            mAPXLabel.Name = "mAPXLabel";
            mAPXLabel.Size = new System.Drawing.Size(40, 13);
            mAPXLabel.TabIndex = 2;
            mAPXLabel.Text = "MAPX:";
            // 
            // mAPXTextBox
            // 
            this.mAPXTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHUONGXABindingSource1, "MAPX", true));
            this.mAPXTextBox.Location = new System.Drawing.Point(302, 67);
            this.mAPXTextBox.Name = "mAPXTextBox";
            this.mAPXTextBox.Size = new System.Drawing.Size(100, 20);
            this.mAPXTextBox.TabIndex = 3;
            // 
            // mAQHLabel
            // 
            mAQHLabel.AutoSize = true;
            mAQHLabel.Location = new System.Drawing.Point(250, 96);
            mAQHLabel.Name = "mAQHLabel";
            mAQHLabel.Size = new System.Drawing.Size(42, 13);
            mAQHLabel.TabIndex = 4;
            mAQHLabel.Text = "MAQH:";
            // 
            // mAQHTextBox
            // 
            this.mAQHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHUONGXABindingSource1, "MAQH", true));
            this.mAQHTextBox.Location = new System.Drawing.Point(302, 93);
            this.mAQHTextBox.Name = "mAQHTextBox";
            this.mAQHTextBox.Size = new System.Drawing.Size(100, 20);
            this.mAQHTextBox.TabIndex = 5;
            // 
            // tENPXLabel
            // 
            tENPXLabel.AutoSize = true;
            tENPXLabel.Location = new System.Drawing.Point(250, 122);
            tENPXLabel.Name = "tENPXLabel";
            tENPXLabel.Size = new System.Drawing.Size(46, 13);
            tENPXLabel.TabIndex = 6;
            tENPXLabel.Text = "TENPX:";
            // 
            // tENPXTextBox
            // 
            this.tENPXTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHUONGXABindingSource1, "TENPX", true));
            this.tENPXTextBox.Location = new System.Drawing.Point(302, 119);
            this.tENPXTextBox.Name = "tENPXTextBox";
            this.tENPXTextBox.Size = new System.Drawing.Size(100, 20);
            this.tENPXTextBox.TabIndex = 7;
            // 
            // pHUONGXADataGridView
            // 
            this.pHUONGXADataGridView.AutoGenerateColumns = false;
            this.pHUONGXADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pHUONGXADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.pHUONGXADataGridView.DataSource = this.pHUONGXABindingSource1;
            this.pHUONGXADataGridView.Location = new System.Drawing.Point(12, 145);
            this.pHUONGXADataGridView.Name = "pHUONGXADataGridView";
            this.pHUONGXADataGridView.Size = new System.Drawing.Size(639, 220);
            this.pHUONGXADataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAPX";
            this.dataGridViewTextBoxColumn1.HeaderText = "MAPX";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MAQH";
            this.dataGridViewTextBoxColumn2.HeaderText = "MAQH";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TENPX";
            this.dataGridViewTextBoxColumn3.HeaderText = "TENPX";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FormPX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.pHUONGXADataGridView);
            this.Controls.Add(mAPXLabel);
            this.Controls.Add(this.mAPXTextBox);
            this.Controls.Add(mAQHLabel);
            this.Controls.Add(this.mAQHTextBox);
            this.Controls.Add(tENPXLabel);
            this.Controls.Add(this.tENPXTextBox);
            this.Name = "FormPX";
            this.Text = "FormPX";
            this.Load += new System.EventHandler(this.FormPX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pHUONGXABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHoKhauNhanKhauDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANHUYENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlynkhkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUONGXABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUONGXADataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QLHoKhauNhanKhauDataSet qLHoKhauNhanKhauDataSet;
        private System.Windows.Forms.BindingSource pHUONGXABindingSource;
        private QLHoKhauNhanKhauDataSetTableAdapters.PHUONGXATableAdapter pHUONGXATableAdapter;
        private QLHoKhauNhanKhauDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLHoKhauNhanKhauDataSetTableAdapters.QUANHUYENTableAdapter qUANHUYENTableAdapter;
        private System.Windows.Forms.BindingSource qUANHUYENBindingSource;
        private quanlynkhkDataSet quanlynkhkDataSet;
        private System.Windows.Forms.BindingSource pHUONGXABindingSource1;
        private quanlynkhkDataSetTableAdapters.PHUONGXATableAdapter pHUONGXATableAdapter1;
        private quanlynkhkDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox mAPXTextBox;
        private System.Windows.Forms.TextBox mAQHTextBox;
        private System.Windows.Forms.TextBox tENPXTextBox;
        private System.Windows.Forms.DataGridView pHUONGXADataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}