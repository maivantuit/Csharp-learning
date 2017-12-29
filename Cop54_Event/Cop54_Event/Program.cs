using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Cop54_Event
{
    class SubEventArgs: EventArgs
    {
        public int Result { get; set; }
        public SubEventArgs()
        {

        }
        public SubEventArgs(int _result)
        {
            Result = _result;
        }
    }
    public delegate int DelegateTinhToan(int a, int b);

    delegate void TruHaiSoEventHandler(object sender, SubEventArgs e);
    class ExampleClass
    {
        // Khai báo 1 event: 
        /*: 1. Bằng EventHandler
         *  2. Tên event bắt đầu từ On, phía sau là 1 động từ. 
         *  3. Được khai báo trong class.
         *  */
        public event EventHandler OnDaCong;

        //
        public event TruHaiSoEventHandler OnDaTru;
        public int CongHaiSo(int a, int b)
        {
            if (OnDaCong!=null)
            {
                OnDaCong(this, EventArgs.Empty);// this: đối tượng hiện tại ta tác động tới, EventArgs.Empty: ta không truyền tham số nào cả. 
            }
            return a + b;
        }
        public int TruHaiSo(int a, int b)
        {
            if (OnDaTru != null)
            {
                OnDaTru(this, new SubEventArgs(a-b));// this: đối tượng hiện tại ta tác động tới, EventArgs.Empty: ta không truyền tham số nào cả. 
            }
            return a - b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = 10;
            //Comment lại để demo tiếp
            /*
            ExampleClass ec = new ExampleClass();
            DelegateTinhToan dltt1 = ec.CongHaiSo;
            ec.OnDaCong += MyEvent;
            //dltt1(a, b);
            Console.WriteLine("Ket qua cong hai so: "+dltt1(a,b));
            */
            /*Ket qua:
            *  Event: Da thuc hien phep cong!
            Ket qua cong hai so: 25
            */


            // Demo 2:
            ExampleClass ec2 = new ExampleClass();
            DelegateTinhToan dltt2 = ec2.TruHaiSo;
            ec2.OnDaTru += CustomEvent;
            dltt2(a,b);
            Console.ReadLine();
        }
        public static void CustomEvent(object sender, SubEventArgs subEventArgs)
        {
            Console.Write("Event: Da thuc hien phep tru! {0}",subEventArgs.Result);//Event: Da thuc hien phep tru! 5
        }

        public static void MyEvent(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("Event: Da thuc hien phep cong!");
        }
        


        // Ngoai ra ta co the tu tao EventHandler cho chinh minh.

        /*
         * Gồm 2 bước:
         * Bước 1. Tao delegate handler:
         *  - Tạo delegate SubTrationEventHandler
         *  - Tạo class SubEventArgs : EventArgs
         *  - Event mới : 
         */
    }
}
