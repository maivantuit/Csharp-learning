using System;

namespace OnTapGiuaKyIILINQANDENTITY
{

    class Program
    {
        static void Main(string[] args)
        {
            var namestudent = "Nguyen Van A";
            var x = 5;
            var intArray = new[] { 1, 2, 3, 4, 5 };// số double vẫn được nhưng duyệt mảng thì mảng chỉ chứa 1 type nhất định.
            var s = new { Name = "Mai Văn Tú", Adress = "106 Thanh Long" };
            Console.WriteLine(s.Name + " - " + s.Adress);
            Console.ReadLine();
        }
    }
}
/*
    1. Use var keywork để tạo 1 anonymous data type.
     
*/
