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

namespace QLNV_KiemTra
{
    public partial class FrmDangNhap : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-SDFOMUO;Initial Catalog=QLNV_KiemTra;Integrated Security=True;";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tablenhanvien = new DataTable();

        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
        }

        private void lblDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.Closed += (s, args) => this.Close();

            FrmNhanVien frmNhanVien = new FrmNhanVien();
            frmNhanVien.ShowDialog();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string taiKhoan = txtTaiKhoang.Text;
                string matKhau = txtMatKhau.Text;

                // Kiểm tra xem có dữ liệu nào khớp trong bảng TaiKhoan hay không
                string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                    cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                    int result = (int)cmd.ExecuteScalar();

                    if (result > 0)
                    {
                        MessageBox.Show("Đăng nhập thành công!");

                        this.Hide();
                        FrmDangNhap frmDangNhap = new FrmDangNhap();
                        frmDangNhap.Closed += (s, args) => this.Close();

                        FrmNhanVien frmNhanVien = new FrmNhanVien();
                        frmNhanVien.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra tài khoản và mật khẩu.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi hãy liên hệ với dev mã lỗi: " + ex.Message);
            }
        }

        private void txtTaiKhoang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
