namespace QLNKHKv2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQH));
            System.Windows.Forms.Label mAQHLabel;
            System.Windows.Forms.Label tENQHLabel;
            this.quanlynkhkDataSet = new QLNKHKv2.quanlynkhkDataSet();
            this.qUANHUYENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANHUYENTableAdapter = new QLNKHKv2.quanlynkhkDataSetTableAdapters.QUANHUYENTableAdapter();
            this.tableAdapterManager = new QLNKHKv2.quanlynkhkDataSetTableAdapters.TableAdapterManager();
            this.qUANHUYENBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.qUANHUYENBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mAQHTextBox = new System.Windows.Forms.TextBox();
            this.tENQHTextBox = new System.Windows.Forms.TextBox();
            this.qUANHUYENDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mAQHLabel = new System.Windows.Forms.Label();
            tENQHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quanlynkhkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANHUYENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANHUYENBindingNavigator)).BeginInit();
            this.qUANHUYENBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qUANHUYENDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // quanlynkhkDataSet
            // 
            this.quanlynkhkDataSet.DataSetName = "quanlynkhkDataSet";
            this.quanlynkhkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HOKHAUTableAdapter = null;
            this.tableAdapterManager.NHANKHAUTableAdapter = null;
            this.tableAdapterManager.PHUONGXATableAdapter = null;
            this.tableAdapterManager.QUANHUYENTableAdapter = this.qUANHUYENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLNKHKv2.quanlynkhkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qUANHUYENBindingNavigator
            // 
            this.qUANHUYENBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.qUANHUYENBindingNavigator.BindingSource = this.qUANHUYENBindingSource;
            this.qUANHUYENBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.qUANHUYENBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.qUANHUYENBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.qUANHUYENBindingNavigatorSaveItem});
            this.qUANHUYENBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.qUANHUYENBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.qUANHUYENBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.qUANHUYENBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.qUANHUYENBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.qUANHUYENBindingNavigator.Name = "qUANHUYENBindingNavigator";
            this.qUANHUYENBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.qUANHUYENBindingNavigator.Size = new System.Drawing.Size(737, 25);
            this.qUANHUYENBindingNavigator.TabIndex = 0;
            this.qUANHUYENBindingNavigator.Text = "bindingNavigator1";
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
            // qUANHUYENBindingNavigatorSaveItem
            // 
            this.qUANHUYENBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.qUANHUYENBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("qUANHUYENBindingNavigatorSaveItem.Image")));
            this.qUANHUYENBindingNavigatorSaveItem.Name = "qUANHUYENBindingNavigatorSaveItem";
            this.qUANHUYENBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.qUANHUYENBindingNavigatorSaveItem.Text = "Save Data";
            this.qUANHUYENBindingNavigatorSaveItem.Click += new System.EventHandler(this.qUANHUYENBindingNavigatorSaveItem_Click);
            // 
            // mAQHLabel
            // 
            mAQHLabel.AutoSize = true;
            mAQHLabel.Location = new System.Drawing.Point(271, 31);
            mAQHLabel.Name = "mAQHLabel";
            mAQHLabel.Size = new System.Drawing.Size(42, 13);
            mAQHLabel.TabIndex = 1;
            mAQHLabel.Text = "MAQH:";
            // 
            // mAQHTextBox
            // 
            this.mAQHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qUANHUYENBindingSource, "MAQH", true));
            this.mAQHTextBox.Location = new System.Drawing.Point(325, 28);
            this.mAQHTextBox.Name = "mAQHTextBox";
            this.mAQHTextBox.Size = new System.Drawing.Size(100, 20);
            this.mAQHTextBox.TabIndex = 2;
            // 
            // tENQHLabel
            // 
            tENQHLabel.AutoSize = true;
            tENQHLabel.Location = new System.Drawing.Point(271, 57);
            tENQHLabel.Name = "tENQHLabel";
            tENQHLabel.Size = new System.Drawing.Size(48, 13);
            tENQHLabel.TabIndex = 3;
            tENQHLabel.Text = "TENQH:";
            // 
            // tENQHTextBox
            // 
            this.tENQHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qUANHUYENBindingSource, "TENQH", true));
            this.tENQHTextBox.Location = new System.Drawing.Point(325, 54);
            this.tENQHTextBox.Name = "tENQHTextBox";
            this.tENQHTextBox.Size = new System.Drawing.Size(100, 20);
            this.tENQHTextBox.TabIndex = 4;
            // 
            // qUANHUYENDataGridView
            // 
            this.qUANHUYENDataGridView.AutoGenerateColumns = false;
            this.qUANHUYENDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qUANHUYENDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.qUANHUYENDataGridView.DataSource = this.qUANHUYENBindingSource;
            this.qUANHUYENDataGridView.Location = new System.Drawing.Point(12, 80);
            this.qUANHUYENDataGridView.Name = "qUANHUYENDataGridView";
            this.qUANHUYENDataGridView.Size = new System.Drawing.Size(713, 220);
            this.qUANHUYENDataGridView.TabIndex = 5;
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
            // FormQH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 386);
            this.Controls.Add(this.qUANHUYENDataGridView);
            this.Controls.Add(mAQHLabel);
            this.Controls.Add(this.mAQHTextBox);
            this.Controls.Add(tENQHLabel);
            this.Controls.Add(this.tENQHTextBox);
            this.Controls.Add(this.qUANHUYENBindingNavigator);
            this.Name = "FormQH";
            this.Text = "FormQH";
            this.Load += new System.EventHandler(this.FormQH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanlynkhkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANHUYENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANHUYENBindingNavigator)).EndInit();
            this.qUANHUYENBindingNavigator.ResumeLayout(false);
            this.qUANHUYENBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qUANHUYENDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private quanlynkhkDataSet quanlynkhkDataSet;
        private System.Windows.Forms.BindingSource qUANHUYENBindingSource;
        private quanlynkhkDataSetTableAdapters.QUANHUYENTableAdapter qUANHUYENTableAdapter;
        private quanlynkhkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator qUANHUYENBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton qUANHUYENBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox mAQHTextBox;
        private System.Windows.Forms.TextBox tENQHTextBox;
        private System.Windows.Forms.DataGridView qUANHUYENDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}