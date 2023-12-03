using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2b6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào 2 số nguyên:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double d;
            Console.WriteLine("1 Thực hiện phép cộng ");
            Console.WriteLine("2 Thực hiện phép trừ");
            Console.WriteLine("3 Thực hiện phép nhân");
            Console.WriteLine("4 Thực hiện phép chia");
            Console.WriteLine("5 Thoát");

            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    d = a+b;
                    Console.WriteLine(d);
                    break;
                case 2:
                    d = a-b;
                    Console.WriteLine(d);
                    break;
                case 3:
                    d = a * b;
                    Console.WriteLine(d);
                    break;
                case 4:
                    d = a / b;
                    Console.WriteLine(d);
                    break;
                default:
                    Console.WriteLine("thoát");
                    break;
            }
        }
    }
}
