using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Namespace Cop41_Inheritance
     * Class Nguoi
     * Class NhanVien: Nguoi
     *  - private int soNhanVien
     *  + NhanVien(){}
     *  + NhanVien(int soNhanVien, int Maso, string HoTen){}
     *  + void show(){}
     * Class KhachHang: Nguoi
     * - private int soKhachHang
     * + KhachHang(){}
     * + KhachHang(int soKhachHang, int Maso, string HoTen){}
     * + void show(){}
     * Class QuanTriVien : Nguoi
     * - private int soQuanLy
     * + QuanTriVien(){}
     * + QuanTriVien(int soQuanTriVien, int MaSo, string HoTen){}
     * +  void show(){}
     * 
 *  
 */
namespace Cop41_Inheritance
{
    class Nguoi
    {
        protected int MaSo;
        protected string HoTen;
        public Nguoi()
        {

        }
        public Nguoi(int MaSo, string HoTen)
        {
            this.MaSo = MaSo;
            this.HoTen = HoTen;
        }
        public void show()
        {
            Console.WriteLine("This is methods of Nguoi");
        }
    }
    class KhachHang : Nguoi
    {
        private int soKhachHang;
        public KhachHang()
        {

        }
        public KhachHang(int soKhachHang, int MaSo, string HoTen) : base(MaSo, HoTen)
        {

        }
        public void show()
        {
            soKhachHang = 1;
            Console.WriteLine("Số khách hàng: " + soKhachHang);
            Console.WriteLine("This is methods of KhachHang");
        }
    }
    class QuanTriVien : Nguoi
    {
        private int soQuanLy;
        public QuanTriVien()
        {

        }
        public QuanTriVien(int soQuanLy, int MaSo, string HoTen) : base(MaSo, HoTen)
        {

        }
        public  void show()
        {
            soQuanLy = 2;
            Console.WriteLine("Số quản trị viên: " + soQuanLy);
            Console.WriteLine("This is methods of QuanTriVien");
        }
    }
    class NhanVien : Nguoi
    {
        private int soNhanVien;
        public NhanVien()
        {

        }
        public NhanVien(int MaSo, string HoTen, int soNhanVien) : base(MaSo, HoTen)
        {

        }
        public void show()
        {
            soNhanVien = 3;
            Console.WriteLine("Số nhân viên: " + soNhanVien);
            Console.WriteLine("This is methods of NhanVien");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            KhachHang kh1 = new KhachHang();
            kh1.show();
            QuanTriVien qtv1 = new QuanTriVien();
            qtv1.show();
            NhanVien nv1 = new NhanVien();
            nv1.show();
            Nguoi n1 = new QuanTriVien();
            n1.show();
            Console.ReadKey();
        }
        // Error: La do chua xoa cac class tab :)))
        /*
S? khách hàng: 1
This is methods of KhachHang
S? qu?n tr? viên: 2
This is methods of QuanTriVien
S? nhân viên: 3
This is methods of NhanVien
This is methods of Nguoi

         */
    }
}
