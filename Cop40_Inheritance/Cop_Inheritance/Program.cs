using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Cop_Inheritance
{
    class ThucVat
    {

    }
    class Animal
    {
        protected double Weight;
        protected double Height;
        protected static int Legs;
        public Animal()
        {

        }
        public Animal(double w, double h, int l)
        {
            this.Weight = w;
            this.Height = h;
            Legs = l;//this. không được, bởi vì static. chú ý
            
        }
        public void info()
        {
            Console.WriteLine("Thong tin cua animal: ");
            Console.WriteLine("Can nang: "+Weight+ "Chieu cao: "+Height + "So chan: "+Legs);
        }        
    }
    class Cat :Animal // thừa kế từ lớp Animal
    {
        public Cat()
        {
            /*Cat : Animal, các fields have access specifier is protected, nên được
             * thừa kế và sử dụng lại.
             */ 
            Weight = 500;
            Height = 20;
            Legs = 2;
        }
        // Gọi constructor của lóp cha, bằng base
        public Cat(double w, double h, int l) : base (w,h,l)
        {
            
        }
        public new void info() 
            // toán tử new chỉ định đây là hàm info mới của lớp Cat, không liên quan đến hàm info của lớp cha, chẳng qua là cùng tên
            //hàm info() của lớp cha bị che dấu đi, mọi đối tượng bên ngoài chỉ gọi được hàm info() của lớp Cat.
            // hoặc bỏ new cũng được, ket qua giong nhau.        
        {
            Console.WriteLine("Thong tin cua Cat: ");
            base.info();// gọi đến từ ham info() cửa lớp cha
            base.Height = 15; // gọi fields
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat BlackCat = new Cat();// một con mèo tạo ra đối tượng là con mèo :OK
            BlackCat.info();
            

            //Vấn đề cấp phát vùng nhớ cho đối tượng:
            Animal WhiteCat = new Cat(); //Một con động vật tạo ra 1 đối tương là con mèo: OK
            WhiteCat.info();

            Console.ReadKey();
            // bình thường không inheritance là: không được được. Error: Khong thể chuyển từ kiểu Cat sang kiểu Animal
            // Nhưng nếu 2 lớp này có quan hệ thừa kế thì hoàn toàn được.Nhưng ngược lại thì không:Cat cat1 = new Animal();            
            // Đó chính là tính đa hình
        }
        /*
         * + Resul: Thong tin cua Cat:
Thong tin cua animal:
Can nang: 500Chieu cao: 20So chan: 2
Thong tin cua animal:
Can nang: 500Chieu cao: 20So chan: 2
         */

        /*Note:
         *  Animal Class
         *  - protected double Weight, Height         
         *  - static int Legs
         *  + Animal(){}
         *  + Animal(double w, double h, int l){}
         *  + void new info(){}
         *  Cat Class : Animal Class
         *  + Cat(){}
         *  + Cat(double w, double h, int l): base(w,h,l){}
         *  + void info(){},  hoặc *  + void  info(){} cũng được, kết quả giống nhau.
         *  // Hai hàm info(), cung ten, cùng tham số và kiểu dữ liệu trả về => Override, ghi de phuong thuc. Duoc su dung trong da hinh.
         *      + Hoc ve van de: Override luon:
         *      - methods lớp con đã ghi đề methods của cha, nhằm che dấu methods lớp cha, kết quả đã cho ta thấy điều đó.
         *      - Mục đích ghi đè là sữa lại phương thức của lớp cha trong lớp con.
         *      - Sử dụng phương thức base để truy cập đến phương thức đã ghi đề cưa lớp cha
         *      - Access Specifier của lớp con phải có độ công khai > or = AS của lớp cha.
         */
    }
}
