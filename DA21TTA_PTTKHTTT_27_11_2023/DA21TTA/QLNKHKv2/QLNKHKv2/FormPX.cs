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
    public partial class FormPX : Form
    {
        public FormPX()
        {
            InitializeComponent();
        }

        private void pHUONGXABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHUONGXABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanlynkhkDataSet);

        }

        private void FormPX_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlynkhkDataSet.QUANHUYEN' table. You can move, or remove it, as needed.
            this.qUANHUYENTableAdapter.Fill(this.quanlynkhkDataSet.QUANHUYEN);
            // TODO: This line of code loads data into the 'quanlynkhkDataSet.PHUONGXA' table. You can move, or remove it, as needed.
            this.pHUONGXATableAdapter.Fill(this.quanlynkhkDataSet.PHUONGXA);

        }

        private void btnThemQH_Click(object sender, EventArgs e)
        {
            FormQH frm = new FormQH();
            frm.Show();
        }
    }
}
