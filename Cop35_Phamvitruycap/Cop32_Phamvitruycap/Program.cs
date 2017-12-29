using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop32_Phamvitruycap
{
    // vi khong chi dinh tu khoa pham vi truy cap cu the nen class SinhVien co pham vi la internal
    class SinhVien
    {
        // cac thuoc tinh deu mang pham vi la private. Vi the chi duoc su dung noi bo trong class. Ra ben ngoai se khong truy cap duoc.
        private string maSV;
        private string hoTen;
        private double diemToan;
        private double diemVan;
        private double diemAnh;
        // Phuong thuc co pham vi truy cap la public nen co the su dung tu ben ngoai. Vi cac phuong thuc nay nam trong lop nen co the su dung cac thuoc tinh private
        public void Nhap()
        {
            Console.WriteLine("\nNhap ma sinh vien: ");
            maSV = Console.ReadLine();
            Console.WriteLine("\nNhap ho ten sinh vien: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("\nNhap diem toan: ");
            diemToan = double.Parse(Console.ReadLine());
            Console.WriteLine("\nNhap diem van: ");
            diemVan = double.Parse(Console.ReadLine());
            Console.WriteLine("\nNhap diem anh: ");
            diemAnh = double.Parse(Console.ReadLine());
        }
        public double TinhDienTrungBinh()
        {
            return (diemToan + diemVan + diemAnh) / 3;
        }
        public void Xuat()
        {
            Console.WriteLine("{0}         {1}          {2}         {3}         {4}         {5}", maSV,hoTen,diemToan,diemVan,diemAnh,TinhDienTrungBinh());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            SinhVien sv1 = new SinhVien();
            sv1.Nhap();
            sv1.TinhDienTrungBinh();
            sv1.Xuat();
            Console.ReadKey();
        }
    }
}
