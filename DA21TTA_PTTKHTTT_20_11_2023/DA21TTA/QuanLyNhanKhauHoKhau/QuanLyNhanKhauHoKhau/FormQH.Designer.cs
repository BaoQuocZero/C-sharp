namespace QuanLyNhanKhauHoKhau
{
    partial class FormQH
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
            System.Windows.Forms.Label mAQHLabel;
            System.Windows.Forms.Label tENQHLabel;
            this.qUANHUYENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHoKhauNhanKhauDataSet = new QuanLyNhanKhauHoKhau.QLHoKhauNhanKhauDataSet();
            this.mAQHDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENQHDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANHUYENTableAdapter = new QuanLyNhanKhauHoKhau.QLHoKhauNhanKhauDataSetTableAdapters.QUANHUYENTableAdapter();
            this.tableAdapterManager = new QuanLyNhanKhauHoKhau.QLHoKhauNhanKhauDataSetTableAdapters.TableAdapterManager();
            this.quanlynkhkDataSet = new QuanLyNhanKhauHoKhau.quanlynkhkDataSet();
            this.qUANHUYENBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qUANHUYENTableAdapter1 = new QuanLyNhanKhauHoKhau.quanlynkhkDataSetTableAdapters.QUANHUYENTableAdapter();
            this.tableAdapterManager1 = new QuanLyNhanKhauHoKhau.quanlynkhkDataSetTableAdapters.TableAdapterManager();
            this.mAQHTextBox = new System.Windows.Forms.TextBox();
            this.tENQHTextBox = new System.Windows.Forms.TextBox();
            this.qUANHUYENDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mAQHLabel = new System.Windows.Forms.Label();
            tENQHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qUANHUYENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHoKhauNhanKhauDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlynkhkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANHUYENBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANHUYENDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // qUANHUYENBindingSource
            // 
            this.qUANHUYENBindingSource.DataMember = "QUANHUYEN";
            this.qUANHUYENBindingSource.DataSource = this.qLHoKhauNhanKhauDataSet;
            // 
            // qLHoKhauNhanKhauDataSet
            // 
            this.qLHoKhauNhanKhauDataSet.DataSetName = "QLHoKhauNhanKhauDataSet";
            this.qLHoKhauNhanKhauDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mAQHDataGridViewTextBoxColumn1
            // 
            this.mAQHDataGridViewTextBoxColumn1.DataPropertyName = "MAQH";
            this.mAQHDataGridViewTextBoxColumn1.HeaderText = "MAQH";
            this.mAQHDataGridViewTextBoxColumn1.Name = "mAQHDataGridViewTextBoxColumn1";
            // 
            // tENQHDataGridViewTextBoxColumn1
            // 
            this.tENQHDataGridViewTextBoxColumn1.DataPropertyName = "TENQH";
            this.tENQHDataGridViewTextBoxColumn1.HeaderText = "TENQH";
            this.tENQHDataGridViewTextBoxColumn1.Name = "tENQHDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAQH";
            this.dataGridViewTextBoxColumn1.HeaderText = "MAQH";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENQH";
            this.dataGridViewTextBoxColumn2.HeaderText = "TENQH";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // qUANHUYENTableAdapter
            // 
            this.qUANHUYENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HOKHAUTableAdapter = null;
            this.tableAdapterManager.NHANKHAUTableAdapter = null;
            this.tableAdapterManager.PHUONGXATableAdapter = null;
            this.tableAdapterManager.QUANHUYENTableAdapter = this.qUANHUYENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QuanLyNhanKhauHoKhau.QLHoKhauNhanKhauDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // quanlynkhkDataSet
            // 
            this.quanlynkhkDataSet.DataSetName = "quanlynkhkDataSet";
            this.quanlynkhkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qUANHUYENBindingSource1
            // 
            this.qUANHUYENBindingSource1.DataMember = "QUANHUYEN";
            this.qUANHUYENBindingSource1.DataSource = this.quanlynkhkDataSet;
            // 
            // qUANHUYENTableAdapter1
            // 
            this.qUANHUYENTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.HOKHAUTableAdapter = null;
            this.tableAdapterManager1.NHANKHAUTableAdapter = null;
            this.tableAdapterManager1.PHUONGXATableAdapter = null;
            this.tableAdapterManager1.QUANHUYENTableAdapter = this.qUANHUYENTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = QuanLyNhanKhauHoKhau.quanlynkhkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mAQHLabel
            // 
            mAQHLabel.AutoSize = true;
            mAQHLabel.Location = new System.Drawing.Point(255, 68);
            mAQHLabel.Name = "mAQHLabel";
            mAQHLabel.Size = new System.Drawing.Size(42, 13);
            mAQHLabel.TabIndex = 4;
            mAQHLabel.Text = "MAQH:";
            // 
            // mAQHTextBox
            // 
            this.mAQHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qUANHUYENBindingSource1, "MAQH", true));
            this.mAQHTextBox.Location = new System.Drawing.Point(309, 65);
            this.mAQHTextBox.Name = "mAQHTextBox";
            this.mAQHTextBox.Size = new System.Drawing.Size(100, 20);
            this.mAQHTextBox.TabIndex = 5;
            // 
            // tENQHLabel
            // 
            tENQHLabel.AutoSize = true;
            tENQHLabel.Location = new System.Drawing.Point(255, 94);
            tENQHLabel.Name = "tENQHLabel";
            tENQHLabel.Size = new System.Drawing.Size(48, 13);
            tENQHLabel.TabIndex = 6;
            tENQHLabel.Text = "TENQH:";
            // 
            // tENQHTextBox
            // 
            this.tENQHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qUANHUYENBindingSource1, "TENQH", true));
            this.tENQHTextBox.Location = new System.Drawing.Point(309, 91);
            this.tENQHTextBox.Name = "tENQHTextBox";
            this.tENQHTextBox.Size = new System.Drawing.Size(100, 20);
            this.tENQHTextBox.TabIndex = 7;
            // 
            // qUANHUYENDataGridView
            // 
            this.qUANHUYENDataGridView.AutoGenerateColumns = false;
            this.qUANHUYENDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qUANHUYENDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.qUANHUYENDataGridView.DataSource = this.qUANHUYENBindingSource1;
            this.qUANHUYENDataGridView.Location = new System.Drawing.Point(12, 117);
            this.qUANHUYENDataGridView.Name = "qUANHUYENDataGridView";
            this.qUANHUYENDataGridView.Size = new System.Drawing.Size(677, 220);
            this.qUANHUYENDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MAQH";
            this.dataGridViewTextBoxColumn3.HeaderText = "MAQH";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TENQH";
            this.dataGridViewTextBoxColumn4.HeaderText = "TENQH";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // FormQH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 409);
            this.Controls.Add(this.qUANHUYENDataGridView);
            this.Controls.Add(mAQHLabel);
            this.Controls.Add(this.mAQHTextBox);
            this.Controls.Add(tENQHLabel);
            this.Controls.Add(this.tENQHTextBox);
            this.Name = "FormQH";
            this.Text = "FormQH";
            this.Load += new System.EventHandler(this.FormQH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qUANHUYENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHoKhauNhanKhauDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlynkhkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANHUYENBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANHUYENDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn mAQHDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENQHDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private QLHoKhauNhanKhauDataSet qLHoKhauNhanKhauDataSet;
        private System.Windows.Forms.BindingSource qUANHUYENBindingSource;
        private QLHoKhauNhanKhauDataSetTableAdapters.QUANHUYENTableAdapter qUANHUYENTableAdapter;
        private QLHoKhauNhanKhauDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private quanlynkhkDataSet quanlynkhkDataSet;
        private System.Windows.Forms.BindingSource qUANHUYENBindingSource1;
        private quanlynkhkDataSetTableAdapters.QUANHUYENTableAdapter qUANHUYENTableAdapter1;
        private quanlynkhkDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox mAQHTextBox;
        private System.Windows.Forms.TextBox tENQHTextBox;
        private System.Windows.Forms.DataGridView qUANHUYENDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}