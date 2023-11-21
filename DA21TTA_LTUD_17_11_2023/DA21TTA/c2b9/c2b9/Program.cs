using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2b9
{
    class Program
    {
        static void nhap()
        {
            try
            {
                string luongNgays;

                do
                {
                    Console.WriteLine("Nhập lương ngày: ");
                    luongNgays = string.Format(Console.ReadLine());

                } while (!CheckAndReturnInt(luongNgays));
            }
            catch
            {
                nhap();
            }
        }
        public static bool CheckAndReturnInt(string str)
        {
            // Kiểm tra xem chuỗi chỉ chứa số
            bool isNumber = true;
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    isNumber = false;
                    return false;
                }
            }

            if (!isNumber)
            {
                return false;
            }

            // Chuyển đổi chuỗi thành số nguyên
            int number = int.Parse(str);
            return true;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            nhap();
            Console.ReadKey();
        }
    }
}
