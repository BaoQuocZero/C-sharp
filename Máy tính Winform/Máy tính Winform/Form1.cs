using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Máy_tính_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtIntput.Text = txtIntput.Text + "3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtIntput.Text = txtIntput.Text + "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtIntput.Text = txtIntput.Text + "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtIntput.Text = txtIntput.Text + "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtIntput.Text = txtIntput.Text + "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtIntput.Text = txtIntput.Text + "4";
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtIntput.Text = txtIntput.Text + "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            try
            {
                double kq = double.Parse(txtIntput.Text);
                lab1.Text = kq.ToString();
            }
            catch
            {
                lab1.Text = "Lỗi nhập liệu";
            }
        }

        private void btnDoiDau_Click(object sender, EventArgs e)
        {
            txtIntput.Text = "-" + txtIntput.Text;
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            txtIntput.Text = txtIntput.Text + "/";
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            txtIntput.Text = txtIntput.Text + "*";
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            txtIntput.Text = txtIntput.Text + "-";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtIntput.Text = txtIntput.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtIntput.Text = txtIntput.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtIntput.Text = txtIntput.Text + "9";
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            txtIntput.Text = txtIntput.Text + "+";
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            try
            {
                double kq = double.Parse(txtIntput.Text);
                kq = Math.Sqrt(kq);
                txtIntput.Text = kq.ToString();
            }
            catch
            {
                txtIntput.Text = "Lỗi khi Sqrt";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtIntput.Clear();
            lab1.Text = txtIntput.Text;
        }
    }
}
