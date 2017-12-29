using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop28_Class2
{
    public class HinhChuNhat{
        double chieuDai;
        double chieuRong;
        public HinhChuNhat()
        {
        }
        public HinhChuNhat(double chieuDai, double chieuRong)
        {
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
        }
        public double TinhDienTich(double chieuDai, double chieuRong)
        {
            return chieuDai * chieuRong;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HinhChuNhat hcn1 = new HinhChuNhat();//1. nhu nay, 2. nhap tu ban phim phai co constructor khong doi so.
            HinhChuNhat hcn2 = new HinhChuNhat(7,8);// constructor 2 doi so            
            double dientichhcn=hcn1.TinhDienTich(6.7,8.9);//tham so truyen vao
            Console.WriteLine(dientichhcn);// result: 59.63
            Console.ReadKey();
        }
    }
}
