using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c3b3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            HINH_TRON a = new HINH_TRON();
            HINH_TRU_TRON b = new HINH_TRU_TRON();
            a.Nhap();
            Console.WriteLine($"Diện tích hình tròn: {a.TinhDienTich()}");
            b.Nhap();
            b.TinhDienTich();
        }
    }
}
