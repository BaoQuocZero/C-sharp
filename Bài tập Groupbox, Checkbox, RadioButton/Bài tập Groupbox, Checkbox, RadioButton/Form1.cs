using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_tập_Groupbox__Checkbox__RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApDung_Click(object sender, EventArgs e)
        {
            lblA.Text = txtInput.Text;
            if (radDo.Checked)
            {
                lblA.ForeColor = radDo.ForeColor;
            }
            if (radVang.Checked)
            {
                lblA.ForeColor = radVang.ForeColor;
            }
            if (radXanh.Checked)
            {
                lblA.ForeColor = radXanh.ForeColor;
            }
            if (radDen.Checked)
            {
                lblA.ForeColor = radDen.ForeColor;
            }

            if (chkDam.Checked)
            {
                chkBinhThuong.Checked = false;
                lblA.Font = new Font(
                    lblA.Font.Name,
                    lblA.Font.Size,
                    lblA.Font.Style ^ FontStyle.Bold);
            }
            if (chkGachChan.Checked)
            {
                chkBinhThuong.Checked = false;
                lblA.Font = new Font(
                    lblA.Font.Name,
                    lblA.Font.Size,
                    lblA.Font.Style ^ FontStyle.Underline);
            }
            if (chkNghieng.Checked)
            {
                chkBinhThuong.Checked = false;
                lblA.Font = new Font(
                    lblA.Font.Name,
                    lblA.Font.Size,
                    lblA.Font.Style ^ FontStyle.Italic);
            }
            if (chkBinhThuong.Checked)
            {
                lblA.Font = new Font(
                    lblA.Font.Name,
                    lblA.Font.Size,
                    lblA.Font.Style ^ FontStyle.Regular);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radDen.Checked = true;
            chkBinhThuong.Checked = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
        }
    }
}
