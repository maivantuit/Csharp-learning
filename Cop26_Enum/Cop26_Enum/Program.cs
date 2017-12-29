using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop26_Enum
{
    class Program
    {
        //khai bao enum,khai báo trong một namespace, trong class hoặc trong struct.
        enum Days {            
            Mon,
            tue,
            Wed,
            thu,
            Fri,
            Sat,
            Sun
        };
        // ve ban cha cac gia tri enum Mon,Tue.. là các số nguyên được gán mác. Mon =0, Tue = 1, tăng dần 1 đơn vị 
        static void Main(string[] args)
        {
            //<kieudulieu> <tenbien> = (int)TenEnum.GiatriEnum
            int WeekdayStart = (int)Days.Mon;
            int WeekdayEnd = (int)Days.Sun;
            Console.WriteLine("Monday: {0}", WeekdayStart);//0
            Console.WriteLine("Sunday: {0}", WeekdayEnd);//6
            Console.ReadKey();
        }
    }
}
