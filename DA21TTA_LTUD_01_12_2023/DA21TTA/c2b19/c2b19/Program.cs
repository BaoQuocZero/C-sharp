using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2b19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n, dem = 0;
            double[] array;

            // Nhập độ dài của mảng
            Console.Write("Nhập độ dài mảng = ");
            n = int.Parse(Console.ReadLine());
            array = new double[n];
            // Nhập các phần tử của mảng
            for (int i = 0; i < n; i++)
            {
                Console.Write("array[" + i + "] = ");
                array[i] = double.Parse(Console.ReadLine());
                if (array[i] > 0)
                {
                    dem++;
                }
            }
            Console.WriteLine("Tổng phần tử dương là = " + dem);
            dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    dem++;
                }
            }
            Console.WriteLine("Tổng phần tử âm là = " + dem);
            dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == 0)
                {
                    dem++;
                }
            }
            Console.WriteLine("Tổng phần tử 0 là = " + dem);
            Console.ReadKey();
        }
    }
}
