using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop2_NhapXuatCoBan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Cop");// có Line xuống dòng
            Console.Write("Mời bạn nhập tên của mình: ");// in không xuống dòng
            Console.WriteLine("Tên của bạn là: "+Console.ReadLine());//in ra màn hình, quy tắc chung cho việc thực hiện lệnh là lệnh bên trong thực hiên trước. Do đó chạy đến đây chương trình sẽ thực hiện lệnh console.WriteLine để xuống dòng
            Console.Write("Mời bạn nhập ngày sinh của mình: ");
            Console.WriteLine("Ngày sinh của bạn là: "+Console.ReadLine());
            Console.Write("Mời bạn nhập quê quán của mình: ");
            Console.WriteLine("Quê quán của bạn là: " + Console.ReadLine());
            //Console.ReadLine(): Không tái sử dụng giá trị bạn nhập vào.
            Console.ReadKey();
        }
    }
}
