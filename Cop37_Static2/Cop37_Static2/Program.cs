using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop37_Static2
{
    static class TienIch
    {
        public static int TongHaiSo(int a, int b)//tham so, parapater
        {
            return a + b;
        }  
        public void Nhap()// Error: Methods not-static khong dc tao trong class static
        {
            Console.WriteLine("\nNhap a: ");
            //do something
        }
        static void Main(string[] args)
        {
            int result =TienIch.TongHaiSo(4,5);// 9
            Console.WriteLine(result);
            //TienIch ti = new TienIch(); //Error: Khong the khoi tao doi tuong, voi class la static

            
        }
    }
}
