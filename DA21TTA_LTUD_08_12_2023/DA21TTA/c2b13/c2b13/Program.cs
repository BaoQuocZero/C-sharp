using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2b13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            double s = 0;

            for (int i = 1; i <= n; i++)
            {
                s += 1 / Math.Pow(2, i);
            }
            Console.Write("S= " + s);
            Console.ReadKey();
        }
    }
}
