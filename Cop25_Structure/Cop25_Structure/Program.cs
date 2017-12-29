using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop25_Structure
{
    class Program
    {
        struct SinhVien
        {
            public int maSo;
            public string hoTen;
            public double diemToan;
            public double diemLy;
            public double diemHoa;
        };
        static void Nhap(out SinhVien SV)
        {
            Console.Write("\n Nhap ma so sinh vien: ");
            SV.maSo = int.Parse(Console.ReadLine());
            Console.Write("\n Nhap ho ten sinh vien: ");
            SV.hoTen = Console.ReadLine();
            Console.Write("\n Nhap diem toan: ");
            SV.diemToan = double.Parse(Console.ReadLine());
            Console.Write("\n Nhap diem ly: ");
            SV.diemLy = double.Parse(Console.ReadLine());
            Console.Write("\n Nhap diem hoa: ");
            SV.diemHoa = double.Parse(Console.ReadLine());
        }        
        static double DiemTrungBinh(SinhVien SV)
        {
            return (SV.diemToan+SV.diemLy+SV.diemHoa)/3;
        }
        static void Xuat(SinhVien SV)
        {
            Console.Write("{0}      {1}       {2}          {3}            {4}            {5}", SV.maSo, SV.hoTen, SV.diemToan, SV.diemLy, SV.diemHoa, DiemTrungBinh(SV));
        }
        static void Main(string[] args)
        {
            SinhVien sv1 = new SinhVien();
            Nhap(out sv1);
            Xuat(sv1);
            DiemTrungBinh(sv1);
            Console.WriteLine();
        }
    }
}
