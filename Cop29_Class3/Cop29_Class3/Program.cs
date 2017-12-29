using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Cop29_Class3
{
    class HinhChuNhat{
        // class varibles
        double chieuDai;
        double chieuRong;
        // class contructor
        public HinhChuNhat()
        {

        }
        public HinhChuNhat(double _chieuDai, double _chieuRong)
        {
            this.chieuDai = _chieuDai;// this.chieuDai : truong thuoc tinh, _chieuDai : tham so truyen vao
            this.chieuRong = _chieuRong;
        }
        public HinhChuNhat(HinhChuNhat hcm)
        {
            this.chieuDai = hcm.chieuDai;
            this.chieuRong = hcm.chieuRong;
        } 
        // class methods
        public void Nhap()
        {
            Console.WriteLine("\nNhap chieu dai: ");
            chieuDai = double.Parse(Console.ReadLine());
            Console.WriteLine("\nNhap chieu rong: ");
            chieuRong = double.Parse(Console.ReadLine());
        }
        public double TinhDienTichHCN()
        {
            return chieuDai * chieuRong;
        }
        public void Xuat()
        {
            Console.WriteLine("Dien tich HCN: "+TinhDienTichHCN());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HinhChuNhat hcn1 = new HinhChuNhat(5,3);
            Console.WriteLine(hcn1);// result:  Cop29_Class3.HinhChuNhat
            //HinhChuNhat hcn2 = new HinhChuNhat(hcn1);
            HinhChuNhat hcn2 = hcn1;
            // bai ve con tro trong c#   
            HinhChuNhat hcn3 = new HinhChuNhat();
            hcn3.Nhap();
            hcn3.TinhDienTichHCN();
            hcn3.Xuat();            
        }
    }
}
