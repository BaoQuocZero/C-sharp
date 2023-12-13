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

namespace QLNV
{
    public partial class FrmPhongBan : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=.;Initial Catalog=QLNV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tablephongban = new DataTable();

        void phongban()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * From PhongBan"; // Chỉnh sửa câu truy vấn để lấy dữ liệu từ bảng PhongBan
            adapter.SelectCommand = command;
            tablephongban.Clear();
            adapter.Fill(tablephongban);

            // Kiểm tra xem dgv đã được khai báo và cấu hình chưa
            if (dgv != null)
            {
                dgv.DataSource = tablephongban;
            }
        }

        public FrmPhongBan()
        {
            InitializeComponent();
        }

        private void FrmPhongBan_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            phongban();

            dgv.CellContentClick += new DataGridViewCellEventHandler(dgv_CellContentClick);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu chỉ số dòng và cột hợp lệ
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy giá trị từ cột MaPB
                object maPBValue = dgv.Rows[e.RowIndex].Cells["MaPB"].Value;

                // Lấy giá trị từ cột TenPB
                object tenPBValue = dgv.Rows[e.RowIndex].Cells["TenPB"].Value;

                // Kiểm tra giá trị không phải null
                if (maPBValue != null && tenPBValue != null)
                {
                    // Hiển thị giá trị trong các TextBox tương ứng
                    txtMaPB.Text = maPBValue.ToString();
                    txtTenPB.Text = tenPBValue.ToString();
                }
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Đảm bảo đóng kết nối sau khi sử dụng
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu ô nhập liệu không rỗng và MaPB trống
                if (!string.IsNullOrWhiteSpace(txtTenPB.Text) && string.IsNullOrWhiteSpace(txtMaPB.Text))
                {
                    // Mở kết nối mới
                    using (SqlConnection newConnection = new SqlConnection(str))
                    {
                        newConnection.Open();

                        // Định nghĩa câu lệnh INSERT với tham số
                        string insertQuery = "INSERT INTO PhongBan (TenPB) VALUES (@TenPB)";

                        // Tạo một command mới với câu lệnh và kết nối
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, newConnection))
                        {
                            // Thêm tham số để ngăn chặn SQL injection
                            insertCommand.Parameters.AddWithValue("@TenPB", txtTenPB.Text);

                            // Thực thi câu lệnh INSERT
                            insertCommand.ExecuteNonQuery();
                        }

                        // Đóng kết nối
                        newConnection.Close();

                        // Làm mới dữ liệu trong DataGridView
                        phongban();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên phòng ban và để trống mã PB trước khi thêm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (hiển thị hoặc ghi log)
                MessageBox.Show($"Đã xảy ra lỗi khi thêm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu ô nhập liệu không rỗng
                if (txtMaPB.Text != "")
                {
                    // Mở kết nối mới
                    using (SqlConnection newConnection = new SqlConnection(str))
                    {
                        newConnection.Open();

                        // Định nghĩa câu lệnh DELETE từ cả hai bảng
                        string deleteQuery = "DELETE FROM PhongBan WHERE MaPB = @MaPB AND MaPB NOT IN (SELECT DISTINCT MaPB FROM NhanVien)";

                        // Tạo một command mới với câu lệnh và kết nối
                        using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, newConnection))
                        {
                            // Thêm tham số để ngăn chặn SQL injection
                            deleteCommand.Parameters.AddWithValue("@MaPB", txtMaPB.Text);

                            // Thực thi câu lệnh DELETE cho bảng PhongBan
                            int rowsAffected = deleteCommand.ExecuteNonQuery();

                            // Kiểm tra xem có dòng nào bị xóa không
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Dữ liệu đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy dữ liệu với MaPB tương ứng hoặc PhongBan có Nhân Viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        // Đóng kết nối
                        newConnection.Close();

                        // Làm mới dữ liệu trong DataGridView
                        phongban();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn MaPB trước khi xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (hiển thị hoặc ghi log)
                MessageBox.Show($"Đã xảy ra lỗi khi xóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu ô nhập liệu không rỗng
                if (txtMaPB.Text != "" && txtTenPB.Text != "")
                {
                    // Mở kết nối mới
                    using (SqlConnection newConnection = new SqlConnection(str))
                    {
                        newConnection.Open();

                        // Định nghĩa câu lệnh UPDATE
                        string updateQuery = "UPDATE PhongBan SET TenPB = @TenPB WHERE MaPB = @MaPB";

                        // Tạo một command mới với câu lệnh và kết nối
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, newConnection))
                        {
                            // Thêm tham số để ngăn chặn SQL injection
                            updateCommand.Parameters.AddWithValue("@MaPB", txtMaPB.Text);
                            updateCommand.Parameters.AddWithValue("@TenPB", txtTenPB.Text);

                            // Thực thi câu lệnh UPDATE
                            int rowsAffected = updateCommand.ExecuteNonQuery();

                            // Kiểm tra xem có dòng nào được cập nhật không
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Dữ liệu đã được cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy dữ liệu với MaPB tương ứng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        // Đóng kết nối
                        newConnection.Close();

                        // Làm mới dữ liệu trong DataGridView
                        phongban();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn cả MaPB và TenPB trước khi cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (hiển thị hoặc ghi log)
                MessageBox.Show($"Đã xảy ra lỗi khi sửa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmNhanVien frm = new FrmNhanVien();
            frm.ShowDialog();
        }
    }
}
