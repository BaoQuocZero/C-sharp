using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanKhauHoKhau
{
    public partial class FromTraCuuNhanKhau : Form
    {
        public FromTraCuuNhanKhau()
        {
            InitializeComponent();
        }

        private void nHANKHAUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHANKHAUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLHoKhauNhanKhauDataSet);

        }

        private void FromTraCuuNhanKhau_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHoKhauNhanKhauDataSet.NHANKHAU' table. You can move, or remove it, as needed.
            this.nHANKHAUTableAdapter.Fill(this.qLHoKhauNhanKhauDataSet.NHANKHAU);

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            nHANKHAUBindingSource.Filter = "hoten LIKE '%"+txtTim.Text+"%'";
            nHANKHAUDataGridView.DataSource = nHANKHAUBindingSource;
        }
    }
}
