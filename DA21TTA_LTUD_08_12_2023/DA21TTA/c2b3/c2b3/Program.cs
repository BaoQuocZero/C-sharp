using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2b3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập vào hai giờ
            Console.WriteLine("Nhập giờ thứ nhất:");
            string hour1 = Console.ReadLine();
            Console.WriteLine("Nhập giờ thứ hai:");
            string hour2 = Console.ReadLine();

            // Chuyển đổi hai giờ thành kiểu DateTime
            DateTime dt1 = DateTime.Parse(hour1);
            DateTime dt2 = DateTime.Parse(hour2);

            // Tính tổng và hiệu của hai giờ
            DateTime sum = dt1.Hour(hour1) + dt2.Hour(hour1);
            DateTime sub = dt1 - dt2;

            // In ra tổng và hiệu của hai giờ
            Console.WriteLine("Tổng của hai giờ là: " + sum.ToString());
            Console.WriteLine("Hiệu của hai giờ là: " + sub.ToString());

        }
    }
}
