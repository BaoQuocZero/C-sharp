using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2b15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            double s = 0;
            int y = 1;
            for (int i = 1; i <= n; i++)
            {
                s += Math.Pow(i, y);
                y++;
            }
            Console.Write("S= " + s);
            Console.ReadKey();
        }
    }
}
