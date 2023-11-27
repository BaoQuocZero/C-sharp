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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kếtXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hộKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHoKhau frm = new FormHoKhau();
            frm.Show();
        }

        private void nhânKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhanKhau frm = new FormNhanKhau();
            frm.Show();
        }

        private void mnuLuuTru_Click(object sender, EventArgs e)
        {

        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quậnHuyệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQH frm = new FormQH();
            frm.Show();
        }

        private void phườngXãToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPX frm = new FormPX();
            frm.Show();
        }

        private void nhânKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void nhânKhẩuToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FromTraCuuNhanKhau frm = new FromTraCuuNhanKhau();
            frm.Show();
        }

        private void hộKhẩuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
