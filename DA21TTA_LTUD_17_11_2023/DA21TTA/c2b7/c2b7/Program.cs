using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2b7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] donVi = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] truc = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
            int n = 0;
            Console.Write("Nhập vào số n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} {1}", truc[n / 10], donVi[n % 10]);
            Console.ReadLine();
        }
    }
}
