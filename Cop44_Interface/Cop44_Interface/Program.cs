using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Cop44_Interface
{
    public interface IHinh
    {    
         int TinhDienTich();
       
    }
    public class HinhChuNhat : IHinh
    {
        private int chieuDai;
        private int chieuRong;
        public HinhChuNhat(int cd, int cr)
        {
            this.chieuDai = cd;
            this.chieuRong = cr;
        }
        public int TinhDienTich()
        {
            return chieuDai * chieuRong;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //IHinh h1 = new IHinh();//khong the new doi tuong la 1 interface, giong abstract class
            IHinh hcn1 = new HinhChuNhat(6,7);// day chinh tinh da hinh
            // constructor phải là public mới pass agruments được
            double result = hcn1.TinhDienTich();
            Console.WriteLine("Dien tich hinh chu nhat la: " + result); //42
            HinhChuNhat hcn2 = new HinhChuNhat(6,8);
            double result2 = hcn2.TinhDienTich();
            Console.WriteLine("Dien tich hinh chu nhat la: "+result2);//48

            Console.ReadLine();
        }
    }
}
