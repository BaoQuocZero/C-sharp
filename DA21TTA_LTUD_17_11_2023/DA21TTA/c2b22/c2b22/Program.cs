using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2b22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            bool check = false;
            double[] array;
            Random random = new Random();

            // Nhập độ dài của mảng
            Console.Write("Nhập độ dài mảng = ");
            n = int.Parse(Console.ReadLine());
            array = new double[n];
            // Nhập các phần tử của mảng
            for (int i = 0; i < n; i++)
            {                
                array[i] = random.Next(-100, 100);
                Console.WriteLine("array[" + i + "] = " + array[i]);
            }
            Console.WriteLine("Các phần tử âm:");
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    Console.WriteLine("array[" + i + "] = " + array[i]);
                    check = true;
                }
            }
            if (check == false)
            {
                Console.WriteLine("Mảng không có số âm");                
            }
            Console.ReadKey();
        }
    }
}
