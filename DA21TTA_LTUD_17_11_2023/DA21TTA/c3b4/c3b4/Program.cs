using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c3b4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("================================ Nhân viên kinh doanh ================================");
            // Tạo một đối tượng nhân viên kinh doanh
            NHAN_VIEN_KD nhanVienKD = new NHAN_VIEN_KD();

            // Gọi phương thức nhập thông tin từ lớp NHAN_VIEN_KD
            nhanVienKD.NhapThongTin();

            // Gọi phương thức xuất thông tin từ lớp NHAN_VIEN_KD
            Console.WriteLine("\nThông tin vừa nhập:");
            nhanVienKD.XuatThongTin();

            // Gọi phương thức tính toán từ lớp NHAN_VIEN_KD
            nhanVienKD.TinhToan();
            Console.WriteLine("================================ Giáo viên ===========================================");
            // Tạo một đối tượng giáo viên
            GIAO_VIEN giaoVien = new GIAO_VIEN();

            // Gọi phương thức nhập thông tin từ lớp GIAO_VIEN
            giaoVien.NhapThongTin();

            // Gọi phương thức xuất thông tin từ lớp GIAO_VIEN
            Console.WriteLine("\nThông tin vừa nhập:");
            giaoVien.XuatThongTin();

            // Gọi phương thức tính toán từ lớp GIAO_VIEN
            giaoVien.TinhToan();
            Console.WriteLine(" ================================ Học sinh ===========================================");
            // Tạo một đối tượng học sinh
            HOC_SINH hocSinh = new HOC_SINH();

            // Gọi phương thức nhập thông tin từ lớp HOC_SINH
            hocSinh.NhapThongTin();

            // Gọi phương thức xuất thông tin từ lớp HOC_SINH
            Console.WriteLine("\nThông tin vừa nhập:");
            hocSinh.XuatThongTin();

            // Gọi phương thức tính toán từ lớp HOC_SINH
            hocSinh.TinhToan();
        }
    }
}
