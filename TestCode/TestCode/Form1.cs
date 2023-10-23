using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vietnameseName = "Nguyễn Văn A";
            bool isValid = IsValidVietnameseName(vietnameseName);
            MessageBox.Show("" + isValid);
        }
        static bool IsValidVietnameseName(string name)
        {
            // Kiểm tra xem chuỗi có chứa số hay không
            bool containsNumber = Regex.IsMatch(name, @"\d");

            // Kiểm tra xem chuỗi có chứa ký tự đặc biệt hay không
            // Chúng ta cho phép khoảng trắng và các ký tự Unicode bằng cách sử dụng biểu thức chính quy sau
            bool containsSpecialChar = Regex.IsMatch(name, @"[^\p{L}\s]");

            // Tên hợp lệ nếu không chứa số và ký tự đặc biệt
            return !containsNumber && !containsSpecialChar;
        }
    }
}
