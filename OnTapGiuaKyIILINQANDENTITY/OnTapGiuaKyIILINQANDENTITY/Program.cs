using System;

namespace OnTapGiuaKyIILINQANDENTITY
{
    public class Student
    {
        public int StudentID;
        public string Name;
        public int Age;

    }
    public static class MyExtentionMethod
    {
        public static bool IsAudult(this Student st)
        {
            return st.Age >= 18;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {            
            Student s1 = new Student();
            s1.Age = 10;// 10=false and 30= true.
            bool checkIsaudult = s1.IsAudult();
            Console.WriteLine(checkIsaudult);
            Console.ReadLine();
        }
    }
}
/*
    1. Extention methods cho phép chúng ta add các method vào các loại có sẵn mà không tạo ra một derived type, biên dịch lại hoặc sửa đổi kiểu gốc.(original type)
    2. Extention methods là static methods.
    3. Extention methods là được chứa trong 1 class static và chúng có parameter: this của type class. 
     
*/
