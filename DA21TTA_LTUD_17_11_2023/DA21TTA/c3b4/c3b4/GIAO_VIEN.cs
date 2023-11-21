using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c3b4
{
    class GIAO_VIEN : CON_NGUOI
    {
        // Thêm thuộc tính mới cho lớp GIAO_VIEN
        public string MaGiaoVien { get; set; }
        public double LuongCoBan { get; set; }
        public double PhuCap { get; set; }

        // Ghi đè phương thức nhập thông tin từ lớp cha
        public override void NhapThongTin()
        {
            base.NhapThongTin(); // Gọi phương thức của lớp cha để nhập thông tin chung

            Console.Write("Nhập Mã giáo viên: ");
            MaGiaoVien = Console.ReadLine();

            Console.Write("Nhập Lương cơ bản: ");
            LuongCoBan = double.Parse(Console.ReadLine());

            Console.Write("Nhập phụ cấp: ");
            PhuCap = int.Parse(Console.ReadLine());
        }

        // Ghi đè phương thức xuất thông tin từ lớp cha
        public override void XuatThongTin()
        {
            base.XuatThongTin(); // Gọi phương thức của lớp cha để xuất thông tin chung

            Console.WriteLine($"Mã giáo viên: {MaGiaoVien}");
            Console.WriteLine($"Lương cơ bản: {LuongCoBan}");
            Console.WriteLine($"Phụ cấp: {PhuCap}");
        }

        // Ghi đè phương thức tính toán từ lớp cha
        public override void TinhToan()
        {
            // Tính tổng lương dựa trên lương cơ bản và phụ cấp
            double tongLuong = LuongCoBan*650 + PhuCap;
            Console.WriteLine($"Tổng lương: {tongLuong}");
        }
    }
}
