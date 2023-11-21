using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2b2
{
    class Program
    {
        static void pt1(double a, double b)
        {
            if (a == 0 && b == 0)
            {
                Console.Write("Phương trình bật 1 vô số nghiệm");
            }
            else
            if (a == 0)
            {
                Console.Write("Phương trình bật 1 vô nghiệm");
            }
            else
                Console.Write("Phương trình bật 1 có nghiệm: " + -b / a);


        }

        static void pt2(double a, double b, double c)
        {
            if (a == 0)
            {
                pt1(b, c);
            }
            else
            {
                double denta = b * b + 4 * a * c;
                if (denta < 0)
                {
                    Console.Write("Phương trình vô nghiệm");
                }
                else
                if (denta == 0)
                {
                    Console.Write("Phương trình có nghiệm kép: " + (-b / 2 * a));
                }
                else
                if (denta > 0)
                {
                    Console.WriteLine("Phương trình có nghiệm phân biệt:");
                    Console.WriteLine("X1 = " + (-b + Math.Sqrt(denta)) / (2 * a));
                    Console.WriteLine("X2 = " + (-b - Math.Sqrt(denta)) / (2 * a));
                }
            }

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập a, b, c:\n");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            pt2(a, b, c);
            Console.ReadKey();
        }
    }
}
