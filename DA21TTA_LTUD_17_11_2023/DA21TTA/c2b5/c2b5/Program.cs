using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2b5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số km đã đi: ");
            double km = double.Parse(Console.ReadLine());
            double money = 0;
            if (km >= 0)
            {
                money = 5000 + ((km - 1) * 4500);
            }
            if (km > 5)
            {
                money = ((km - 5) * 3500) + 23000;
            }
            if (km >= 120)
            {
                money -= money / 10;
            }
            Console.WriteLine("Số tiền: " + money + "VNĐ");
            Console.ReadKey();
        }
    }
}
