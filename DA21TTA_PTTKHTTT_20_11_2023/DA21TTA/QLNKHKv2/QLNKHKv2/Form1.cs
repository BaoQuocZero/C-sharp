using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNKHKv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuLuuTru_HoKhau_Click(object sender, EventArgs e)
        {
            FormHoKhau frm = new FormHoKhau();
            frm.Show();
        }

        private void nhânKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhanKhau frm = new FormNhanKhau();
            frm.Show();
        }

        private void phườngXãToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPX frm = new FormPX();
            frm.Show();
        }

        private void quậnHuyệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQH frm = new FormQH();
            frm.Show();
        }

        private void nhânKhẩuToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormTraCuuNhanKhau frm = new FormTraCuuNhanKhau();
            frm.Show();
        }
    }
}
