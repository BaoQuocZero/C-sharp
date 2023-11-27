using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanKhauHoKhau
{
    public partial class FormPX : Form
    {
        public FormPX()
        {
            InitializeComponent();
        }

        private void FormPX_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlynkhkDataSet.PHUONGXA' table. You can move, or remove it, as needed.
            this.pHUONGXATableAdapter1.Fill(this.quanlynkhkDataSet.PHUONGXA);
            // TODO: This line of code loads data into the 'qLHoKhauNhanKhauDataSet.QUANHUYEN' table. You can move, or remove it, as needed.
            this.qUANHUYENTableAdapter.Fill(this.qLHoKhauNhanKhauDataSet.QUANHUYEN);
            // TODO: This line of code loads data into the 'qLHoKhauNhanKhauDataSet.PHUONGXA' table. You can move, or remove it, as needed.
            this.pHUONGXATableAdapter.Fill(this.qLHoKhauNhanKhauDataSet.PHUONGXA);

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblGioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pHUONGXABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHUONGXABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLHoKhauNhanKhauDataSet);

        }

        private void mAPXTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mAQHTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tENPXTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mAPXLabel_Click(object sender, EventArgs e)
        {

        }

        private void tENPXLabel_Click(object sender, EventArgs e)
        {

        }

        private void mAQHLabel_Click(object sender, EventArgs e)
        {

        }

        private void tENQHComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
