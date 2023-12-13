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
    public partial class FrmNhanVien : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=.;Initial Catalog=QLNV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tablenhanvien = new DataTable();

        void nhanvien()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * From NhanVien"; // Chỉnh sửa câu truy vấn để lấy dữ liệu từ bảng PhongBan
            adapter.SelectCommand = command;
            tablenhanvien.Clear();
            adapter.Fill(tablenhanvien);

            // Kiểm tra xem dgv đã được khai báo và cấu hình chưa
            if (dgv != null)
            {
                dgv.DataSource = tablenhanvien;
            }
        }

        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            nhanvien();
            LoadPhongBanComboBox();

            dateTimePicker_NgaySinh.Value = new DateTime(2000, 1, 1);
            txtGioiTinh.SelectedIndex = 0;
            txtSdt.Text = "0987654321";
        }

        private void LoadPhongBanComboBox()
        {
            try
            {
                using (SqlConnection newConnection = new SqlConnection(str))
                {
                    newConnection.Open();

                    // Định nghĩa câu lệnh SELECT để lấy MaPB và TenPB từ bảng PhongBan
                    string query = "SELECT MaPB, TenPB FROM PhongBan";

                    // Tạo một command mới với câu lệnh và kết nối
                    using (SqlCommand cmd = new SqlCommand(query, newConnection))
                    {
                        // Tạo một DataTable để lưu trữ kết quả
                        DataTable dt = new DataTable();

                        // Sử dụng SqlDataAdapter để đổ dữ liệu từ command vào DataTable
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }

                        // Thiết lập ComboBox
                        cboMaPB.DisplayMember = "TenPB"; // Hiển thị Tên Phòng Ban
                        cboMaPB.ValueMember = "MaPB";    // Giữ giá trị MaPB
                        cboMaPB.DataSource = dt;         // Đặt nguồn dữ liệu cho ComboBox
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (hiển thị hoặc ghi log)
                MessageBox.Show($"Đã xảy ra lỗi khi tải dữ liệu PhongBan: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu chỉ số dòng và cột hợp lệ
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy giá trị từ cột MaNV
                object maNVValue = dgv.Rows[e.RowIndex].Cells["MaNV"].Value;

                // Lấy giá trị từ cột HoTenNV
                object hoTenNVValue = dgv.Rows[e.RowIndex].Cells["HoTenNV"].Value;

                // Lấy giá trị từ cột GioiTinh
                object gioiTinhValue = dgv.Rows[e.RowIndex].Cells["GioiTinh"].Value;

                // Lấy giá trị từ cột NgaySinh
                object ngaySinhValue = dgv.Rows[e.RowIndex].Cells["NgaySinh"].Value;

                // Lấy giá trị từ cột DiaChiNV
                object diaChiNVValue = dgv.Rows[e.RowIndex].Cells["DiaChiNV"].Value;

                // Lấy giá trị từ cột SdtNV
                object sdtNVValue = dgv.Rows[e.RowIndex].Cells["SdtNV"].Value;

                // Lấy giá trị từ cột MaPB
                object maPBValue = dgv.Rows[e.RowIndex].Cells["MaPB"].Value;

                // Kiểm tra giá trị không phải null
                if (maNVValue != null && hoTenNVValue != null && gioiTinhValue != null && ngaySinhValue != null
                    && diaChiNVValue != null && sdtNVValue != null && maPBValue != null)
                {
                    // Hiển thị giá trị trong các TextBox và các điều khiển tương ứng
                    txtMaNV.Text = maNVValue.ToString();
                    txtTenNV.Text = hoTenNVValue.ToString();
                    txtGioiTinh.Text = gioiTinhValue.ToString();
                    dateTimePicker_NgaySinh.Value = Convert.ToDateTime(ngaySinhValue);
                    txtDiaChi.Text = diaChiNVValue.ToString();
                    txtSdt.Text = sdtNVValue.ToString();
                    cboMaPB .Text = maPBValue.ToString();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu các ô nhập liệu không rỗng
                if (txtTenNV.Text != "" && txtGioiTinh.Text != "" && txtDiaChi.Text != ""
                    && txtSdt.Text != "" && cboMaPB .Text != "")
                {
                    // Mở kết nối mới
                    using (SqlConnection newConnection = new SqlConnection(str))
                    {
                        newConnection.Open();

                        // Định nghĩa câu lệnh INSERT với tham số
                        string insertQuery = "INSERT INTO NhanVien (HoTenNV, GioiTinh, NgaySinh, DiaChiNV, SdtNV, MaPB) " +
                                             "VALUES (@HoTenNV, @GioiTinh, @NgaySinh, @DiaChiNV, @SdtNV, @MaPB)";

                        // Tạo một command mới với câu lệnh và kết nối
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, newConnection))
                        {
                            // Thêm tham số để ngăn chặn SQL injection
                            insertCommand.Parameters.AddWithValue("@HoTenNV", txtTenNV.Text);
                            insertCommand.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text);
                            insertCommand.Parameters.AddWithValue("@NgaySinh", dateTimePicker_NgaySinh.Value);
                            insertCommand.Parameters.AddWithValue("@DiaChiNV", txtDiaChi.Text);
                            insertCommand.Parameters.AddWithValue("@SdtNV", txtSdt.Text);
                            insertCommand.Parameters.AddWithValue("@MaPB", cboMaPB .Text);

                            // Thực thi câu lệnh INSERT
                            int rowsAffected = insertCommand.ExecuteNonQuery();

                            // Kiểm tra xem có dòng nào được thêm không
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Không thể thêm nhân viên. Vui lòng kiểm tra lại thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        // Đóng kết nối
                        newConnection.Close();

                        // Làm mới dữ liệu trong DataGridView
                        nhanvien(); // Làm mới danh sách phòng ban (nếu cần)
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi thêm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (hiển thị hoặc ghi log)
                MessageBox.Show($"Đã xảy ra lỗi khi thêm nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu ô nhập liệu MaNV không rỗng
                if (txtMaNV.Text != "")
                {
                    // Mở kết nối mới
                    using (SqlConnection newConnection = new SqlConnection(str))
                    {
                        newConnection.Open();

                        // Định nghĩa câu lệnh DELETE
                        string deleteQuery = "DELETE FROM NhanVien WHERE MaNV = @MaNV";

                        // Tạo một command mới với câu lệnh và kết nối
                        using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, newConnection))
                        {
                            // Thêm tham số để ngăn chặn SQL injection
                            deleteCommand.Parameters.AddWithValue("@MaNV", txtMaNV.Text);

                            // Thực thi câu lệnh DELETE
                            int rowsAffected = deleteCommand.ExecuteNonQuery();

                            // Kiểm tra xem có dòng nào bị xóa không
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Nhân viên đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy nhân viên với MaNV tương ứng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        // Đóng kết nối
                        newConnection.Close();

                        // Làm mới dữ liệu trong DataGridView
                        nhanvien(); // Làm mới danh sách nhân viên (nếu cần)
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn MaNV trước khi xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (hiển thị hoặc ghi log)
                MessageBox.Show($"Đã xảy ra lỗi khi xóa nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu các ô nhập liệu không rỗng
                if (!string.IsNullOrWhiteSpace(txtMaNV.Text) && !string.IsNullOrWhiteSpace(txtTenNV.Text)
                    && !string.IsNullOrWhiteSpace(txtGioiTinh.Text) && !string.IsNullOrWhiteSpace(txtDiaChi.Text)
                    && !string.IsNullOrWhiteSpace(txtSdt.Text) && !string.IsNullOrWhiteSpace(cboMaPB .Text))
                {
                    // Mở kết nối mới
                    using (SqlConnection newConnection = new SqlConnection(str))
                    {
                        newConnection.Open();

                        // Định nghĩa câu lệnh UPDATE
                        string updateQuery = "UPDATE NhanVien SET HoTenNV = @HoTenNV, GioiTinh = @GioiTinh, " +
                                             "NgaySinh = @NgaySinh, DiaChiNV = @DiaChiNV, SdtNV = @SdtNV, " +
                                             "MaPB = @MaPB WHERE MaNV = @MaNV";

                        // Tạo một command mới với câu lệnh và kết nối
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, newConnection))
                        {
                            // Thêm tham số để ngăn chặn SQL injection
                            updateCommand.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                            updateCommand.Parameters.AddWithValue("@HoTenNV", txtTenNV.Text);
                            updateCommand.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text);
                            updateCommand.Parameters.AddWithValue("@NgaySinh", dateTimePicker_NgaySinh.Value);
                            updateCommand.Parameters.AddWithValue("@DiaChiNV", txtDiaChi.Text);
                            updateCommand.Parameters.AddWithValue("@SdtNV", txtSdt.Text);
                            updateCommand.Parameters.AddWithValue("@MaPB", cboMaPB .Text);

                            // Thực thi câu lệnh UPDATE
                            int rowsAffected = updateCommand.ExecuteNonQuery();

                            // Kiểm tra xem có dòng nào được cập nhật không
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thông tin nhân viên đã được cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy nhân viên với MaNV tương ứng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        // Đóng kết nối
                        newConnection.Close();

                        // Làm mới dữ liệu trong DataGridView
                        nhanvien(); // Làm mới danh sách nhân viên (nếu cần)
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (hiển thị hoặc ghi log)
                MessageBox.Show($"Đã xảy ra lỗi khi cập nhật thông tin nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaPB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {
            // Xóa các ký tự không phải số khỏi nội dung TextBox
            string input = new string(txtSdt.Text.Where(char.IsDigit).ToArray());

            // Giới hạn độ dài của TextBox thành tối đa 10 ký tự
            if (input.Length > 10)
            {
                input = input.Substring(0, 10);
            }

            // Gán lại nội dung đã xử lý vào TextBox
            txtSdt.Text = input;

            // Đặt vị trí con trỏ về cuối TextBox
            txtSdt.SelectionStart = txtSdt.Text.Length;
        }

        private void dateTimePicker_NgaySinh_ValueChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu ngày sinh đã chọn không phải ngày hiện tại
            if (dateTimePicker_NgaySinh.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng chọn một ngày trong quá khứ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Đặt ngày sinh về giá trị mặc định là "01/01/2000"
                dateTimePicker_NgaySinh.Value = new DateTime(2000, 1, 1);
            }
            else
            {
                // Kiểm tra nếu người này chưa đủ 18 tuổi
                if (DateTime.Now.Year - dateTimePicker_NgaySinh.Value.Year < 18)
                {
                    MessageBox.Show("Người này chưa đủ 18 tuổi. Vui lòng chọn một ngày sinh khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Đặt ngày sinh về giá trị mặc định là "01/01/2000"
                    dateTimePicker_NgaySinh.Value = new DateTime(2000, 1, 1);
                }
            }
        }

    }
}
