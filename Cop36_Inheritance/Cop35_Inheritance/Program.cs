using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Cop35_Inheritance
{    
    
    class Hinh
    {
        protected int chieuDai;
        protected int chieuRong;     
        public Hinh()
        {

        }
        public void Nhap()
        {
            Console.WriteLine("\nNhap chieu rong: ");
            chieuRong = int.Parse(Console.ReadLine());
            Console.WriteLine("\nNhap chieu dai: ");
            chieuDai = int.Parse(Console.ReadLine());
        }
        public Hinh(int chieuDai, int chieuRong)
        {
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
        }
        
    }
    class HinhChuNhat : Hinh
    {
        public int TinhDienTich()
        {
            return chieuDai * chieuRong;
        }
        public HinhChuNhat()
        {

        }
        public void Xuat()
        {
            Console.WriteLine("\nDien tich hinh chu nhat: {0}",TinhDienTich());
        }
    }
    class HinhVuong : Hinh
    {
        private int a;
        private int b;
        public void Show()
        {
            Console.WriteLine("\nThis is method of HinhVuong");
        }
        public int Sum(int a, int b)// paraparter
        {
            return a + b;
        }
        public double Sum(double a, double b)
        {
            return a + b;
        }
        public double Sum(double a, double b, double c)
        {
            return a + b+ c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HinhChuNhat h1 = new HinhChuNhat();
            h1.Nhap();
            h1.TinhDienTich();
            h1.Xuat();
            HinhVuong hv1 = new HinhVuong();
            hv1.Show();
            Console.WriteLine(hv1.Sum(6, 6));// argrument,
            Console.WriteLine(hv1.Sum(6, 6,7));// argrument,
            Console.ReadKey();
        }
    }
}
