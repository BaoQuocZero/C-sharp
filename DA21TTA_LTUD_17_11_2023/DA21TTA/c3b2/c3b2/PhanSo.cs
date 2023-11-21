using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c3b2
{
    class PhanSo
    {
        private double tuso;
        private double mauso;

        public double Tuso
        {
            get { return tuso; }
            set { tuso = value; }
        }

        public double Mauso
        {
            get { return mauso; }
            set
            {
                if (value != 0)
                {
                    mauso = value;
                }
                else
                {
                    throw new ArgumentException("Mẫu số phải khác 0.");
                }
            }
        }

        public void NhapPhanSo()
        {
            Console.Write("Nhập tử số: ");
            Tuso = double.Parse(Console.ReadLine());
            Console.Write("Nhập mẫu số: ");
            Mauso = double.Parse(Console.ReadLine());
        }

        private int TimUCLN(double a, double b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int temp = (int)b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        // Phương thức rút gọn phân số
        public void RutGon()
        {
            int ucln = TimUCLN(Tuso, Mauso);
            Tuso /= ucln;
            Mauso /= ucln;
        }

        public void XuatPhanSo()
        {
            Console.WriteLine($"{TuSo}/{MauSo}");
        }

        public static PhanSo operator +(PhanSo ps1, PhanSo ps2)
        {
            PhanSo ketQua = new PhanSo();
            ketQua.Tuso = ps1.Tuso * ps2.Mauso + ps2.Tuso * ps1.Mauso;
            ketQua.Mauso = ps1.Mauso * ps2.Mauso;
            return ketQua;
        }

        public static PhanSo operator -(PhanSo ps1, PhanSo ps2)
        {
            PhanSo ketQua = new PhanSo();
            ketQua.Tuso = ps1.Tuso * ps2.Mauso - ps2.Tuso * ps1.Mauso;
            ketQua.Mauso = ps1.Mauso * ps2.Mauso;
            return ketQua;
        }

        public static PhanSo operator *(PhanSo ps1, PhanSo ps2)
        {
            PhanSo ketQua = new PhanSo();
            ketQua.Tuso = ps1.Tuso * ps2.Tuso;
            ketQua.Mauso = ps1.Mauso * ps2.Mauso;
            return ketQua;
        }

        public static PhanSo operator /(PhanSo ps1, PhanSo ps2)
        {
            PhanSo ketQua = new PhanSo();
            ketQua.Tuso = ps1.Tuso * ps2.Mauso;
            ketQua.Mauso = ps1.Mauso * ps2.Tuso;
            return ketQua;
        }
    }
}