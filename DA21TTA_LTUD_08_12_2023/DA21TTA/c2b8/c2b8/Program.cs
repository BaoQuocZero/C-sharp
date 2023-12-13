using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2b8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Số ngày thuê phòng: ");
            int ngayThue = int.Parse(Console.ReadLine());

            Console.WriteLine("Loại phòng: ");
            Console.WriteLine("1 Loại A");
            Console.WriteLine("1 Loại B");
            Console.WriteLine("1 Loại C");
            int chon = int.Parse(Console.ReadLine());
            switch (chon)
            {
                case 1:
                    Console.WriteLine("{0} * {1} = {2}", ngayThue, 250000, ngayThue*250000);
                    break;
                case 2:
                    Console.WriteLine("{0} * {1} = {2}", ngayThue, 200000, ngayThue * 200000);
                    break;
                default:
                    Console.WriteLine("{0} * {1} = {2}", ngayThue, 150000, ngayThue * 150000);
                    break;
            }
            Console.ReadLine();
        }
    }
}
