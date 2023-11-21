using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2b4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào 4 số nguyên dương:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int e = Math.Max(a, b);
            int f = Math.Max(c, d);

            int g = Math.Max(e, f);
            Console.WriteLine("Số nghuyên dương lớn nhất:" + g);
        }
    }
}
