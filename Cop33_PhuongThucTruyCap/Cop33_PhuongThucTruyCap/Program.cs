using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop33_PhuongThucTruyCap
{
    class SinhVien
    {
        private string maSV;
        private string hoTen;
        private double diemToan;
        private double diemLy;
        private double diemHoa;// ctrl + R + E // visual studio 2012, if > Ctrl + Alt + .
        
        public double DiemLy
        {
            get
            {
                return diemLy;
            }
            set
            {
                // set: kiem tra diem ly co thoa man hay khong neu co the thuc hien gan vao thuoc tin private. Neu khong se khong lam gi ca. Dieu nay nham dam bao tinh dung dan cua du lieu
                if (value <=10 || value>=0)
                {
                    diemLy = value;// value la gia tri duoc truyen vao. vi du truyen vao diem LY la 5diem thi value la 5
                }
            }
        }
        //press: ctrl + R + E
        public double DiemToan {
            get => DiemToan;
            set => DiemToan = value;
        }
        public double DiemHoa { get => diemHoa; set => diemHoa = value; }
        // this is method truy van gia tri cua maSV. Vi the methods sẽ tra ve string (trung voi kieu du lieu của thuoc tinh maSV)
        // co the viet cac method get set nhu the nay, nhung su dung cai tren la oke nhat. khoi mat cong viet lai. day la tim hieu cho biet
        public string getMaSV()
        {
            return maSV;
        }
        // this is method cap nhat gia tri cho thuoc tinh diemToan
        // Vi the method co 1 tham so truyen vao kieu double trung voi kieu cua thuoc tinh diemToan
        public void setDiemToan(double diemtoan)
        {
            diemToan = diemtoan;
        }
        public void Nhap()
        {
            Console.WriteLine("\nNhap ma sv: ");
            maSV = Console.ReadLine();
            Console.WriteLine("\nNhap ho ten sv: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("\nNhap diem toan: ");
            diemToan = double.Parse(Console.ReadLine());
            Console.WriteLine("\nNhap diem ly: ");
            diemLy = double.Parse(Console.ReadLine());
            Console.WriteLine("\nNhap diem hoa: ");
            diemHoa = double.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            double dtb = (diemToan + diemHoa + diemLy) / 3;
            Console.WriteLine("{0}         {1}          {2}         {3}         {4}         {5}", maSV, hoTen, diemToan, diemLy, diemHoa, dtb);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv1 = new SinhVien();
            sv1.Nhap();
            sv1.Xuat();
            sv1.getMaSV();
            Console.WriteLine("Get ra gia tri cua ma sinh vien: "+sv1.getMaSV());// de truy xuat du lieu ma khac class, thuoc tinh la private
            Console.ReadKey();
        }
    }
}
