﻿namespace QLNKHKv2
{
    partial class FormTraCuuNhanKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTraCuuNhanKhau));
            System.Windows.Forms.Label hOTENLabel;
            this.quanlynkhkDataSet = new QLNKHKv2.quanlynkhkDataSet();
            this.nHANKHAUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANKHAUTableAdapter = new QLNKHKv2.quanlynkhkDataSetTableAdapters.NHANKHAUTableAdapter();
            this.tableAdapterManager = new QLNKHKv2.quanlynkhkDataSetTableAdapters.TableAdapterManager();
            this.nHANKHAUBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.nHANKHAUBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nHANKHAUDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            hOTENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quanlynkhkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANKHAUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANKHAUBindingNavigator)).BeginInit();
            this.nHANKHAUBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANKHAUDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // quanlynkhkDataSet
            // 
            this.quanlynkhkDataSet.DataSetName = "quanlynkhkDataSet";
            this.quanlynkhkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANKHAUBindingSource
            // 
            this.nHANKHAUBindingSource.DataMember = "NHANKHAU";
            this.nHANKHAUBindingSource.DataSource = this.quanlynkhkDataSet;
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
            this.tableAdapterManager.UpdateOrder = QLNKHKv2.quanlynkhkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nHANKHAUBindingNavigator
            // 
            this.nHANKHAUBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nHANKHAUBindingNavigator.BindingSource = this.nHANKHAUBindingSource;
            this.nHANKHAUBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nHANKHAUBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nHANKHAUBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.nHANKHAUBindingNavigatorSaveItem});
            this.nHANKHAUBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nHANKHAUBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nHANKHAUBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nHANKHAUBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nHANKHAUBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nHANKHAUBindingNavigator.Name = "nHANKHAUBindingNavigator";
            this.nHANKHAUBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nHANKHAUBindingNavigator.Size = new System.Drawing.Size(688, 25);
            this.nHANKHAUBindingNavigator.TabIndex = 0;
            this.nHANKHAUBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // nHANKHAUBindingNavigatorSaveItem
            // 
            this.nHANKHAUBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nHANKHAUBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nHANKHAUBindingNavigatorSaveItem.Image")));
            this.nHANKHAUBindingNavigatorSaveItem.Name = "nHANKHAUBindingNavigatorSaveItem";
            this.nHANKHAUBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.nHANKHAUBindingNavigatorSaveItem.Text = "Save Data";
            this.nHANKHAUBindingNavigatorSaveItem.Click += new System.EventHandler(this.nHANKHAUBindingNavigatorSaveItem_Click);
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
            this.nHANKHAUDataGridView.Location = new System.Drawing.Point(12, 177);
            this.nHANKHAUDataGridView.Name = "nHANKHAUDataGridView";
            this.nHANKHAUDataGridView.Size = new System.Drawing.Size(656, 220);
            this.nHANKHAUDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MANK";
            this.dataGridViewTextBoxColumn1.HeaderText = "MANK";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GIOITINH";
            this.dataGridViewTextBoxColumn4.HeaderText = "GIOITINH";
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
            hOTENLabel.Location = new System.Drawing.Point(193, 80);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(48, 13);
            hOTENLabel.TabIndex = 2;
            hOTENLabel.Text = "HOTEN:";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(353, 75);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(248, 75);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(100, 20);
            this.txtTim.TabIndex = 5;
            // 
            // FormTraCuuNhanKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 417);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(hOTENLabel);
            this.Controls.Add(this.nHANKHAUDataGridView);
            this.Controls.Add(this.nHANKHAUBindingNavigator);
            this.Name = "FormTraCuuNhanKhau";
            this.Text = "FormTraCuuNhanKhau";
            this.Load += new System.EventHandler(this.FormTraCuuNhanKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanlynkhkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANKHAUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANKHAUBindingNavigator)).EndInit();
            this.nHANKHAUBindingNavigator.ResumeLayout(false);
            this.nHANKHAUBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANKHAUDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private quanlynkhkDataSet quanlynkhkDataSet;
        private System.Windows.Forms.BindingSource nHANKHAUBindingSource;
        private quanlynkhkDataSetTableAdapters.NHANKHAUTableAdapter nHANKHAUTableAdapter;
        private quanlynkhkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator nHANKHAUBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton nHANKHAUBindingNavigatorSaveItem;
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