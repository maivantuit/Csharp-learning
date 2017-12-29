using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop53_Delegate
{
    /// Khai báo delegate: - Khong sử dụng private.
    public delegate int DelegateTinhToan(int a, int b);// Phải giống về kiểu trả về và danh sách tham số pass

    // Tao delegate mới của 2 methods: Hello và Goodbye.
    public delegate void DelegateChaoHoi(string s);

    // Tao 1 con tructor va tao 1 delegate này:
    public delegate void DelegateExampleClass(string i);
    class ExampleClass
    {
        public ExampleClass()
        {

        }
        public ExampleClass(DelegateExampleClass dlec)
        {
            int i = 1;
            while (i<=10)
            {
                dlec(i.ToString());//
                i++;
            }
        }
        public int CongHaiSo(int a, int b)
        {
            return a + b;
        }
        public int TruHaiSo(int a, int b)
        {
            return a - b;
        }

        // Thêm 2 methods nữa:
        public void Hello(string s)
        {
            Console.WriteLine("Hello {0}",s);
        }
        public void Goodbye(string s)
        {
            Console.WriteLine("Goodbye {0}", s);
        }
    }
    class Program
    {       
        static void Main(string[] args)
        {
            // cách 1 bình thường, sử dụng tạo đối tượng. (comment lại để demo tiếp)

            /*
            ExampleClass ex1 = new ExampleClass();
            int result1 = ex1.CongHaiSo(5,5);
            int result2 = ex1.TruHaiSo(10,5);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            */

            // cách 2 ta sử dụng 2 methods trên là static. Và chỉ cần gọi methods, bằng cách TenLop.TongHaiSo. (comment lại để demo tiếp)

            /*
            int result3 =Example.CongHaiSo(5,5);
            Console.WriteLine(result3);
            int result4 = Example.TruHaiSo(5, 5);
            Console.WriteLine(result3);
            */

            // Hai cách trên quá quen thuộc. Tuy nhiên C# hổ trợ delegate. Gọi tên methods không phải dùng tên chính nó ?

            /*
             *  - Giống như 1 người đại diện, đại sứ
             *  - Dùng để đóng gói 1 hoặc nhiều methods
             *  - Gọi 1 methods bất kỳ nơi nào
             *  - Có thể truyền vào làm tham số của các methods.
             */

            /// Gán value, new object (ca the: instance)
            int a = 15;
            int b = 10;
            ExampleClass ex1 = new ExampleClass();
            /// Khoi tao delegate:
            // cách 1:  (comment cách 1 lại, để demo cách 2)

            /*
            DelegateTinhToan delegateTT = new DelegateTinhToan(ex1.CongHaiSo);
            DelegateTinhToan delegateTT2 = new DelegateTinhToan(ex1.TruHaiSo);
            */

            // cách 2: thường sử dụng, ngắn gọn:
            DelegateTinhToan delegateTT3 = ex1.CongHaiSo;
            DelegateTinhToan delegateTT4 = ex1.TruHaiSo;//   delegateTT4:  no la 1 object, instance cua  DelegateTinhToan (cach hieu cua minh)       

            /// Thực thi delegate:
            // cách 1: Gọi methods import
            Console.WriteLine("\nKet qua cong hai so: {0} + {1} = {2}  ",a,b, delegateTT3.Invoke(a,b));//Ket qua cong hai so: 15 + 10 = 25
            Console.WriteLine("\nKet qua tru hai so: {0} - {1} = {2}  ", a, b, delegateTT4.Invoke(a, b));//Ket qua tru hai so: 15 - 10 = 5
            // cách 2: Gọi methods trực tiếp
            Console.WriteLine("\nKet qua cong hai so: {0} + {1} = {2}  ",a,b, delegateTT3(a,b));//Ket qua cong hai so: 15 + 10 = 25
            Console.WriteLine("\nKet qua tru hai so: {0} - {1} = {2}  ", a, b, delegateTT4(a, b));//Ket qua tru hai so: 15 - 10 = 5

            // Thể hiện đóng gói 1 hoặc nhiều methods: Thêm 2 methods void Hello(string ) and void Goodbye(string s)

            DelegateChaoHoi delegateCH1 = ex1.Hello;
            DelegateChaoHoi delegateCH2 = ex1.Goodbye;
            // đóng gói nè vào chung 1 delegate:
            DelegateChaoHoi sum = delegateCH1 + delegateCH2;
            DelegateChaoHoi sum2 = delegateCH1 - delegateCH2;
            DelegateChaoHoi sum3 =sum - sum2;
            DelegateChaoHoi sum4 = sum + sum2;

            delegateCH1("Mai Van Tu");//Hello Mai Van Tu
            delegateCH2("Khanh Nhi");//Goodbye Khanh Nhi
            sum("Trinh Hong Dao");//Hello Trinh Hong Dao \n Goodbye Trinh Hong Dao

            sum2("Xuan Quynh");//Hello Xuan Quynh

            sum3("Hong Dan");//Goodbye Hong Dan

            sum4("Hong Duong");//Hello Hong Duong \n Goodbye Hong Duong \n Hello Hong Duong            

            // 

            DelegateExampleClass ed = DelegateAsParams;
            ExampleClass ec2 = new ExampleClass(ed);

            ExampleClass ec3 = new ExampleClass(delegate (string s) // methods không tên trong c#, chỉ được sử dụng 1 lần
            {
                Console.Write(" " + s);//1 2 3 4 5 6 7 8 9 10 . Kết quả cũng không thay đổi
            });
            Console.ReadLine();
        }
        public static void DelegateAsParams(string s)
        {
            Console.Write(" "+s);// kq:  1 2 3 4 5 6 7 8 9 10
        }
    }
}
