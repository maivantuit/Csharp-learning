using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop47_Exception2
{
    public class MyException : Exception
    {
        public MyException(string message) : base (message)
        {

        }
    }
    public class Temperature
    {
        int temp = 0;
        public void showTemp()
        {
            if (temp ==0)
            {
                throw (new MyException("Error: Zero temperature found"));
            }
            else
            {
                Console.WriteLine("Temp: "+temp);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            try
            {
                temp.showTemp();
            }
            catch (MyException e)
            {

                Console.WriteLine("TempZeroException: {0} "+e.Message);
            }
            // TempZeroException: {0} Error: Zero temperature found
            Console.ReadLine();
        }
        
    }
}

/*
 * class Temperature
 *  - int temp =0;
 *  + void showTemp(){}
 * class MyException : Exception
 *  + MyException(string message): base (message){}
 */
