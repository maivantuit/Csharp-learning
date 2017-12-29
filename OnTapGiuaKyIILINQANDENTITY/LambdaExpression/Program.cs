using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpression
{
    class student
    {
        int id;   
        string name;
        public student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                this.id = ID;
            }
        }
        public string NAME
        {
            get
            {
                return name;
            }
            set
            {
                this.name = NAME;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNum = { 1, 1, 2, 3, 5, 8, 13, 21, 34,3,6,3,4};
            // tìm các số chia hết cho 2:
            IEnumerable<int> a= arrayNum.Where(num => num % 2 == 0);
            Console.WriteLine("Cac so chia het cho 2: "); // 2 8 34 6 4
            foreach (var item in a)
            {
                Console.Write(" "+item);
            }
            // tính trung bình các số chia hết cho 2.
            double averageValue = arrayNum.Where(num => num % 2 == 0).Average(); // do ở đây .Average() nên kiểu dữ liệu có thể là double
            Console.WriteLine("Trung bình các số chia hết cho 2: "+averageValue); //10.8

            // tính tổng các số chia hết cho 2.
            double TongValue = arrayNum.Where(num => num % 2 == 0).Sum();
            Console.WriteLine("Tong cac so chia het cho 2: "+ TongValue);

            List<student> list = new List<student>() {
                new student(1,"Nguyen Van A"),
                new student(2,"Nguyen Van B"),
                new student(3,"Nguyen Van C"),
                new student(4,"Nguyen Van D"),
                new student(5,"Nguyen Van E"),
            };
            // tìm student có id = 2:
            IEnumerable<student> tim1 = list.Where(sv => sv.ID == 2);
            foreach (student item in tim1)
            {
                Console.WriteLine(item.NAME); // Nguyen Van B
            }
            // tìm sinh viên có tên là D
            IEnumerable<student> tim2 = list.Where(sv => sv.NAME == "Nguyen Van D");
            foreach (student item in tim1)
            {
                Console.WriteLine(item.ID+" "+item.NAME); // 2 - Nguyen Van B
            }
            Console.ReadLine();
        }
    }
}
/*
1. Biểu thức lambda rất hữu ích cho việc viết các biểu thức truy vấn LINQ

*/
