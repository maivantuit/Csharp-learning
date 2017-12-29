using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop33_MethodOverloading
{
    class HinhChuNhat
    {
        int chieuDai;
        int chieuRong;
        //class constructor
        public HinhChuNhat()
        {

        }
        public HinhChuNhat(int chieuDai, int chieuRong)
        {
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
        }        
        public HinhChuNhat(HinhChuNhat hcn)
        {
            this.chieuDai = hcn.chieuDai;
            this.chieuRong = hcn.chieuRong;
        }
        // get set
        public int ChieuDai
        {
            get
            {
                return chieuDai;
            }
            set
            {
                chieuDai = value;
            }
        }
        public int ChieuRong
        {
            get
            {
                return chieuRong;
            }
            set
            {
                chieuRong = value;
            }
        }
        public int TinhDienTich()
        {
            return chieuDai * chieuRong;
        }       
    }
    public class HinhVuong
    {
        int canh;
        public HinhVuong()
        {

        }
        public HinhVuong(int canh)
        {
            this.canh = canh;
        }
        public int TinhDienTich()
        {
            return canh * canh;
        }
    }
    class Program
    {        
        static void Main(string[] args)
        {
            HinhChuNhat hcn1 = new HinhChuNhat();
            HinhChuNhat hcn2 = new HinhChuNhat(7,8);
            //HinhChuNhat hcn3 = new HinhChuNhat(hcn2); // Error: vi tham so truyen vao la 2 kieu du lieu int, de khong loi thi constructor 1 tham so, HinhChuNhat hcn <tendulieu> <tenbien>
            HinhChuNhat hcn3 = new HinhChuNhat(hcn2);
            int result = hcn2.TinhDienTich();
            Console.WriteLine(result);//56

            HinhVuong hv1 = new HinhVuong(3);
            int result2 =hv1.TinhDienTich();
            Console.WriteLine(result2);//9

            Console.ReadKey();
            
            //Overloading qua tai o day la: co 2 HinhChuNhat (+2 overloads)
        }
    }
}
