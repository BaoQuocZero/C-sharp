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
        string str = @"Data Source=.;Initial Catalog=NhanKhauHoKhau;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT [SOSO] AS [Số sổ],[MAPX] AS [Mã phường xã], [HOTENCH] AS [Họ tên], [SONHA] AS [Số nhà], [TENDUONG] AS [Tên đường],[KHUPHOAP] AS [Khu phố]FROM [NhanKhauHoKhau].[dbo].[HOKHAU]";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }

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
            cboGioiTinh.SelectedIndex = 0;
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
