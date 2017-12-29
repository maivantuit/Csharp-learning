using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop21_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            int n;
            Console.Write("Nhap so phan tu: ");
            n = int.Parse(Console.ReadLine());
            // nhập
            for (int i = 0; i < n; i++)
            {
                Console.Write("\nNhap phan tu thu {0}: ",i);
                array[i] = int.Parse(Console.ReadLine());
            }
            // xuất
            Console.WriteLine("\n Mang vua nhap la: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}