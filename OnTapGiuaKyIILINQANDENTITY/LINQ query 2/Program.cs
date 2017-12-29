using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_query_2
{
    class Student
    {
        int id;
        string name;
        int age;
        public Student(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
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
        public int AGE
        {
            get
            {
                return age;
            }
            set
            {
                this.age = AGE;
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
    class CLASSDEMO
    {
        int classID;
        string classname;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>() {
                new Student(1,"Laura",19),
                new Student(2,"Sam",24),
                new Student(3,"Gin",23),
                new Student(4,"Vermoth",21),
                new Student(5,"Volka",20),
                new Student(6,"Victor",22),
            };

            Console.WriteLine(" List student: ");
            foreach (Student item in list)
            {
                Console.WriteLine(item.ID+" "+ item.NAME+" "+item.AGE);
            }
            // Question: Tìm student có tên là : Laura.
            // use query syntax:
            var result1 = from s in list
                          where s.NAME.Equals("Laura")
                          select s;
            Console.WriteLine("List after looking for: (query syntax)");
            if (result1!=null)
            {
                foreach (var item in result1)
                {
                    Console.WriteLine(item.ID + " " + item.NAME + " " + item.AGE);
                }
            }
            else
            {
                Console.WriteLine("Not looking for");
            }
            // use method syntax:   
            var result2 = list.Where(s => s.NAME.Equals("Laura"));
            Console.WriteLine("List after looking for: (methods syntax)");
            if (result1 != null)
            {
                foreach (var item in result1)
                {
                    Console.WriteLine(item.ID + " " + item.NAME + " " + item.AGE);
                }
            }
            else
            {
                Console.WriteLine("Not looking for");
            }


            // 1. Filtering Operators: Question: Looking for student have age: from 19 to 23 years old? (where, oftype)
            // use: query syntax:
            IEnumerable<Student> filter1 = from s in list // hoặc var cũng ok
                          where s.AGE >= 19 && s.AGE<=23
                          select s;
            Console.WriteLine("List student have age from 19 to 23 years old(use query syntax): ");
            foreach (Student item in filter1)
            {
                Console.WriteLine(item.ID + " " + item.NAME + " " + item.AGE);
            }
            // use: method syntax:
            IEnumerable<Student> filter2 = list.Where(s=>s.AGE>=19 && s.AGE<=23); // kiểu var vẫn ok
            Console.WriteLine("List student have age from 19 to 23 years old (use method syntax): ");
            foreach (Student item in filter2)
            {
                Console.WriteLine(item.ID + " " + item.NAME + " " + item.AGE);
            }

            // 2. Projection Operators: (Chiếu) Questions: Lấy về tên các student trong list: (select, selectmany)
            //use: quer syntax:
            var projection1 = from s in list         
                              where s.AGE==24
                              select s.NAME;
            Console.WriteLine("List student have field NAME (use method syntax): ");
            foreach (var item in projection1) // khi chọn 1 field thì duyệt kiểu var, và dislay các item của nó.
            {
                Console.WriteLine(item);
            }
            // use: method syntax: chọn chiếu chỉ sử dụng query syntax:
            // use other way:
            var projection2 = from s in list
                              where s.AGE >=19 && s.AGE <= 23
                              select new { Ma = s.ID, Ten = s.NAME, Tuoi = s.AGE }; // Ma, Ten, Tuoi : tự đặt.
            Console.WriteLine("Select new have age from 19 to 23 years old: ");
            foreach (var item in projection2)
            {
                Console.WriteLine(item.Ma + " " + item.Ten + " " + item.Tuoi);
            }
            // 3. Sorting Operator: Questions: sắp xếp danh sách trường tên theo alphabe (Orderby,Orderbydescending, thenby, thenbydescending, reverse)
            // use: query syntax:
            var sort1 = from s in list
                        orderby s.NAME
                        select s;
            Console.WriteLine("Sort list by name alphabe(use query syntax): ");
            foreach (var item in sort1)
            {
                Console.WriteLine(item.ID + " " + item.NAME + " " + item.AGE);
            }
            // use method syntax:
            var sort2 = list.OrderBy(s=>s.NAME);
            Console.WriteLine("Sort list by name alphabe (use method syntax): ");
            foreach (var item in sort2)
            {
                Console.WriteLine(item.ID + " " + item.NAME + " " + item.AGE);
            }
            // sort multiple:
            Console.WriteLine("Sort list by name alphabe and age (use sorting multiple): ");
            var sort3 = from s in list
                        orderby s.AGE, s.NAME
                        select new { s.AGE, s.NAME }; // đây là sắp xếp tuổi trước.
            foreach (var item in sort3)
            {
                Console.WriteLine( item.NAME + " " + item.AGE);
            }
            // 4. Partitioning Operators: (phần vùng): (take, takewhile, skip, skipwhile)
            var partition1 = list.Take(2);
            Console.WriteLine("Partition take(2): " ); //nghĩa là lấy 2 record đầu tiên
            foreach (var item in partition1)
            {
                Console.WriteLine(item.ID+" "+item.NAME + " " + item.AGE);
            }
            IEnumerable<Student> partition2 = list.TakeWhile(s=>s.NAME.Length >4 );
            Console.WriteLine("Partition takewhile(s.name.length>4): "); 
            foreach (var item in partition2)
            {
                Console.WriteLine(item.ID + " " + item.NAME + " " + item.AGE);
            }
            // 5. Group by (group by, tolookup) : dạng như nhóm theo id của lớp có bn sinh viên, hay nhóm theo id đơn ị có bao nhiêu staff.
            var group1 = from s in list
                         group s by s.ID; // nhóm theo id của lớp
            Console.WriteLine("Group by: ");
            foreach (var item in group1)
            {
                Console.WriteLine(" Class id: {0} {1}",item.Key,item.Count()); //
                foreach (var item2 in item)
                {
                    Console.WriteLine( "Student name: "+item2.NAME); // trong id lớp đó có bao nhiêu sinh viên.
                }
            }            
            Console.ReadLine();
        }
    }
   
}
