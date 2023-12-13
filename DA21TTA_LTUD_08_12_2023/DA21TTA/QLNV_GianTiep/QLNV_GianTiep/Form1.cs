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
    public partial class Frm : Form
    {
        public Frm()
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

        void HienPhongBan()
        {
            string sql = "SELECT * FROM PhongBan";
            cboTenPB.DataSource = ketnoi.DocDuLieu(sql);
            cboTenPB.DisplayMember = "TenPB";
            cboTenPB.ValueMember = "MaPB";
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            cboGioiTinh.SelectedIndex = 0;
            HienThiDuLieu();
            HienPhongBan();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtMaNV.Enabled = true;
            txtTenNV.Text = "";
            txtDiaChi.Text = "";
            txtSdt.Text = "";
            cboTenPB.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenNV.Text != "" && cboGioiTinh.Text != "" && txtDiaChi.Text != ""
                    && txtSdt.Text != "" && cboTenPB.Text != "")
                {
                    DataRow dongmoi = bangnv.NewRow();
                    dongmoi["MaNV"] = txtMaNV.Text;
                    dongmoi["TenNV"] = txtTenNV.Text;
                    dongmoi["GioiTinh"] = cboGioiTinh.Text;
                    dongmoi["NgaySinh"] = dateTimePicker_NgaySinh.Text;
                    dongmoi["DiaChiNV"] = txtDiaChi.Text;
                    dongmoi["SdtNV"] = txtSdt.Text;
                    dongmoi["MaPB"] = cboTenPB.SelectedValue;

                    bangnv.Rows.Add(dongmoi);

                    ketnoi.CapNhatDuLieu(bodocghi, bangnv);
                    bangnv.Clear();
                    HienThiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không bỏ trống bất cứ dòng nào !!!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm mới: " + ex.Message);
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            donghh = e.RowIndex;
            if (donghh >= 0)
            {
                txtMaNV.Text = bangnv.Rows[donghh][0].ToString();
                txtTenNV.Text = bangnv.Rows[donghh][1].ToString();
                cboGioiTinh.Text = bangnv.Rows[donghh][2].ToString();
                dateTimePicker_NgaySinh.Text = bangnv.Rows[donghh][3].ToString();
                txtDiaChi.Text = bangnv.Rows[donghh][4].ToString();
                txtSdt.Text = bangnv.Rows[donghh][5].ToString();
                cboTenPB.SelectedValue = bangnv.Rows[donghh][6].ToString();

                txtMaNV.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenNV.Text != "" && cboGioiTinh.Text != "" && txtDiaChi.Text != ""
                    && txtSdt.Text != "" && cboTenPB.Text != "")
                {
                    bangnv.Rows[donghh][0] = txtMaNV.Text;
                    bangnv.Rows[donghh][1] = txtTenNV.Text;
                    bangnv.Rows[donghh][2] = cboGioiTinh.Text;
                    bangnv.Rows[donghh][3] = dateTimePicker_NgaySinh.Text;
                    bangnv.Rows[donghh][4] = txtDiaChi.Text;
                    bangnv.Rows[donghh][5] = txtSdt.Text;
                    bangnv.Rows[donghh][6] = cboTenPB.SelectedValue;

                    ketnoi.CapNhatDuLieu(bodocghi, bangnv);
                    bangnv.Clear();
                    HienThiDuLieu();
                }
                else
                {
                    MessageBox.Show("Không bỏ trống bất cứ dòng nào !!!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNV.Text != "")
                {
                    bangnv.Rows[donghh].Delete();
                }
                else
                {
                    MessageBox.Show("Mã nhân viên rỗng !!!", "Thông báo");
                }


                ketnoi.CapNhatDuLieu(bodocghi, bangnv);
                bangnv.Clear();
                HienThiDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa" + ex.Message, "Thông báo");
            }
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            FrmPhongBan frm = new FrmPhongBan();

            this.Hide();
            Frm a = new Frm();
            a.Closed += (s, args) => this.Close();
            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            FrmTimKiemNV frm = new FrmTimKiemNV();

            this.Hide();
            Frm a = new Frm();
            a.Closed += (s, args) => this.Close();
            frm.ShowDialog();
        }
    }
}
