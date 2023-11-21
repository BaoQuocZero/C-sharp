namespace QLNKHKv2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoKhau));
            System.Windows.Forms.Label sOSOLabel;
            System.Windows.Forms.Label hOTENCHLabel;
            System.Windows.Forms.Label sONHALabel;
            System.Windows.Forms.Label tENDUONGLabel;
            System.Windows.Forms.Label kHUPHOAPLabel;
            System.Windows.Forms.Label tENPXLabel;
            this.quanlynkhkDataSet = new QLNKHKv2.quanlynkhkDataSet();
            this.hOKHAUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOKHAUTableAdapter = new QLNKHKv2.quanlynkhkDataSetTableAdapters.HOKHAUTableAdapter();
            this.tableAdapterManager = new QLNKHKv2.quanlynkhkDataSetTableAdapters.TableAdapterManager();
            this.hOKHAUBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.hOKHAUBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sOSOTextBox = new System.Windows.Forms.TextBox();
            this.hOTENCHTextBox = new System.Windows.Forms.TextBox();
            this.sONHATextBox = new System.Windows.Forms.TextBox();
            this.tENDUONGTextBox = new System.Windows.Forms.TextBox();
            this.kHUPHOAPTextBox = new System.Windows.Forms.TextBox();
            this.hOKHAUDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANHUYENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANHUYENTableAdapter = new QLNKHKv2.quanlynkhkDataSetTableAdapters.QUANHUYENTableAdapter();
            this.pHUONGXABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHUONGXATableAdapter = new QLNKHKv2.quanlynkhkDataSetTableAdapters.PHUONGXATableAdapter();
            this.tENPXComboBox = new System.Windows.Forms.ComboBox();
            sOSOLabel = new System.Windows.Forms.Label();
            hOTENCHLabel = new System.Windows.Forms.Label();
            sONHALabel = new System.Windows.Forms.Label();
            tENDUONGLabel = new System.Windows.Forms.Label();
            kHUPHOAPLabel = new System.Windows.Forms.Label();
            tENPXLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quanlynkhkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOKHAUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOKHAUBindingNavigator)).BeginInit();
            this.hOKHAUBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOKHAUDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANHUYENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUONGXABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // quanlynkhkDataSet
            // 
            this.quanlynkhkDataSet.DataSetName = "quanlynkhkDataSet";
            this.quanlynkhkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOKHAUBindingSource
            // 
            this.hOKHAUBindingSource.DataMember = "HOKHAU";
            this.hOKHAUBindingSource.DataSource = this.quanlynkhkDataSet;
            // 
            // hOKHAUTableAdapter
            // 
            this.hOKHAUTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HOKHAUTableAdapter = this.hOKHAUTableAdapter;
            this.tableAdapterManager.NHANKHAUTableAdapter = null;
            this.tableAdapterManager.PHUONGXATableAdapter = this.pHUONGXATableAdapter;
            this.tableAdapterManager.QUANHUYENTableAdapter = this.qUANHUYENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLNKHKv2.quanlynkhkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hOKHAUBindingNavigator
            // 
            this.hOKHAUBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hOKHAUBindingNavigator.BindingSource = this.hOKHAUBindingSource;
            this.hOKHAUBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hOKHAUBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hOKHAUBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.hOKHAUBindingNavigatorSaveItem});
            this.hOKHAUBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hOKHAUBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hOKHAUBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hOKHAUBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hOKHAUBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hOKHAUBindingNavigator.Name = "hOKHAUBindingNavigator";
            this.hOKHAUBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hOKHAUBindingNavigator.Size = new System.Drawing.Size(744, 25);
            this.hOKHAUBindingNavigator.TabIndex = 0;
            this.hOKHAUBindingNavigator.Text = "bindingNavigator1";
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
            // hOKHAUBindingNavigatorSaveItem
            // 
            this.hOKHAUBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hOKHAUBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hOKHAUBindingNavigatorSaveItem.Image")));
            this.hOKHAUBindingNavigatorSaveItem.Name = "hOKHAUBindingNavigatorSaveItem";
            this.hOKHAUBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.hOKHAUBindingNavigatorSaveItem.Text = "Save Data";
            this.hOKHAUBindingNavigatorSaveItem.Click += new System.EventHandler(this.hOKHAUBindingNavigatorSaveItem_Click);
            // 
            // sOSOLabel
            // 
            sOSOLabel.AutoSize = true;
            sOSOLabel.Location = new System.Drawing.Point(261, 45);
            sOSOLabel.Name = "sOSOLabel";
            sOSOLabel.Size = new System.Drawing.Size(40, 13);
            sOSOLabel.TabIndex = 1;
            sOSOLabel.Text = "SOSO:";
            // 
            // sOSOTextBox
            // 
            this.sOSOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOKHAUBindingSource, "SOSO", true));
            this.sOSOTextBox.Location = new System.Drawing.Point(339, 42);
            this.sOSOTextBox.Name = "sOSOTextBox";
            this.sOSOTextBox.Size = new System.Drawing.Size(100, 20);
            this.sOSOTextBox.TabIndex = 2;
            // 
            // hOTENCHLabel
            // 
            hOTENCHLabel.AutoSize = true;
            hOTENCHLabel.Location = new System.Drawing.Point(261, 97);
            hOTENCHLabel.Name = "hOTENCHLabel";
            hOTENCHLabel.Size = new System.Drawing.Size(63, 13);
            hOTENCHLabel.TabIndex = 5;
            hOTENCHLabel.Text = "HOTENCH:";
            // 
            // hOTENCHTextBox
            // 
            this.hOTENCHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOKHAUBindingSource, "HOTENCH", true));
            this.hOTENCHTextBox.Location = new System.Drawing.Point(339, 94);
            this.hOTENCHTextBox.Name = "hOTENCHTextBox";
            this.hOTENCHTextBox.Size = new System.Drawing.Size(100, 20);
            this.hOTENCHTextBox.TabIndex = 6;
            // 
            // sONHALabel
            // 
            sONHALabel.AutoSize = true;
            sONHALabel.Location = new System.Drawing.Point(261, 123);
            sONHALabel.Name = "sONHALabel";
            sONHALabel.Size = new System.Drawing.Size(48, 13);
            sONHALabel.TabIndex = 7;
            sONHALabel.Text = "SONHA:";
            // 
            // sONHATextBox
            // 
            this.sONHATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOKHAUBindingSource, "SONHA", true));
            this.sONHATextBox.Location = new System.Drawing.Point(339, 120);
            this.sONHATextBox.Name = "sONHATextBox";
            this.sONHATextBox.Size = new System.Drawing.Size(100, 20);
            this.sONHATextBox.TabIndex = 8;
            // 
            // tENDUONGLabel
            // 
            tENDUONGLabel.AutoSize = true;
            tENDUONGLabel.Location = new System.Drawing.Point(261, 149);
            tENDUONGLabel.Name = "tENDUONGLabel";
            tENDUONGLabel.Size = new System.Drawing.Size(72, 13);
            tENDUONGLabel.TabIndex = 9;
            tENDUONGLabel.Text = "TENDUONG:";
            // 
            // tENDUONGTextBox
            // 
            this.tENDUONGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOKHAUBindingSource, "TENDUONG", true));
            this.tENDUONGTextBox.Location = new System.Drawing.Point(339, 146);
            this.tENDUONGTextBox.Name = "tENDUONGTextBox";
            this.tENDUONGTextBox.Size = new System.Drawing.Size(100, 20);
            this.tENDUONGTextBox.TabIndex = 10;
            // 
            // kHUPHOAPLabel
            // 
            kHUPHOAPLabel.AutoSize = true;
            kHUPHOAPLabel.Location = new System.Drawing.Point(261, 175);
            kHUPHOAPLabel.Name = "kHUPHOAPLabel";
            kHUPHOAPLabel.Size = new System.Drawing.Size(70, 13);
            kHUPHOAPLabel.TabIndex = 11;
            kHUPHOAPLabel.Text = "KHUPHOAP:";
            // 
            // kHUPHOAPTextBox
            // 
            this.kHUPHOAPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOKHAUBindingSource, "KHUPHOAP", true));
            this.kHUPHOAPTextBox.Location = new System.Drawing.Point(339, 172);
            this.kHUPHOAPTextBox.Name = "kHUPHOAPTextBox";
            this.kHUPHOAPTextBox.Size = new System.Drawing.Size(100, 20);
            this.kHUPHOAPTextBox.TabIndex = 12;
            // 
            // hOKHAUDataGridView
            // 
            this.hOKHAUDataGridView.AutoGenerateColumns = false;
            this.hOKHAUDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hOKHAUDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.hOKHAUDataGridView.DataSource = this.hOKHAUBindingSource;
            this.hOKHAUDataGridView.Location = new System.Drawing.Point(12, 198);
            this.hOKHAUDataGridView.Name = "hOKHAUDataGridView";
            this.hOKHAUDataGridView.Size = new System.Drawing.Size(712, 220);
            this.hOKHAUDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SOSO";
            this.dataGridViewTextBoxColumn1.HeaderText = "SOSO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MAPX";
            this.dataGridViewTextBoxColumn2.HeaderText = "MAPX";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HOTENCH";
            this.dataGridViewTextBoxColumn3.HeaderText = "HOTENCH";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SONHA";
            this.dataGridViewTextBoxColumn4.HeaderText = "SONHA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TENDUONG";
            this.dataGridViewTextBoxColumn5.HeaderText = "TENDUONG";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "KHUPHOAP";
            this.dataGridViewTextBoxColumn6.HeaderText = "KHUPHOAP";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
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
            // pHUONGXABindingSource
            // 
            this.pHUONGXABindingSource.DataMember = "PHUONGXA";
            this.pHUONGXABindingSource.DataSource = this.quanlynkhkDataSet;
            // 
            // pHUONGXATableAdapter
            // 
            this.pHUONGXATableAdapter.ClearBeforeFill = true;
            // 
            // tENPXLabel
            // 
            tENPXLabel.AutoSize = true;
            tENPXLabel.Location = new System.Drawing.Point(261, 71);
            tENPXLabel.Name = "tENPXLabel";
            tENPXLabel.Size = new System.Drawing.Size(46, 13);
            tENPXLabel.TabIndex = 13;
            tENPXLabel.Text = "TENPX:";
            tENPXLabel.Click += new System.EventHandler(this.tENPXLabel_Click);
            // 
            // tENPXComboBox
            // 
            this.tENPXComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHUONGXABindingSource, "TENPX", true));
            this.tENPXComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.hOKHAUBindingSource, "MAPX", true));
            this.tENPXComboBox.DataSource = this.pHUONGXABindingSource;
            this.tENPXComboBox.DisplayMember = "TENPX";
            this.tENPXComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tENPXComboBox.FormattingEnabled = true;
            this.tENPXComboBox.Location = new System.Drawing.Point(339, 68);
            this.tENPXComboBox.Name = "tENPXComboBox";
            this.tENPXComboBox.Size = new System.Drawing.Size(100, 21);
            this.tENPXComboBox.TabIndex = 14;
            this.tENPXComboBox.ValueMember = "MAPX";
            // 
            // FormHoKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 441);
            this.Controls.Add(tENPXLabel);
            this.Controls.Add(this.tENPXComboBox);
            this.Controls.Add(this.hOKHAUDataGridView);
            this.Controls.Add(sOSOLabel);
            this.Controls.Add(this.sOSOTextBox);
            this.Controls.Add(hOTENCHLabel);
            this.Controls.Add(this.hOTENCHTextBox);
            this.Controls.Add(sONHALabel);
            this.Controls.Add(this.sONHATextBox);
            this.Controls.Add(tENDUONGLabel);
            this.Controls.Add(this.tENDUONGTextBox);
            this.Controls.Add(kHUPHOAPLabel);
            this.Controls.Add(this.kHUPHOAPTextBox);
            this.Controls.Add(this.hOKHAUBindingNavigator);
            this.Name = "FormHoKhau";
            this.Text = "FormHoKhau";
            this.Load += new System.EventHandler(this.FormHoKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanlynkhkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOKHAUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOKHAUBindingNavigator)).EndInit();
            this.hOKHAUBindingNavigator.ResumeLayout(false);
            this.hOKHAUBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOKHAUDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANHUYENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUONGXABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private quanlynkhkDataSet quanlynkhkDataSet;
        private System.Windows.Forms.BindingSource hOKHAUBindingSource;
        private quanlynkhkDataSetTableAdapters.HOKHAUTableAdapter hOKHAUTableAdapter;
        private quanlynkhkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hOKHAUBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton hOKHAUBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox sOSOTextBox;
        private System.Windows.Forms.TextBox hOTENCHTextBox;
        private System.Windows.Forms.TextBox sONHATextBox;
        private System.Windows.Forms.TextBox tENDUONGTextBox;
        private System.Windows.Forms.TextBox kHUPHOAPTextBox;
        private System.Windows.Forms.DataGridView hOKHAUDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private quanlynkhkDataSetTableAdapters.QUANHUYENTableAdapter qUANHUYENTableAdapter;
        private System.Windows.Forms.BindingSource qUANHUYENBindingSource;
        private quanlynkhkDataSetTableAdapters.PHUONGXATableAdapter pHUONGXATableAdapter;
        private System.Windows.Forms.BindingSource pHUONGXABindingSource;
        private System.Windows.Forms.ComboBox tENPXComboBox;
    }
}