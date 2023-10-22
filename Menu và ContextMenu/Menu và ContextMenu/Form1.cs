using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_và_ContextMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuFile_Click(object sender, EventArgs e)
        {

        }

        private void đauLàMenuCủaButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn1 = cmnuBtn.SourceControl as Button;
            btn1.BackColor = Color.Red;
        }

        private void cmnuBlu_Click(object sender, EventArgs e)
        {
            btn1 = cmnuBtn.SourceControl as Button;
            btn1.BackColor = Color.Blue;
        }
    }
}
