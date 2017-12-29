using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop27_Class
{
   class Animal
    {
        //clase variables
        string name="Pikachu";
        int age=9;
        float happines = 5.9f;
        //class constructor
        public Animal()
        {
            string name = "Spotty";
            int age = 22;
            float happines = 0.5f;
        }
        public Animal(string name, int age, float happines)
        {
            this.name = name;
            this.age = age;
            this.happines = happines;
        }
        //class methods
        public void Print()
        {
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Hapines: " + happines);
        }
        public int Count = 9;
        public void Print2()
        {
            Console.WriteLine("This is method Print2");
        }
        public static void Print3()
        {
            Console.WriteLine("This is method Print2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal();
            dog.Print();// neu ham khong public thi goi lai o day khong duoc           
            Console.WriteLine(dog.Count+1);// kq: 10
            dog.Print2();
           //dog.Print3();// Error: because: static not goi lai dc.

            Animal cat = new Animal();
            cat.Print();
            

            Animal Mounse = new Animal("Jerry",8,0.8f);
            Mounse.Print();
            Console.ReadKey();
            /*
             * Result:
             * Name: Pikachu
                Age: 9
                Hapines: 5.9
                10
                This is method Print2
                Name: Pikachu
                Age: 9
                Hapines: 5.9
                Name: Jerry
                Age: 8
                Hapines: 0.8
             */
        }
    }
}
