using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop15_For
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ví dụ 1: Nhập 1 số n bất kì, in ra từ 1-> n
            //int a;
            //string stra;

            //Console.Write("\nNhap so a: ");
            //stra = Console.ReadLine();
            //a = int.Parse(stra);
            //for (int i=1; i<= a;i++)
            //{
            //    Console.WriteLine("Day tu 1- >10: "+i);                
            //}
            //Console.ReadKey();
            #endregion:
            #region Ví dụ 2: Nhập 1 số từ bàn phím, In ra bảng cửu chương tương ứng số đó. 
            /*
             * 2*1=2
             * 2*2=4
             * 2*3=6
             * .....
             * 2*10=20
             * n=2.
             */
            //int n;
            //string strn;
            //Console.Write("\nBan muon in bang cuu chuong: ");
            //strn = Console.ReadLine();
            //n = int.Parse(strn);
            //for (int i=1; i<=10;i++)
            //{
            //    int kq = n * i;
            //    Console.WriteLine("\n{0} * {1} = {2}",n,i,kq);
            //}
            //Console.ReadKey();

            #endregion
            #region Ví dụ 3 In ra ma trận với hàng, cột nhập vào từ bàn phím
            int h;
            int c;
            string strh;
            string strc;
            Console.WriteLine("\nMoi ban nhap so hang: ");
            strh = Console.ReadLine();
            h = int.Parse(strh);
            Console.WriteLine("\nMoi ban nhap so cot: ");
            strc = Console.ReadLine();
            c = int.Parse(strc);
            /*
             * 1 2 6 9
             * 3 5 9 8
             * 3 1 9 7
             * 
             */
            // nhập
            for (int i=1; i<=h;i++)
            {
                for (int j=1; j<=c;j++)
                {
                    int n;
                    string strn;
                    Console.WriteLine("\nNhap phan tu thu [{0} {1}]",i,j);
                    strn = Console.ReadLine();
                    n = int.Parse(strn);
                }
            }
            // in ra, lấy độ dài từ mảng. chưa học tiếp tục sau.

            #endregion:
        }
    }
}
