namespace QLNKHKv2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPX));
            System.Windows.Forms.Label mAPXLabel;
            System.Windows.Forms.Label tENPXLabel;
            System.Windows.Forms.Label tENQHLabel;
            this.quanlynkhkDataSet = new QLNKHKv2.quanlynkhkDataSet();
            this.pHUONGXABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHUONGXATableAdapter = new QLNKHKv2.quanlynkhkDataSetTableAdapters.PHUONGXATableAdapter();
            this.tableAdapterManager = new QLNKHKv2.quanlynkhkDataSetTableAdapters.TableAdapterManager();
            this.pHUONGXABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pHUONGXABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mAPXTextBox = new System.Windows.Forms.TextBox();
            this.tENPXTextBox = new System.Windows.Forms.TextBox();
            this.pHUONGXADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANHUYENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANHUYENTableAdapter = new QLNKHKv2.quanlynkhkDataSetTableAdapters.QUANHUYENTableAdapter();
            this.tENQHComboBox = new System.Windows.Forms.ComboBox();
            mAPXLabel = new System.Windows.Forms.Label();
            tENPXLabel = new System.Windows.Forms.Label();
            tENQHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quanlynkhkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUONGXABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUONGXABindingNavigator)).BeginInit();
            this.pHUONGXABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHUONGXADataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANHUYENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // quanlynkhkDataSet
            // 
            this.quanlynkhkDataSet.DataSetName = "quanlynkhkDataSet";
            this.quanlynkhkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHUONGXABindingSource
            // 
            this.pHUONGXABindingSource.DataMember = "PHUONGXA";
            this.pHUONGXABindingSource.DataSource = this.quanlynkhkDataSet;
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
            this.tableAdapterManager.UpdateOrder = QLNKHKv2.quanlynkhkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pHUONGXABindingNavigator
            // 
            this.pHUONGXABindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pHUONGXABindingNavigator.BindingSource = this.pHUONGXABindingSource;
            this.pHUONGXABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pHUONGXABindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pHUONGXABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pHUONGXABindingNavigatorSaveItem});
            this.pHUONGXABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pHUONGXABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pHUONGXABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pHUONGXABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pHUONGXABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pHUONGXABindingNavigator.Name = "pHUONGXABindingNavigator";
            this.pHUONGXABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pHUONGXABindingNavigator.Size = new System.Drawing.Size(726, 25);
            this.pHUONGXABindingNavigator.TabIndex = 0;
            this.pHUONGXABindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // pHUONGXABindingNavigatorSaveItem
            // 
            this.pHUONGXABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pHUONGXABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pHUONGXABindingNavigatorSaveItem.Image")));
            this.pHUONGXABindingNavigatorSaveItem.Name = "pHUONGXABindingNavigatorSaveItem";
            this.pHUONGXABindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.pHUONGXABindingNavigatorSaveItem.Text = "Save Data";
            this.pHUONGXABindingNavigatorSaveItem.Click += new System.EventHandler(this.pHUONGXABindingNavigatorSaveItem_Click);
            // 
            // mAPXLabel
            // 
            mAPXLabel.AutoSize = true;
            mAPXLabel.Location = new System.Drawing.Point(263, 41);
            mAPXLabel.Name = "mAPXLabel";
            mAPXLabel.Size = new System.Drawing.Size(40, 13);
            mAPXLabel.TabIndex = 1;
            mAPXLabel.Text = "MAPX:";
            // 
            // mAPXTextBox
            // 
            this.mAPXTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHUONGXABindingSource, "MAPX", true));
            this.mAPXTextBox.Location = new System.Drawing.Point(315, 38);
            this.mAPXTextBox.Name = "mAPXTextBox";
            this.mAPXTextBox.Size = new System.Drawing.Size(100, 20);
            this.mAPXTextBox.TabIndex = 2;
            // 
            // tENPXLabel
            // 
            tENPXLabel.AutoSize = true;
            tENPXLabel.Location = new System.Drawing.Point(263, 93);
            tENPXLabel.Name = "tENPXLabel";
            tENPXLabel.Size = new System.Drawing.Size(46, 13);
            tENPXLabel.TabIndex = 5;
            tENPXLabel.Text = "TENPX:";
            // 
            // tENPXTextBox
            // 
            this.tENPXTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHUONGXABindingSource, "TENPX", true));
            this.tENPXTextBox.Location = new System.Drawing.Point(315, 90);
            this.tENPXTextBox.Name = "tENPXTextBox";
            this.tENPXTextBox.Size = new System.Drawing.Size(100, 20);
            this.tENPXTextBox.TabIndex = 6;
            // 
            // pHUONGXADataGridView
            // 
            this.pHUONGXADataGridView.AutoGenerateColumns = false;
            this.pHUONGXADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pHUONGXADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.pHUONGXADataGridView.DataSource = this.pHUONGXABindingSource;
            this.pHUONGXADataGridView.Location = new System.Drawing.Point(12, 116);
            this.pHUONGXADataGridView.Name = "pHUONGXADataGridView";
            this.pHUONGXADataGridView.Size = new System.Drawing.Size(694, 220);
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
            // qUANHUYENBindingSource
            // 
            this.qUANHUYENBindingSource.DataMember = "QUANHUYEN";
            this.qUANHUYENBindingSource.DataSource = this.quanlynkhkDataSet;
            // 
            // qUANHUYENTableAdapter
            // 
            this.qUANHUYENTableAdapter.ClearBeforeFill = true;
            // 
            // tENQHLabel
            // 
            tENQHLabel.AutoSize = true;
            tENQHLabel.Location = new System.Drawing.Point(261, 66);
            tENQHLabel.Name = "tENQHLabel";
            tENQHLabel.Size = new System.Drawing.Size(48, 13);
            tENQHLabel.TabIndex = 7;
            tENQHLabel.Text = "TENQH:";
            // 
            // tENQHComboBox
            // 
            this.tENQHComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qUANHUYENBindingSource, "TENQH", true));
            this.tENQHComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pHUONGXABindingSource, "MAQH", true));
            this.tENQHComboBox.DataSource = this.qUANHUYENBindingSource;
            this.tENQHComboBox.DisplayMember = "TENQH";
            this.tENQHComboBox.FormattingEnabled = true;
            this.tENQHComboBox.Location = new System.Drawing.Point(315, 63);
            this.tENQHComboBox.Name = "tENQHComboBox";
            this.tENQHComboBox.Size = new System.Drawing.Size(121, 21);
            this.tENQHComboBox.TabIndex = 8;
            this.tENQHComboBox.ValueMember = "MAQH";
            // 
            // FormPX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 407);
            this.Controls.Add(tENQHLabel);
            this.Controls.Add(this.tENQHComboBox);
            this.Controls.Add(this.pHUONGXADataGridView);
            this.Controls.Add(mAPXLabel);
            this.Controls.Add(this.mAPXTextBox);
            this.Controls.Add(tENPXLabel);
            this.Controls.Add(this.tENPXTextBox);
            this.Controls.Add(this.pHUONGXABindingNavigator);
            this.Name = "FormPX";
            this.Text = "FormPX";
            this.Load += new System.EventHandler(this.FormPX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanlynkhkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUONGXABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUONGXABindingNavigator)).EndInit();
            this.pHUONGXABindingNavigator.ResumeLayout(false);
            this.pHUONGXABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHUONGXADataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANHUYENBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private quanlynkhkDataSet quanlynkhkDataSet;
        private System.Windows.Forms.BindingSource pHUONGXABindingSource;
        private quanlynkhkDataSetTableAdapters.PHUONGXATableAdapter pHUONGXATableAdapter;
        private quanlynkhkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pHUONGXABindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pHUONGXABindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox mAPXTextBox;
        private System.Windows.Forms.TextBox tENPXTextBox;
        private quanlynkhkDataSetTableAdapters.QUANHUYENTableAdapter qUANHUYENTableAdapter;
        private System.Windows.Forms.DataGridView pHUONGXADataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource qUANHUYENBindingSource;
        private System.Windows.Forms.ComboBox tENQHComboBox;
    }
}