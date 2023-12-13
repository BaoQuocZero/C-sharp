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

namespace QLNV_GianTiep
{
    public partial class FrmTimKiemNV : Form
    {
        public FrmTimKiemNV()
        {
            InitializeComponent();
        }

        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        SqlDataAdapter bodocghi;
        DataTable bangnv = new DataTable();
        int donghh;

        void HienThiDuLieu()
        {
            string sql = "SELECT * FROM NhanVien";
            bangnv = ketnoi.DocDuLieu(sql);
            bodocghi = ketnoi.docghi;
            dgvNhanVien.DataSource = bangnv;
        }

        private void FrmTimKiemNV_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        private void s_Click(object sender, EventArgs e)
        {
            Frm frm = new Frm();

            FrmPhongBan a = new FrmPhongBan();
            this.Hide();
            a.Closed += (s, args) => this.Close();
            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string tenNV = txtTenNV.Text;
            string maPB = cboTenPB.Text; // Giả sử bạn muốn tìm kiếm theo MaPB

            // Xây dựng câu truy vấn
            string sql = "SELECT * FROM NhanVien WHERE MaNV LIKE '%{maNV}%' AND HoTenNV LIKE '%{tenNV}%' AND TenPB LIKE '%{maPB}%'";

            // Hiển thị kết quả tìm kiếm
            bangnv = ketnoi.DocDuLieu(sql);
            dgvNhanVien.DataSource = bangnv;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            donghh = e.RowIndex;
            if (donghh >= 0)
            {
                txtMaNV.Text = bangnv.Rows[donghh][0].ToString();
                txtTenNV.Text = bangnv.Rows[donghh][1].ToString();
                cboTenPB.SelectedValue = bangnv.Rows[donghh][6].ToString();
            }
        }
    }
}
