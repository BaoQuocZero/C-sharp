using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c4b2
{
    public partial class Form1 : Form
    {
        private double memoryValue = 0; // Biến lưu trữ giá trị trong bộ nhớ

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

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTinh.Text += "0";
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            txtTinh.Text += " + ";
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            txtTinh.Text += " - ";
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            txtTinh.Text += " * ";
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            txtTinh.Text += " / ";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtTinh.Text = "";
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            try
            {
                // Sử dụng DataTable để tính toán giá trị biểu thức
                DataTable dt = new DataTable();
                var result = dt.Compute(txtTinh.Text, "");

                // Lưu kết quả vào bộ nhớ và hiển thị trong txtTinh.Text
                memoryValue = Convert.ToDouble(result);
                txtTinh.Text = memoryValue.ToString();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi trong quá trình tính toán
                txtTinh.Text = "Lỗi";
            }
        }

        private void btnCongTru_Click(object sender, EventArgs e)
        {
            try
            {
                // Sử dụng DataTable để tính toán giá trị biểu thức
                DataTable dt = new DataTable();
                var result = dt.Compute(txtTinh.Text, "");

                // Đổi dấu của kết quả và lưu vào bộ nhớ
                memoryValue = -Convert.ToDouble(result);

                // Hiển thị kết quả trong txtTinh.Text
                txtTinh.Text = memoryValue.ToString();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi trong quá trình tính toán
                txtTinh.Text = "Lỗi";
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            try
            {
                // Sử dụng DataTable để tính toán giá trị biểu thức
                DataTable dt = new DataTable();
                var result = dt.Compute(txtTinh.Text, "");

                // Tính căn bậc hai của kết quả và lưu vào bộ nhớ
                memoryValue = Math.Sqrt(Convert.ToDouble(result));

                // Hiển thị kết quả trong txtTinh.Text
                txtTinh.Text = memoryValue.ToString();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi trong quá trình tính toán
                txtTinh.Text = "Lỗi";
            }
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            // Thêm giá trị từ bộ nhớ vào biểu thức
            txtTinh.Text += memoryValue.ToString();
        }

        private void btnMCong_Click(object sender, EventArgs e)
        {
            try
            {
                // Sử dụng DataTable để tính toán giá trị biểu thức
                DataTable dt = new DataTable();
                var result = dt.Compute(txtTinh.Text, "");

                // Cộng kết quả vào bộ nhớ
                memoryValue += Convert.ToDouble(result);

                // Hiển thị kết quả trong txtTinh.Text
                txtTinh.Text = memoryValue.ToString();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi trong quá trình tính toán
                txtTinh.Text = "Lỗi";
            }
        }
    }
}
