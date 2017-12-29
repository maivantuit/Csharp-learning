using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop16_While
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ví dụ 1: Nhập vào 1 số n bất kỳ, in ra danh sách từ 1->n
            //int n;
            //string strn;
            //int count=1;

            //Console.Write("\nNhap n: ");
            //strn = Console.ReadLine();
            //n = int.Parse(strn);
            //Console.WriteLine("Day so tu 1 - > {0}: ",n);
            //while (count<=n)
            //{                
            //    Console.WriteLine(count);
            //    count++;
            //}
            //Console.ReadKey();
            #endregion:
            #region Ví dụ 2: Nhập vào 1 số n bất kỳ, in ra bảng cửu chương tương ứng.
            /*
             * 3 * 1 = 3 
             * 3 * 2 = 6 
             * 3 * 3 = 9
             * ..........
             * 3 * 10 = 30
             */
            int n;
            string strn;
            int count=1;

            Console.Write("Nhap bang cuu chuong can xem: ");
            strn = Console.ReadLine();
            n = int.Parse(strn);
            while(count<=10){
                int kq = n * count;
                Console.WriteLine(" {0} * {1} = {2}",n,count,kq);
                count++;
            }
            Console.ReadKey();
            #endregion:
        }
    }
}
