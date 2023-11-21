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
    public partial class FormQH : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=.;Initial Catalog=QLHoKhauNhanKhau;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        //void loaddata()
        //{
        //    command = connection.CreateCommand();
        //    command.CommandText = "SELECT * FROM dbo.NHANKHAU";
        //    adapter.SelectCommand = command;
        //    table.Clear();
        //    adapter.Fill(table);
        //    dgv.DataSource = table;
        //}

        //void them()
        //{
        //    command = connection.CreateCommand();
        //    command.CommandText = "INSERT INTO QUANHUYEN (MAQH, TENQH) VALUES (" + txtMaPX.Text + ", N'" + txtTenQH.Text + "'),";
        //    adapter.SelectCommand = command;
        //    table.Clear();
        //    adapter.Fill(table);
        //    dgv.DataSource = table;
        //}
        public FormQH()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMa_Click(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //them();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMaPX_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormQH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlynkhkDataSet.QUANHUYEN' table. You can move, or remove it, as needed.
            this.qUANHUYENTableAdapter1.Fill(this.quanlynkhkDataSet.QUANHUYEN);
            // TODO: This line of code loads data into the 'qLHoKhauNhanKhauDataSet.QUANHUYEN' table. You can move, or remove it, as needed.
            this.qUANHUYENTableAdapter.Fill(this.qLHoKhauNhanKhauDataSet.QUANHUYEN);
            // TODO: This line of code loads data into the 'qLHoKhauNhanKhauDataSet.QUANHUYEN' table. You can move, or remove it, as needed.
            this.qUANHUYENTableAdapter.Fill(this.qLHoKhauNhanKhauDataSet.QUANHUYEN);
            // TODO: This line of code loads data into the 'qLHoKhauNhanKhauDataSet.QUANHUYEN' table. You can move, or remove it, as needed.
            this.qUANHUYENTableAdapter.Fill(this.qLHoKhauNhanKhauDataSet.QUANHUYEN);

        }

        private void mAQHTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mAQHLabel_Click(object sender, EventArgs e)
        {

        }

        private void tENQHLabel1_Click(object sender, EventArgs e)
        {

        }

        private void mAQHLabel1_Click(object sender, EventArgs e)
        {

        }

        private void mAQHTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tENQHLabel_Click(object sender, EventArgs e)
        {

        }

        private void qUANHUYENBindingSource_CurrentChanged(object sender, EventArgs e)
        {
                    }

        private void qUANHUYENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qUANHUYENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLHoKhauNhanKhauDataSet);

        }

        private void qUANHUYENBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {
                    }

        private void qUANHUYENListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void qUANHUYENListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void qUANHUYENBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.qUANHUYENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLHoKhauNhanKhauDataSet);

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mAQHTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
