using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c3b4
{
    class NHAN_VIEN_KD : CON_NGUOI
    {
        // Thêm thuộc tính mới cho lớp NHAN_VIEN_KD
        public string MaNhanVien { get; set; }
        public double LuongTrenNgay { get; set; }
        public int SoNgayCong { get; set; }

        // Ghi đè phương thức nhập thông tin từ lớp cha
        public override void NhapThongTin()
        {
            base.NhapThongTin(); // Gọi phương thức của lớp cha để nhập thông tin chung

            Console.Write("Nhập Mã nhân viên: ");
            MaNhanVien = Console.ReadLine();

            Console.Write("Nhập Lương trên ngày: ");
            LuongTrenNgay = double.Parse(Console.ReadLine());

            Console.Write("Nhập Số ngày công: ");
            SoNgayCong = int.Parse(Console.ReadLine());
        }

        // Ghi đè phương thức xuất thông tin từ lớp cha
        public override void XuatThongTin()
        {
            base.XuatThongTin(); // Gọi phương thức của lớp cha để xuất thông tin chung

            Console.WriteLine($"Mã nhân viên: {MaNhanVien}");
            Console.WriteLine($"Lương trên ngày: {LuongTrenNgay}");
            Console.WriteLine($"Số ngày công: {SoNgayCong}");
        }

        // Ghi đè phương thức tính toán từ lớp cha
        public override void TinhToan()
        {
            // Tính tổng lương dựa trên lương trên ngày và số ngày công
            double tongLuong = LuongTrenNgay * SoNgayCong;
            Console.WriteLine($"Tổng lương: {tongLuong}");
        }
    }
}
