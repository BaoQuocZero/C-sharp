using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c3b3
{
    class HINH_TRON
    {
        // Thuộc tính bán kính
        public double BanKinh { get; set; }

        public virtual void Nhap()
        {
            Console.WriteLine("Nhập bán kính:");
            BanKinh = double.Parse(Console.ReadLine());
        }

        // Phương thức ảo để tính diện tích hình tròn
        public virtual double TinhDienTich()
        {
            return Math.PI * BanKinh * BanKinh;
        }
    }
}
