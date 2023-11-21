using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c3b1
{
    class PhanSo
    {
        private int tuSo;
        private int mauSo;

        public int TuSo
        {
            get { return tuSo; }
            set { tuSo = value; }
        }

        public int MauSo
        {
            get { return mauSo; }
            set
            {
                if (value != 0)
                {
                    mauSo = value;
                }
                else
                {
                    throw new ArgumentException("Mẫu số phải khác 0.");
                }
            }
        }

        // Phương thức nhập phân số
        public void NhapPhanSo()
        {
            Console.Write("Nhập tử số: ");
            TuSo = int.Parse(Console.ReadLine());

            Console.Write("Nhập mẫu số: ");
            MauSo = int.Parse(Console.ReadLine());
        }

        // Phương thức xuất phân số
        public void XuatPhanSo()
        {
            Console.WriteLine($"{TuSo}/{MauSo}");
        }

        // Phương thức tính tổng hai phân số
        public PhanSo Cong(PhanSo ps)
        {
            PhanSo ketQua = new PhanSo();
            ketQua.TuSo = TuSo * ps.MauSo + ps.TuSo * MauSo;
            ketQua.MauSo = MauSo * ps.MauSo;
            return ketQua;
        }

        // Phương thức tính hiệu hai phân số
        public PhanSo Tru(PhanSo ps)
        {
            PhanSo ketQua = new PhanSo();
            ketQua.TuSo = TuSo * ps.MauSo - ps.TuSo * MauSo;
            ketQua.MauSo = MauSo * ps.MauSo;
            return ketQua;
        }

        // Phương thức tính tích hai phân số
        public PhanSo Nhan(PhanSo ps)
        {
            PhanSo ketQua = new PhanSo();
            ketQua.TuSo = TuSo * ps.TuSo;
            ketQua.MauSo = MauSo * ps.MauSo;
            return ketQua;
        }

        // Phương thức tính thương hai phân số
        public PhanSo Chia(PhanSo ps)
        {
            PhanSo ketQua = new PhanSo();
            ketQua.TuSo = TuSo * ps.MauSo;
            ketQua.MauSo = MauSo * ps.TuSo;
            return ketQua;
        }
    }
}
