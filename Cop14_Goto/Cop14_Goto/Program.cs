using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop14_Goto
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Goto:
            // vòng lặp không chính quy, không sử dụng nhiều.
            // goto: là tốc biến ^^
            //goto cop;
            //Console.WriteLine("Cop");
            //cop:
            //Console.WriteLine("Free Education");// kq: Free Education       
            #endregion:
            #region Ví dụ 1
            int a = 2;
            switch (a)
            {
                case 1: Console.WriteLine("Case 1"); break;
                case 2:
                    Console.WriteLine("Case 2");
                    goto case 1;
                    break;
                case 3: Console.WriteLine("Case 3"); break;
            }
            //kq 1: nếu a = 1 => case 1 được mở.
            //kq 2: nếu a = 2 => case 2 , case 1 được mở theo thứ tự, because có goto case 1;
            #endregion::
            #region Ví dụ 2:
            int a = 2;
            if (a == 2)
            {
                goto a_is_2;
            }
            Console.WriteLine("a == 1");
            a_is_2:
            Console.WriteLine("a == 2");
            kq 1: nếu a = 1, a== 1, a == 2
             kq 2: nếu a = 2, a== 2
            #endregion:
            #region: Ví dụ 3
            firstPoint:
            goto secondPoint;
            secondPoint:
            goto firstPoint;
            Console.ReadKey();
            ////kq : lặp
            #endregion::

        }
    }
}
