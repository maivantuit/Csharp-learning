using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Cop23_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * forech(<kieudulieu> <tenbientam> in <ten mang hoac tap hop>){
             * //code xu ly
             * }
             * 
             */
            #region Ví dụ 1
            int[] array = { 3, 9, 10, 3, 5, 15, 3 };
            int sum=0;
            foreach (var x in array)
            {
                if (x %2 ==0)
                {
                    sum = sum + x;
                }                
                Console.WriteLine(x);
            }
            Console.WriteLine("Tong cac so chan trong danh sach: "+sum);
            Console.ReadKey();
            #endregion
        }
    }
}