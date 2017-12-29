using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop31_OverLoading
{
    class Tutorial
    {
        public static float sum(float x, float y)
        {
            
        }
    }
    class Program
    {
        public static int sum(int x, int y)
        {
            int add = x + y;
            return add;
        }
        public static double sum(double x, double y)
        {
            double add = x + y;
            return add;
        }
        public static double sum(double x, double y,double z)
        {
            double add = x + y+z;
            return add;
        }
        public static string sum(string x, string y)
        {
            string add = x + y;
            return add;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of two ints is {0}",sum(10,10));
            Console.WriteLine("Sum of two doubles is {0}", sum(8.4, 9.9));
            Console.WriteLine("Sum of two doubles is {0}", sum(8.4, 9.9,10.0));
            Console.WriteLine("Sum of two strings is {0}", sum("C# ","Programing"));
            Console.ReadKey();
            /*
             * Result:
             * Sum of two ints is 20
                Sum of two doubles is 18.3
                Sum of two doubles is 28.3
                Sum of two strings is C# Programing
             */
        }
    }
}
