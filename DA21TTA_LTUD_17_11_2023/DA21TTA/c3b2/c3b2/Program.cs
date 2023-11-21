using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c3b2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            PhanSo ps1 = new PhanSo();
            PhanSo ps2 = new PhanSo();

            Console.WriteLine("Nhập phân số 1:");
            ps1.NhapPhanSo();
            Console.WriteLine("Nhập phân số 2:");
            ps2.NhapPhanSo();

            PhanSo tong = ps1 + ps2;
            PhanSo hieu = ps1 - ps2;
            PhanSo tich = ps1 * ps2;
            PhanSo thuong = ps1 / ps2;

            Console.Write("Tổng phân số:");
            tong.XuatPhanSo();

            Console.Write("Hiệu phân số:");
            hieu.XuatPhanSo();

            Console.Write("Tích phân số:");
            tich.XuatPhanSo();

            Console.Write("Thương phân số:");
            thuong.XuatPhanSo();

            Console.ReadKey();
        }
    }
}
