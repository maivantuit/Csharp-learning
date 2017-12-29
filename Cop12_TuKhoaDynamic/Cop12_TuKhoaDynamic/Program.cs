using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop12_TuKhoaDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region từ khóa dynamic
            //Khai báo biến StringVal kiểu dynamic tạo giá trị là một chuổi kiểu string
            dynamic StringVal = "HelloCop";
            //StringVal++; 
            //object StringVal = "HelloCop";// error: 
            //StringVal++;
            //Kiểu dữ liệu string không thể ++ 2 cái trên, mà tool không báo lỗi, khi biên dịch mới phát hiện lỗi
            #endregion:
            #region từ khóa dynamic
            string Name = "Cop";
            string Mission = "Free Education";

            dynamic dynamicName = Name;
            Console.WriteLine("Mission of "+dynamicName + " is "+Mission);// Mission of Cop is Free Education
            Console.ReadKey();
            #endregion:
        }
    }
}
