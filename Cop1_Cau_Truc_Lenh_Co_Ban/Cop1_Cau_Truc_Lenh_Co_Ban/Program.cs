using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TenThuVien, sử dụng thư viện lấy có sẳn, hoặc tự tạo ra để sử dụng

namespace Cop1_Cau_Truc_Lenh_Co_Ban //tên project: namespace TenProject, lưu ý các cách đặt tên.
{
    public class Action { }//namespace chứa class
    public delegate void Art();//namespace chứa delegate
    namespace Sub_Namespace { }//namespace chứa  namespace con
    class Program //class TenLop
    {
        static void Main(string[] args)//method main, static
        {
            Console.Write("Hello Cọp");//bị ULTF-8
            Console.ReadKey();
        }
    }
}
//sử dụng nhiều project sử dụng chung, namspace.
