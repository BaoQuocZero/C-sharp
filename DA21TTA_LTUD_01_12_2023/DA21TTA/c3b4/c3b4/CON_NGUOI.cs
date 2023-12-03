using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c3b4
{
    class CON_NGUOI
    {// Thuộc tính (Properties)
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }

        // Phương thức ảo nhập thông tin
        public virtual void NhapThongTin()
        {
            Console.Write("Nhập Họ tên: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhập Tuổi: ");
            Tuoi = int.Parse(Console.ReadLine());

            Console.Write("Nhập Giới tính: ");
            GioiTinh = Console.ReadLine();

            Console.Write("Nhập Địa chỉ: ");
            DiaChi = Console.ReadLine();
        }

        // Phương thức ảo xuất thông tin
        public virtual void XuatThongTin()
        {
            Console.WriteLine($"Họ tên: {HoTen}");
            Console.WriteLine($"Tuổi: {Tuoi}");
            Console.WriteLine($"Giới tính: {GioiTinh}");
            Console.WriteLine($"Địa chỉ: {DiaChi}");
        }

        // Phương thức ảo tính toán
        public virtual void TinhToan()
        {
            // Phương thức này có thể được mở rộng trong các lớp con
            //Console.WriteLine("Đây là phương thức tính toán của lớp cha.");
        }
    }
}
