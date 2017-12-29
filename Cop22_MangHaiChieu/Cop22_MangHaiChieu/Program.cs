using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop22_MangHaiChieu
{
    class Program
    {
        static void Main(string[] args)
        {            
            int h,c;
            //Nhap so phan tu trong mang.
            Console.WriteLine("\nNhap so hang: ");
            h = int.Parse(Console.ReadLine());// xữ lý lỗi khi nhập sai, tách ra, nhập zô.
            Console.WriteLine("\nNhap so cot: ");
            c = int.Parse(Console.ReadLine());
            //Khai báo mảng
            int[,] array2c = new int[h, c];
            //Nhap gia tri tung phan tu.
            for (int i = 0; i < array2c.GetLength(0); i++)
            {
                for (int j = 0; j < array2c.GetLength(1); j++)
                {
                    Console.Write("Nhap phan tu thu array2c[{0},{1}]: ",i+1,j+1);
                    array2c[i,j] = int.Parse(Console.ReadLine());
                }
            }
            // xuất 
            Console.WriteLine("\nMang vua nhap : ");
            for (int i = 0; i < array2c.GetLength(0); i++)
            {
                for (int j = 0; j < array2c.GetLength(1); j++)
                {
                    Console.Write(array2c[i,j] + " ");
                }
                Console.WriteLine();// xuống 1 dòng
            }
            Console.ReadKey();
           
        }
    }
}
