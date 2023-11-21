using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c3b4
{
    class HOC_SINH : CON_NGUOI
    {
        // Thêm thuộc tính mới cho lớp GIAO_VIEN
        public string MaSo { get; set; }
        public string Lop { get; set; }
        public double Toan { get; set; }
        public double Ly { get; set; }
        public double Hoa { get; set; }

        // Ghi đè phương thức nhập thông tin từ lớp cha
        public override void NhapThongTin()
        {
            base.NhapThongTin(); // Gọi phương thức của lớp cha để nhập thông tin chung

            Console.Write("Mã học sinh: ");
            MaSo = Console.ReadLine();

            Console.Write("Mã lớp: ");
            Lop = Console.ReadLine();

            Console.Write("Điểm toán: ");
            Toan = double.Parse(Console.ReadLine());

            Console.Write("Điểm lý: ");
            Ly = int.Parse(Console.ReadLine());

            Console.Write("Điểm hóa: ");
            Hoa = int.Parse(Console.ReadLine());
        }

        // Ghi đè phương thức xuất thông tin từ lớp cha
        public override void XuatThongTin()
        {
            base.XuatThongTin(); // Gọi phương thức của lớp cha để xuất thông tin chung

            Console.WriteLine($"Mã học sinh: {MaSo}");
            Console.WriteLine($"Mã lớp: {Lop}");
            Console.WriteLine($"Điểm toán: {Toan}");
            Console.WriteLine($"Điểm lý: {Toan}");
            Console.WriteLine($"Điểm hóa: {Toan}");
        }

        // Ghi đè phương thức tính toán từ lớp cha
        public override void TinhToan()
        {
            // Tính điểm trung bình
            double ketqua = (Toan*2 + Ly + Hoa)/4;
            Console.WriteLine($"Điểm trung bình: {ketqua}");
        }
    }
}
