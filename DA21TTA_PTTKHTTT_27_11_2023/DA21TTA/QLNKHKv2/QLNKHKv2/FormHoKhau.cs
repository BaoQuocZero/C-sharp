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
    public partial class FormHoKhau : Form
    {
        public FormHoKhau()
        {
            InitializeComponent();
        }

        private void hOKHAUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOKHAUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanlynkhkDataSet);

        }

        private void FormHoKhau_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlynkhkDataSet.PHUONGXA' table. You can move, or remove it, as needed.
            this.pHUONGXATableAdapter.Fill(this.quanlynkhkDataSet.PHUONGXA);
            // TODO: This line of code loads data into the 'quanlynkhkDataSet.QUANHUYEN' table. You can move, or remove it, as needed.
            this.qUANHUYENTableAdapter.Fill(this.quanlynkhkDataSet.QUANHUYEN);
            // TODO: This line of code loads data into the 'quanlynkhkDataSet.HOKHAU' table. You can move, or remove it, as needed.
            this.hOKHAUTableAdapter.Fill(this.quanlynkhkDataSet.HOKHAU);

        }

        private void tENPXLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnThemQH_Click(object sender, EventArgs e)
        {
            FormPX frm = new FormPX();
            frm.Show();
        }
    }
}
