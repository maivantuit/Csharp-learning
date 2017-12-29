using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop30_ThamChieu
{
    class Program
    {
        static void Plus(out int b)
        {
            b = 0; //out
            b++;
        }
        static void Main(string[] args)
        {
            int a = 0;// ref
            Plus(out a);
            Console.WriteLine(a); // result: 1.
            Console.ReadLine();
        }
    }
}
