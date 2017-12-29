using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SoloLearn
{
    class DemoNonStatic
    {
        public int a;
        public int b;
        public DemoNonStatic()
        {
        }
        public int TongHaiSo(int a, int b)
        {
            return a + b;
        }
        public void Show1()
        {
            Console.WriteLine("This is methods Show1");
        }
    }
    class DemoStatic
    {
        public int a1;
        public int b1;
        DemoStatic()
        {
        }
        public static int TongHaiSo(int a1, int b1)
        {
            return a1 + b1;
        }
        public static void Show2()
        {
            Console.WriteLine("This is methods Show2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* STATIC
            Non - static member :
            + Dữ liệu được cấp pháp khi đối tượng được khởi tạo.
            + Truy xuất thông qua đối tượng
            + Dữ liệu thuộc duy nhất về đối tượng đang nằm giữ
            VD: Customer c= new Customer();
            c.FullName = "Cop";
            Customer b= new Customer();
            c.FullName = "Jerry";
            Static member:
            + Dữ liệu được cấp pháp khi chương trình chạy.
            + Chỉ có 1 thể hiện duy nhát va được truy cập thông class (Tên class).
            + Dữ liệu được dụng chung cho cả ứng dụng
            VD: 
            Counter.HitCounter++;
            */
            DemoNonStatic obj1 = new DemoNonStatic();
            int result1 = obj1.TongHaiSo(3, 5);
            Console.WriteLine("Tong hai so 1: {0}", result1);
            obj1.Show1();

            int result2 = DemoStatic.TongHaiSo(5, 7);
            Console.WriteLine("Tong hai so 2: {0}", result2);
            DemoStatic.Show2();
            /*
            Result:
            Tong hai so 1: 8
            This is methods Show1
            Tong hai so 2: 12
            This is methods Show2
            */
            Console.ReadKey();
            /*
            Vi du:
            + Khi thay đổi giá trị của biến static thì các thành phần trong class thaayd đổi như thế nào.
            + Tìm hiểu property.
            */
        }
    }
}