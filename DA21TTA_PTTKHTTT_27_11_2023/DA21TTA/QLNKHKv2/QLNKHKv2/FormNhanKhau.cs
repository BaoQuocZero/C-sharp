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
    public partial class FormNhanKhau : Form
    {
        public FormNhanKhau()
        {
            InitializeComponent();
        }

        private void nHANKHAUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHANKHAUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanlynkhkDataSet);

        }

        private void FormNhanKhau_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlynkhkDataSet.HOKHAU' table. You can move, or remove it, as needed.
            this.hOKHAUTableAdapter.Fill(this.quanlynkhkDataSet.HOKHAU);
            // TODO: This line of code loads data into the 'quanlynkhkDataSet.NHANKHAU' table. You can move, or remove it, as needed.
            this.nHANKHAUTableAdapter.Fill(this.quanlynkhkDataSet.NHANKHAU);

        }

        private void btnThemHK_Click(object sender, EventArgs e)
        {
            FormHoKhau frm = new FormHoKhau();
            frm.Show();
        }
    }
}
