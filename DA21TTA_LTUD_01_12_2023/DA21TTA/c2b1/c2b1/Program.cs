using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập điểm toán, lý, hóa:\n");
            float toan = float.Parse(Console.ReadLine());
            float ly = float.Parse(Console.ReadLine());
            float hoa = float.Parse(Console.ReadLine());
            Console.Write("Điểm trung binh: " + (toan + ly + hoa) / 3);
            Console.ReadKey();
        }
    }
}
