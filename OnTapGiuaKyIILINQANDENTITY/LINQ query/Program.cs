using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_query
{    
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 3,8,19,5,100,15,76,39,19,1,19};
            Console.WriteLine("---Danh sach ca so: ");
            foreach (int item in list)
            {
                Console.Write(" "+item);
            }
            Console.WriteLine();
            // Question: Tìm các số chia hết cho 2:

            //cách 1:
            Console.WriteLine("---Danh sach ca so chia het cho 2: ");
            foreach (int item in list)
            {
                if (item % 2 ==0)
                {
                    Console.Write(" "+item);
                }
            }
            Console.WriteLine();
            // cách 2: use linq:
            var kq1 = from so in list // so: tự đặt ở đây, ngẫu nhiêu.
                      where so % 2 == 0
                      select so;
            Console.WriteLine("---Danh sach ca so chia het cho 2:(use linq) ");
            foreach (int item in kq1)
            {
                Console.Write(" "+item);
            }
            Console.ReadLine();
        }
    }
}
/*
Result:
---Danh sach ca so:
 3 8 19 5 100 15 76 39 19 1 19
---Danh sach ca so chia het cho 2:
 8 100 76
---Danh sach ca so chia het cho 2:(use linq)
 8 100 76

*/
