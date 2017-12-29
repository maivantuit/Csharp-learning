using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop43_AbstractAndAbstractClass
{
 
   public abstract class Hinh
    {        
        public abstract double TinhDienTich();      
    }
    public class HinhChuNhat : Hinh
    {
        private int chieuRong;
        private int chieuDai;
        public HinhChuNhat(int cr, int cd)
        {
            this.chieuRong = cr;
            this.chieuDai = cd;
        }
        public override double TinhDienTich() // khi thừa kế phải có override methods lại, không là báo lỗi
        {            
            return chieuRong * chieuDai;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //SinhVien sv1 = new SinhVien();// Error: không thể khởi tạo đối tượng là 1 lớp abstract, vì là 1 lớp trừu tượng nên không có 1 đối tượng cụ thể. Con của nó thừa kế kia mới new đối tượng được
            // Khác với Java, class có thể thừa kế 1 abstract class. nhưng C# không thừa kế được ?(*) là do chưa khai báo override các phương thức đc ghi đè từ lớp cha
            HinhChuNhat hcn1 = new HinhChuNhat(9,5); // phải khai báo public ở constructor mới chèn agruments vào đc
            double result = hcn1.TinhDienTich();
            Console.WriteLine("Dien tich hinh chu nhat la: "+result);//Dien tich hinh chu nhat la: 45
            Console.ReadKey();                          
        }
    }
}
