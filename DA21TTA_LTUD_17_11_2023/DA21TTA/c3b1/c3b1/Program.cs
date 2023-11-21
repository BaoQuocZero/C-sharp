using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c3b1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            PhanSo ps1 = new PhanSo();
            PhanSo ps2 = new PhanSo();

            Console.WriteLine("Nhập phân số thứ nhất:");
            ps1.NhapPhanSo();

            Console.WriteLine("Nhập phân số thứ hai:");
            ps2.NhapPhanSo();

            Console.WriteLine("\nPhân số thứ nhất:");
            ps1.XuatPhanSo();

            Console.WriteLine("\nPhân số thứ hai:");
            ps2.XuatPhanSo();

            // Tính tổng, hiệu, tích, thương
            PhanSo tong = ps1.Cong(ps2);
            PhanSo hieu = ps1.Tru(ps2);
            PhanSo tich = ps1.Nhan(ps2);
            PhanSo thuong = ps1.Chia(ps2);

            Console.WriteLine("\nTổng hai phân số:");
            tong.XuatPhanSo();

            Console.WriteLine("\nHiệu hai phân số:");
            hieu.XuatPhanSo();

            Console.WriteLine("\nTích hai phân số:");
            tich.XuatPhanSo();

            Console.WriteLine("\nThương hai phân số:");
            thuong.XuatPhanSo();
        }
    }
}
