using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c3b3
{
    class HINH_TRU_TRON : HINH_TRON
    {
        // Thuộc tính bán kính
        public double ChieuCao { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhập chiều cao:");
            ChieuCao = double.Parse(Console.ReadLine());
        }

        // Phương thức ảo để tính diện tích hình tròn
        public override double TinhDienTich()
        {
            if (ChieuCao > 0)
            {
                double ketqua = base.TinhDienTich() * ChieuCao;
                Console.WriteLine($"Diện tích hình trụ tròn: {ketqua}");
                return 1;
            }
            else
            {
                double ketqua = base.TinhDienTich();
                Console.WriteLine($"Diện tích hình tròn: {ketqua}");
                return 0;
            }
        }
    }
}
