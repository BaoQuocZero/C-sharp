using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2b16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            double[] array = new double[100];

            // Nhập độ dài của mảng
            Console.Write("Nhập độ dài mảng = ");
            n = int.Parse(Console.ReadLine());

            // Nhập các phần tử của mảng
            for (int i = 0; i < n; i++)
            {
                Console.Write("array[" + i + "] = ");
                array[i] = double.Parse(Console.ReadLine());
            }

            // Tìm phần tử lớn nhất và vị trí của nó
            double max = array[0];
            double min = array[0];
            int y = 0, z = 0;
            for (int i = 0; i < n; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    y = i;
                }
                if (min > array[i])
                {
                    min = array[i];
                    z = i;
                }
            }

            // In kết quả
            Console.WriteLine("Phần tử lớn nhất là array[" + y + "] = " + max);
            Console.WriteLine("Phần tử nhỏ nhất là array[" + z + "] = " + min);
            Console.ReadKey();
        }
    }
}
