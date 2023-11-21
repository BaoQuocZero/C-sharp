using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2
{
    class Program
    {
        void b17(double[] a, int n)
        {
            Console.WriteLine("Các phần tử dương:");
            bool hasPositive = false;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > 0)
                {
                    Console.WriteLine($"array[{i}] = {a[i]}");
                    hasPositive = true;
                }
            }
            if (!hasPositive)
            {
                Console.WriteLine("Mảng không có số dương.");
            }
        }

        void b18(double[] array, int n)
        {
            bool check = false;
            double tong = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    tong = tong + array[i];
                    check = true;
                }
            }
            if (check == false)
            {
                Console.WriteLine("Mảng không có số dương");
            }


            // In kết quả
            Console.WriteLine("Tổng phần tử dương là = " + tong);
        }

        void b19(double[] array, int n)
        {
            int dem = 0;
            bool check = false;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    dem++;
                    check = true;
                }
            }
            Console.WriteLine("Số phần tử dương là = " + dem);
            if (check == false)
            {
                Console.WriteLine("Mảng không có số dương");
            }
            check = false;
            dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    dem++;
                    check = true;
                }
            }
            Console.WriteLine("Số phần tử âm là = " + dem);
            if (check == false)
            {
                Console.WriteLine("Mảng không có số âm");
            }
            check = false; ;
            dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == 0)
                {
                    dem++;
                    check = true;
                }
            }
            Console.WriteLine("Số phần tử 0 là = " + dem);
            if (check == false)
            {
                Console.WriteLine("Mảng không có số 0");
            }
        }

        void b20(double[] array, int n)
        {
            double tong = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    tong = tong + array[i];
                }
            }


            // In kết quả
            Console.WriteLine("Tổng phần tử âm là = " + tong);
        }

        void b21(double[] array, int n)
        {
            double tong = 0;
            // Nhập các phần tử của mảng
            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0 && array[i] % 2 == 0)
                {
                    tong = tong + array[i];
                }
            }


            // In kết quả
            Console.WriteLine("Tổng phần tử dương chẵn là = " + tong);
        }

        void b22(double[] array, int n)
        {
            bool check = false;
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
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;

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

            Program program = new Program();
            program.b17(array, n);
            program.b18(array, n);
            program.b19(array, n);
            program.b20(array, n);
            program.b21(array, n);
            program.b22(array, n);
        }
    }
}
