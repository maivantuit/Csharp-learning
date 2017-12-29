using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop29_Class4
{
    
    class Program
    {
        static void Plus(ref int b)
        {
            b=b+1;// a++
        }
        static void Main(string[] args)
        {
            int a = 0;
            Plus(ref a);
            Console.WriteLine(a);// kq: 0 .Vì cách truyền tham số trên là tham trị
            /*Ban đầu biến a= 0(địa chỉ 100 trên stack). Khi gọi hàm Plus(b), nó sẽ tạo thêm một
             * bản sao khác ở địa địa chỉ khác (b ở địa chỉ 200) và sau khi +1 cho bản sao b nó
             * sẽ bị hủy đi khi thoát khỏi hàm Plus. a và b có 2 địa chỉ khác nhau.
             * Giá trị gốc vẫn = 0!!!
             * 
             */ 
            Console.ReadKey();
        }
    }
}
