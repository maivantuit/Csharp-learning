using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop3_Bien
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            float b = 6.9f;
            string c = "Hello Cop - Mai Van Tu";
            bool d = true;
            char e = 'C';
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            // in ra từng giá trị của biến
            // Quy tắc đặt biến theo quy tắc lạc đà: hoTen, conCho, dongVat,
            // Thường dùng biến cho private, protected

            int a1 = 6;
            int a2 = 9;
            int kq = a1 + a2;
            Console.WriteLine("a1 + a2 = "+kq);// kq: a1 + a2 = 15
            Console.WriteLine("a1 + a2 = a3 : {0} + {1} = {2} ",a1,a2,kq); // kq a1 + a2 = a3 : 6 + 9 = 15          

            Console.ReadKey();
        }
    }
}
