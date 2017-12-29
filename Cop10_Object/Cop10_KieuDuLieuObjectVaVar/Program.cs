using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop10_KieuDuLieuObjectVaVar
{
    class Program
    {
        static void Main(string[] args)
        {
            var varInt=true;
            // var không phải kiểu dữ liệu, dùng trong duyệt mảng for - each.
            var varString = "Hello Cop";
            string content = "HelloCop.com";
            Console.WriteLine(varString); //Kq: Hello Cop
            Console.WriteLine(content);//kq: HelloCop.com

            Console.ReadKey();
        }
    }
}
