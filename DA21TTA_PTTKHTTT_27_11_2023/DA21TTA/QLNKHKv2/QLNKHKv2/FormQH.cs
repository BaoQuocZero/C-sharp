using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNKHKv2
{
    public partial class FormQH : Form
    {
        public FormQH()
        {
            InitializeComponent();
        }

        private void qUANHUYENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qUANHUYENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanlynkhkDataSet);

        }

        private void FormQH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlynkhkDataSet.QUANHUYEN' table. You can move, or remove it, as needed.
            this.qUANHUYENTableAdapter.Fill(this.quanlynkhkDataSet.QUANHUYEN);

        }
    }
}
