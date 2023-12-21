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
    public partial class FrmPhongBan : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-SDFOMUO;Initial Catalog=QLNV_KiemTra;Integrated Security=True;";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tablephongban = new DataTable();

        void phongban()
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT * From PhongBan"; // Chỉnh sửa câu truy vấn để lấy dữ liệu từ bảng PhongBan
                adapter.SelectCommand = command;
                tablephongban.Clear();
                adapter.Fill(tablephongban);

                // Kiểm tra xem dgv đã được khai báo và cấu hình chưa
                if (dgvPhongBan != null)
                {
                    dgvPhongBan.DataSource = tablephongban;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi hãy liên hệ với dev mã lỗi: " + ex.Message);
            }
        }

        public FrmPhongBan()
        {
            InitializeComponent();
        }

        private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu chỉ số dòng và cột hợp lệ
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                object maPBValue = dgvPhongBan.Rows[e.RowIndex].Cells["MaPB"].Value;

                object tenPBValue = dgvPhongBan.Rows[e.RowIndex].Cells["TenPB"].Value;
                // Kiểm tra giá trị không phải null
                if (maPBValue != null && tenPBValue != null)
                {
                    // Hiển thị giá trị trong các TextBox và các điều khiển tương ứng
                    txtMaPB.Text = maPBValue.ToString();
                    txtTenPB.Text = tenPBValue.ToString();

                }
            }
        }

        private void FrmPhongBan_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            phongban();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaPB.Text = "";
            txtTenPB.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPhongBan frmPhongBan = new FrmPhongBan();
            frmPhongBan.Closed += (s, args) => this.Close();

            FrmNhanVien frmNhanVien = new FrmNhanVien();
            frmNhanVien.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtMaPB.Text) && !string.IsNullOrWhiteSpace(txtTenPB.Text))
                {
                    using (SqlConnection newConnection = new SqlConnection(str))
                    {
                        newConnection.Open();

                        string insertQuery = "INSERT INTO PhongBan (TenPB) " +
                                             "VALUES (@TenPB)";

                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, newConnection))
                        {
                            insertCommand.Parameters.AddWithValue("@TenPB", txtTenPB.Text);

                            int rowsAffected = insertCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                phongban();
                            }
                            else
                            {
                                MessageBox.Show("Không thể thêm nhân viên. Vui lòng kiểm tra lại thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        newConnection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi thêm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi thêm nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị MaPB và TenPB từ TextBox
                int maPBSua;
                if (!int.TryParse(txtMaPB.Text.Trim(), out maPBSua))
                {
                    MessageBox.Show("Vui lòng nhập một giá trị MaPB hợp lệ để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string tenPBSua = txtTenPB.Text.Trim();

                // Kiểm tra xem có giá trị để sửa không
                if (!string.IsNullOrEmpty(tenPBSua))
                {
                    // Mở kết nối mới
                    using (SqlConnection newConnection = new SqlConnection(str))
                    {
                        newConnection.Open();

                        // Kiểm tra xem có tồn tại phòng ban với MaPB tương ứng không
                        string checkExistQuery = "SELECT COUNT(*) FROM PhongBan WHERE MaPB = @MaPB";

                        using (SqlCommand checkExistCommand = new SqlCommand(checkExistQuery, newConnection))
                        {
                            checkExistCommand.Parameters.AddWithValue("@MaPB", maPBSua);
                            int count = (int)checkExistCommand.ExecuteScalar();

                            // Nếu không tồn tại, hiển thị thông báo lỗi và thoát
                            if (count == 0)
                            {
                                MessageBox.Show("Không tìm thấy phòng ban với MaPB tương ứng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        // Nếu tồn tại, tiến hành sửa thông tin
                        string updateQuery = "UPDATE PhongBan SET TenPB = @TenPB WHERE MaPB = @MaPB";

                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, newConnection))
                        {
                            // Thêm tham số để ngăn chặn SQL injection
                            updateCommand.Parameters.AddWithValue("@TenPB", tenPBSua);
                            updateCommand.Parameters.AddWithValue("@MaPB", maPBSua);

                            // Thực thi câu lệnh UPDATE
                            int rowsAffected = updateCommand.ExecuteNonQuery();

                            // Kiểm tra xem có dòng nào được cập nhật không
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thông tin phòng ban đã được cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy phòng ban với MaPB tương ứng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        // Đóng kết nối
                        newConnection.Close();

                        // Làm mới dữ liệu trong DataGridView hoặc thực hiện các hành động khác cần thiết
                        phongban();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập một giá trị TenPB hợp lệ để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi cập nhật thông tin phòng ban: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị MaPB từ TextBox txtMaPB
                int maPBToDelete;
                if (int.TryParse(txtMaPB.Text, out maPBToDelete))
                {
                    // Mở kết nối mới
                    using (SqlConnection newConnection = new SqlConnection(str))
                    {
                        newConnection.Open();

                        // Kiểm tra xem có khóa ngoại từ NhanVien trỏ đến PhongBan không
                        string checkForeignKeyQuery = "SELECT COUNT(*) FROM NhanVien WHERE MaPB = @MaPB";

                        using (SqlCommand checkForeignKeyCommand = new SqlCommand(checkForeignKeyQuery, newConnection))
                        {
                            checkForeignKeyCommand.Parameters.AddWithValue("@MaPB", maPBToDelete);
                            int count = (int)checkForeignKeyCommand.ExecuteScalar();

                            // Nếu có ít nhất một khóa ngoại, thông báo không xóa được
                            if (count > 0)
                            {
                                MessageBox.Show("Không thể xóa phòng ban vì có nhân viên thuộc phòng ban này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return; // Thoát khỏi sự kiện để không tiếp tục xóa
                            }
                        }

                        // Nếu không có khóa ngoại, tiến hành xóa dòng trong PhongBan
                        string deleteQuery = "DELETE FROM PhongBan WHERE MaPB = @MaPB";

                        using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, newConnection))
                        {
                            deleteCommand.Parameters.AddWithValue("@MaPB", maPBToDelete);
                            int rowsAffected = deleteCommand.ExecuteNonQuery();

                            // Kiểm tra xem có dòng nào bị xóa không
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Phòng ban đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy phòng ban với MaPB tương ứng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        // Đóng kết nối
                        newConnection.Close();

                        // Làm mới dữ liệu trong DataGridView hoặc thực hiện các hành động khác cần thiết
                        phongban();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập một giá trị MaPB hợp lệ để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi xóa phòng ban: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
