using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c4b2Fake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtTinh.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTinh.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTinh.Text += "3";
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            txtTinh.Text += " + ";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTinh.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTinh.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTinh.Text += "6";
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            txtTinh.Text += " - ";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTinh.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTinh.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTinh.Text += "9";
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            txtTinh.Text += " * ";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTinh.Text += "0";
        }

        private void btnBang_Click(object sender, EventArgs e)
        {

        }

        private void btnCongTru_Click(object sender, EventArgs e)
        {

        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            txtTinh.Text += " / ";
        }
    }
}
