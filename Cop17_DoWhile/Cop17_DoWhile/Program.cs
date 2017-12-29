using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop17_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ví dụ 1: Nhập vào số n bất kỳ, in ra bang cuu chuong tuong ung
            //int n;
            //string strn;
            //int count = 1;

            //Console.Write("Nhap so bang cuu chuong can xem: ");
            //strn = Console.ReadLine();
            //n = int.Parse(strn);
            //if (n !=0)
            //{
            //    if (n >0 && n<=10)
            //    {
            //        do
            //        {
            //            int kq = n * count;
            //            Console.WriteLine("{0} * {1} = {2}", n, count, kq);
            //            count++;
            //        } while (count <= 10);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Khong in bang cuu chuong {0}",n);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Khong in bang cuu chuog {0}",n);
            //}
            //Console.ReadKey();
            #endregion:
            #region Ví dụ 2: in dãy số từ 1- > n
            int n;
            string strn;
            int count=1;

            Console.Write("Nhap so n: ");
            strn = Console.ReadLine();
            n = int.Parse(strn);
            do
            {
                if (n==0 && n<0)
                {
                    Console.WriteLine("Day so null");
                }
                else
                {
                    Console.WriteLine("{0}", count);
                }
                
                count++;// khong tang count lặp vô hạn
            } while (count<=n);
            Console.ReadKey();
            #endregion:
        }
    }
}
