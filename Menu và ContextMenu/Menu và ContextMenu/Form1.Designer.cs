namespace Menu_và_ContextMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mnu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuẨnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn1 = new System.Windows.Forms.Button();
            this.cmnuBtn = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuRed = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuBlu = new System.Windows.Forms.ToolStripMenuItem();
            this.btn2 = new System.Windows.Forms.Button();
            this.mnu.SuspendLayout();
            this.cmnu.SuspendLayout();
            this.cmnuBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu
            // 
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit});
            this.mnu.Location = new System.Drawing.Point(0, 0);
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(800, 24);
            this.mnu.TabIndex = 0;
            this.mnu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.mnuFileClose});
            this.mnuFile.Image = ((System.Drawing.Image)(resources.GetObject("mnuFile.Image")));
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(53, 20);
            this.mnuFile.Text = "File";
            this.mnuFile.Click += new System.EventHandler(this.mnuFile_Click);
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Image = ((System.Drawing.Image)(resources.GetObject("mnuFileNew.Image")));
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(180, 22);
            this.mnuFileNew.Text = "New";
            // 
            // mnuFileClose
            // 
            this.mnuFileClose.Image = ((System.Drawing.Image)(resources.GetObject("mnuFileClose.Image")));
            this.mnuFileClose.Name = "mnuFileClose";
            this.mnuFileClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuFileClose.Size = new System.Drawing.Size(180, 22);
            this.mnuFileClose.Text = "Close";
            this.mnuFileClose.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("mnuFileOpen.Image")));
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(180, 22);
            this.mnuFileOpen.Text = "Open";
            // 
            // mnuEdit
            // 
            this.mnuEdit.Image = ((System.Drawing.Image)(resources.GetObject("mnuEdit.Image")));
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(55, 20);
            this.mnuEdit.Text = "Edit";
            // 
            // cmnu
            // 
            this.cmnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuẨnToolStripMenuItem});
            this.cmnu.Name = "cmnu";
            this.cmnu.Size = new System.Drawing.Size(124, 26);
            // 
            // menuẨnToolStripMenuItem
            // 
            this.menuẨnToolStripMenuItem.Name = "menuẨnToolStripMenuItem";
            this.menuẨnToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.menuẨnToolStripMenuItem.Text = "Menu Ẩn";
            // 
            // btn1
            // 
            this.btn1.ContextMenuStrip = this.cmnuBtn;
            this.btn1.Location = new System.Drawing.Point(429, 84);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(338, 182);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // cmnuBtn
            // 
            this.cmnuBtn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuRed,
            this.cmnuBlu});
            this.cmnuBtn.Name = "cmnuBtn";
            this.cmnuBtn.Size = new System.Drawing.Size(181, 70);
            // 
            // cmnuRed
            // 
            this.cmnuRed.Name = "cmnuRed";
            this.cmnuRed.Size = new System.Drawing.Size(180, 22);
            this.cmnuRed.Text = "Red";
            this.cmnuRed.Click += new System.EventHandler(this.đauLàMenuCủaButtonToolStripMenuItem_Click);
            // 
            // cmnuBlu
            // 
            this.cmnuBlu.Name = "cmnuBlu";
            this.cmnuBlu.Size = new System.Drawing.Size(180, 22);
            this.cmnuBlu.Text = "Blu";
            this.cmnuBlu.Click += new System.EventHandler(this.cmnuBlu_Click);
            // 
            // btn2
            // 
            this.btn2.ContextMenuStrip = this.cmnuBtn;
            this.btn2.Location = new System.Drawing.Point(85, 84);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(338, 182);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "button1";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.cmnu;
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.mnu);
            this.MainMenuStrip = this.mnu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            this.cmnu.ResumeLayout(false);
            this.cmnuBtn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileClose;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ContextMenuStrip cmnu;
        private System.Windows.Forms.ToolStripMenuItem menuẨnToolStripMenuItem;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.ContextMenuStrip cmnuBtn;
        private System.Windows.Forms.ToolStripMenuItem cmnuRed;
        private System.Windows.Forms.ToolStripMenuItem cmnuBlu;
        private System.Windows.Forms.Button btn2;
    }
}

