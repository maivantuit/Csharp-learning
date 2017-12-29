using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop10_For
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "Hello Cop";
            /*Object có 4 phương thức sau nó.
             * 1. ToString
             * 2. GetType
             * 3. GetHashCode
             * 4. Equals
             * cú pháp: obj.methodobject
             */

            /* Dùng Object dùng để Boxing: Chuyển từ kiểu dữ liệu giá trị sang kiểu dữ liệu tham chiếu
             * Un-Boxing: ngược lại
             *
             * 
             */
            int value = 109;
            object objVal = value;// boxing
            
            //Console.WriteLine(objVal+1); // không cộng 1 ojb với 1 int được
            int newvalue = (int)objVal;//un-boxing
            Console.ReadKey();
        }
    }
}
