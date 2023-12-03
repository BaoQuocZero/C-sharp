using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2b20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            double[] array;
            double tong = 0;

            // Nhập độ dài của mảng
            Console.Write("Nhập độ dài mảng = ");
            n = int.Parse(Console.ReadLine());
            array = new double[n];
            // Nhập các phần tử của mảng
            for (int i = 0; i < n; i++)
            {
                Console.Write("array[" + i + "] = ");
                array[i] = double.Parse(Console.ReadLine());
                if (array[i] < 0)
                {
                    tong = tong + array[i];
                }
            }


            // In kết quả
            Console.WriteLine("Tổng phần tử âm là = " + tong);
            Console.ReadKey();
        }
    }
}
