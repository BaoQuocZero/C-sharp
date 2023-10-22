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

namespace Quản_lý_Nhân_viên
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-SDFOMUO\SQLEXPRESS;Initial Catalog=QuanLyNhanVien_LT;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * From NhanVien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboGoiTinh.SelectedIndex = 0;
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btnTimMa_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.ReadOnly = true;
            int i;
            i = dgv.CurrentRow.Index;
            txtMaNV.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dgv.Rows[i].Cells[1].Value.ToString();
            txtNamSinh.Text = dgv.Rows[i].Cells[2].Value.ToString();
            cboGoiTinh.Text = dgv.Rows[i].Cells[3].Value.ToString();
            txtDiaChi.Text = dgv.Rows[i].Cells[4].Value.ToString();
            txtDienThoai.Text = dgv.Rows[i].Cells[5].Value.ToString();

        }

        private void mnuThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.StartsWith("NV"))
            {
                command = connection.CreateCommand();
                command.CommandText = "Insert into NhanVien values('" + txtMaNV.Text + "',N'" + txtHoTen.Text + "','" + txtNamSinh.Text + "',N'" + cboGoiTinh.Text + "',N'" + txtDiaChi.Text + "','" + txtDienThoai.Text + "')";
                command.ExecuteNonQuery();
                loaddata();
            }
            else
            {
                lblMaNV.ForeColor = Color.Red;
            }
        }

        private void mnuXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM NhanVien WHERE MaNV = '" + txtMaNV.Text + "';";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void mnuTimMa_Click(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = false;
            txtMaNV.Text = "";
            txtNamSinh.Text = "";
            txtDiaChi.Text = "";
            txtHoTen.Text = "";
            cboGoiTinh.SelectedIndex = 0;
            txtDienThoai.Text = "";

        }

        private void mnuTimTen_Click(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = false;
            txtMaNV.Text = "";
            txtNamSinh.Text = "";
            txtDiaChi.Text = "";
            txtHoTen.Text = "";
            cboGoiTinh.SelectedIndex = 0;
            txtDienThoai.Text = "";
        }

        private void mnuSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE NhanVien SET HoTen = N'"+txtHoTen.Text+"', NamSinh = '"+txtNamSinh.Text+"', GioiTinh = N'"+cboGoiTinh.Text+"', DiaChi = N'"+txtDiaChi.Text+"', DienThoai = '"+txtDienThoai.Text+"' WHERE MaNV = '"+txtMaNV.Text+"'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuDemSL_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM NhanVien", connection))
                {
                    int count = (int)command.ExecuteScalar();
                    Console.WriteLine("Số dòng: " + count);
                    MessageBox.Show("Số dòng: " + count, "Đếm số lượng");
                }
            }

        }
    }
}
