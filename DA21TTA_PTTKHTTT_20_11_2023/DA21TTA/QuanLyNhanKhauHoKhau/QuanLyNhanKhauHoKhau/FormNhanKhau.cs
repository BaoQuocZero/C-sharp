using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace QuanLyNhanKhauHoKhau
{
    public partial class FormNhanKhau : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=.;Initial Catalog=QLHoKhauNhanKhau;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        
        public FormNhanKhau()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormNhanKhau_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlynkhkDataSet.NHANKHAU' table. You can move, or remove it, as needed.
            this.nHANKHAUTableAdapter1.Fill(this.quanlynkhkDataSet.NHANKHAU);
            // TODO: This line of code loads data into the 'qLHoKhauNhanKhauDataSet.HOKHAU' table. You can move, or remove it, as needed.
            this.hOKHAUTableAdapter.Fill(this.qLHoKhauNhanKhauDataSet.HOKHAU);
            // TODO: This line of code loads data into the 'qLHoKhauNhanKhauDataSet.NHANKHAU' table. You can move, or remove it, as needed.
            this.nHANKHAUTableAdapter.Fill(this.qLHoKhauNhanKhauDataSet.NHANKHAU);
            connection = new SqlConnection(str);
            connection.Open();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtSoSo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaDD_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMa_Click(object sender, EventArgs e)
        {

        }

        private void txtMaSTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSoSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblGioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblNgaySinh_Click(object sender, EventArgs e)
        {

        }

        private void timeNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblSoSo_Click(object sender, EventArgs e)
        {

        }

        private void nHANKHAUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHANKHAUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLHoKhauNhanKhauDataSet);

        }

        private void nHANKHAUDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hOTENLabel_Click(object sender, EventArgs e)
        {

        }

        private void mASOTTLabel_Click(object sender, EventArgs e)
        {

        }

        private void sOSOLabel_Click(object sender, EventArgs e)
        {

        }

        private void nGAYSINHLabel_Click(object sender, EventArgs e)
        {

        }

        private void gOITINHLabel_Click(object sender, EventArgs e)
        {

        }

        private void sOSOLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
