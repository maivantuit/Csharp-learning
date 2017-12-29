using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop6_Hang
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ví dụ 1: Biến gán với hằng, not
            const int x = 10;
            //Console.WriteLine(x); // kq :10
            //x = 15; // error: không thể gán giá trị với biến hằng mà không có const, nghĩa là 2 hằng mới gán được với nhau, cách khắc phục dưới
            #endregion:
            #region Ví dụ 2: Hằng gán với hằng.
            //const int a = 15;
            //const int b = a;
            //Console.WriteLine(b); // kq: 15
            #endregion:
            #region Ví dụ 3: Làm sao biến gán với hằng: readonly
            int a = 15;
            const int x = a; // error không thể gán hằng = biến và ngược lại.
            #endregion:
        }
    }
}
// hằng bao giờ cũng là static, nên readonly không được vào khai báo.