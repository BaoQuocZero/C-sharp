using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2b11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Số a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Số b: ");
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i > 0; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    Console.Write("Ước số chung lớn nhất =" + i);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
