using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitapso1chuong3part1
{
    internal class Phanso
    {
        private int tuso;
        private int mauso;
        public Phanso()
        {
            tuso = 0;
            mauso = 1;
        }
        public Phanso(int tu, int mau)
        {
            tuso = tu;
            mauso = mau == 0 ? 1 : mau;
        }
        public int Tuso
        {
            get { return tuso; }
            set { tuso = value; }
        }
        public int Muso
        {
            get { return mauso; }
            set { mauso = value; }
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap tu so: ");
            tuso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap mau so: ");
            mauso = Convert.ToInt32(Console.ReadLine());
        }
        public void Xuat(int tuso, int mauso)
        {
            Console.WriteLine(" {0}/{1} ", tuso, mauso);
        }
        public void UCLN(int a, int b)
        {
            int r = 1;
            while (r != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        public void RutGon()
        {
            int uc = UCLN(tuso, mauso);
            tuso = tuso / uc;
            mauso = mauso / uc;
        }
        public Phanso CongPhanSo(Phanso a, Phanso b)
        {
            Phanso ketqua = new Phanso();
            ketqua.tuso = b.tuso * a.mauso + b.mauso * a.tuso;
            ketqua.mauso = a.mauso * b.mauso;
            ketqua.RutGon();
            return ketqua;
        }
        public Phanso TruPhanSo(Phanso a, Phanso b)

        {
            Phanso ketqua = new Phanso();
            ketqua.tuso = b.mauso * a.tuso - b.tuso * a.mauso;
            ketqua.mauso = a.mauso * b.mauso;
            ketqua.RutGon();
            return ketqua;
        }
        public Phanso NhanPhanSo(Phanso a, Phanso b)

        {
            Phanso ketqua = new Phanso();
            ketqua.tuso = a.tuso * b.tuso;
            ketqua.mauso = a.mauso * b.mauso;
            ketqua.RutGon();
            return ketqua;
        }

        public Phanso ChiaPhanSo(Phanso a, Phanso b)

        {
            Phanso ketqua = new Phanso();
            ketqua.tuso = b.mauso * a.tuso;
            ketqua.mauso = a.mauso * b.tuso;
            ketqua.RutGon();

            return ketqua;
        }
    }
}
