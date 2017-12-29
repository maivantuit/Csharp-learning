using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop42_Polymorphism
{
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal is speaking...");
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat is speaking...");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog is speaking...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            cat1.Speak();// kq nó lấy methods của Cat

            Animal cat2 = new Cat();
            cat2.Speak();// kq nó lấy methods của Animal(), vì chưa override.

            Animal dog1 = new Dog();
            dog1.Speak();
            /*
             * Result 1: 
             * Cat is speaking...
                Animal is speaking...// bởi vì tự nhiên 1 con animal trở thành con cat, chúng ta chưa override
                Animal is speaking...// bởi vì tự nhiên 1 con animal trở thành con dog, chúng ta chưa override
             */
            // Trên chỉ là thể hiện tính thừa kế. Để thể hiện tính đa hình thì ta khai báo các phương thức con là override, còn methods of cha là virtual
            /*
             * Result 2:
             * Cat is speaking...
                Cat is speaking...
                Dog is speaking...               
             */
            Console.ReadLine();
            /*Ta thấy 2 đối tượng dog, cat được cấp phát 2 vùng nhớ thuộc 2 lớp khác nhau nhưng
             * khi cùng gọi phương thức Speak() thì đối tượng tham chiếu đến vùng nhớ của lớp nào sẽ được gọi đúng methods của lớp đó
             * Nghĩa là: Nhờ 2 đối tượng virtual và override nó đi đúng đối tượng tham chiếu.
             */

            /*
             * Class Animal
             *  + virtual void speak()
             * Class Cat : Animal
             *  + override void speak()
             * Class Dog : Animal
             *  + override void speak()             
             */
        }
    }
}
