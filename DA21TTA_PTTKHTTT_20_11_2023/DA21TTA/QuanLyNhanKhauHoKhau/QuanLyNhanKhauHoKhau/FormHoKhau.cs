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
    public partial class FormHoKhau : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=.;Initial Catalog=QLHoKhauNhanKhau;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();


        public FormHoKhau()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMa_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlynkhkDataSet.HOKHAU' table. You can move, or remove it, as needed.
            this.hOKHAUTableAdapter.Fill(this.quanlynkhkDataSet.HOKHAU);
            // TODO: This line of code loads data into the 'quanlynkhkDataSet.HOKHAU' table. You can move, or remove it, as needed.
            this.hOKHAUTableAdapter1.Fill(this.quanlynkhkDataSet.HOKHAU);
            // TODO: This line of code loads data into the 'qLHoKhauNhanKhauDataSet.PHUONGXA' table. You can move, or remove it, as needed.
            this.pHUONGXATableAdapter.Fill(this.qLHoKhauNhanKhauDataSet.PHUONGXA);
            // TODO: This line of code loads data into the 'qLHoKhauNhanKhauDataSet.PHUONGXA' table. You can move, or remove it, as needed.
            this.pHUONGXATableAdapter.Fill(this.qLHoKhauNhanKhauDataSet.PHUONGXA);
            // TODO: This line of code loads data into the 'qLHoKhauNhanKhauDataSet.HOKHAU' table. You can move, or remove it, as needed.
            this.hOKHAUTableAdapter.Fill(this.qLHoKhauNhanKhauDataSet.HOKHAU);
            //cboGioiTinh.SelectedIndex = 0;
            connection = new SqlConnection(str);
            connection.Open();
            //loaddata();
            //tENPXComboBox.SelectedIndex = 0;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaDD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSoSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void hOKHAUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOKHAUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLHoKhauNhanKhauDataSet);

        }

        private void sOSOLabel_Click(object sender, EventArgs e)
        {

        }

        private void sONHALabel_Click(object sender, EventArgs e)
        {

        }

        private void tENDUONGLabel_Click(object sender, EventArgs e)
        {

        }

        private void mAPXLabel_Click(object sender, EventArgs e)
        {

        }

        private void hOTENCHUHOLabel_Click(object sender, EventArgs e)
        {

        }

        private void nHANKHAULabel_Click(object sender, EventArgs e)
        {

        }

        private void kHUPHOLabel_Click(object sender, EventArgs e)
        {

        }

        private void sOSOTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mAPXTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sONHATextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mAPXComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hOKHAUBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.hOKHAUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanlynkhkDataSet);

        }
    }
}
