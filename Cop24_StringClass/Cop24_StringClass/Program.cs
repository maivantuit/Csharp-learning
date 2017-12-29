using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop24_StringClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //chú ý trong method of string: tra ve kieu gi de khai bao bien phu hop

            string name = "Mai Van Tu";
            String name1 = "Mai Van Cop";
            string result;
            String result1;

            Console.WriteLine(name);// Mai Van Tu
            Console.WriteLine(name1);// Mai Van Cop

            result = name.Remove(4,3);
            result1 = name1.Remove(4, 3);
            Console.WriteLine(result);//Mai Tu
            Console.WriteLine(result1);//Mai Cop
            // su khac nhau giua string va String, cop chua tim ra.
            Console.ReadKey();//Lệnh này cho phép chúng ta nhìn kết quả một cách rõ ràng hơn.


        }
    }
}
 