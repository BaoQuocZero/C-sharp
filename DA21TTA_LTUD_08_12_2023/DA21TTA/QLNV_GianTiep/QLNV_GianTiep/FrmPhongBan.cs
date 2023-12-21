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
    public partial class FrmPhongBan : Form
    {
        public FrmPhongBan()
        {
            InitializeComponent();
        }

        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        SqlDataAdapter bodocghi;
        DataTable bangnv = new DataTable();
        int donghh;

        void HienThiDuLieu()
        {
            string sql = "SELECT * FROM PhongBan";
            bangnv = ketnoi.DocDuLieu(sql);
            bodocghi = ketnoi.docghi;
            dgvPhongBan.DataSource = bangnv;
        }


        private void FrmPhongBan_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenPB.Text != "")
                {
                    DataRow dongmoi = bangnv.NewRow();
                    dongmoi["TenPB"] = txtTenPB.Text;

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

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaPB.Text = "";
            txtTenPB.Text = "";
        }

        private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            donghh = e.RowIndex;
            if (donghh >= 0)
            {
                txtMaPB.Text = bangnv.Rows[donghh][0].ToString();
                txtTenPB.Text = bangnv.Rows[donghh][1].ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaPB.Text !="" || txtTenPB.Text != "")
                {
                    bangnv.Rows[donghh][0] = txtMaPB.Text;
                    bangnv.Rows[donghh][1] = txtTenPB.Text;

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
                if (txtMaPB.Text != "")
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm frm = new Frm();

            FrmPhongBan a = new FrmPhongBan();
            this.Hide();
            a.Closed += (s, args) => this.Close();
            frm.ShowDialog();
        }
    }
}
