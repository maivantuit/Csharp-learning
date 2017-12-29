using System;
using System.Collections.Generic;

namespace Cop57_GenericCollection
{
    class User
    {
        int CMND { get; set; }
        string HoTen { get; set; }
        // Tài khoản/ mật khẩu
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary <> Class: ( thường dùng khi mã , tên: mã: key, tên: value, mã/key sẽ không bị trùng nên khuyến khích Dictionary)
            /*
             * 1. Tương tự như hashtable nhưng key và value của các phần tử phải được xác định kiểu dữ liệu trước.
             * 2. Dictionnary <> lưu 1 cặp key/ value trong tập hợp. Khai báo 2 tham số generic khi khởi tạo.
             */
            Dictionary<int, string> UserList = new Dictionary<int, string>();
            UserList.Add(197363057, "Mai Van Tu");
            UserList.Add(197363058, "Khanh Nhi");
            //duyệt mảng cách 1:
            foreach (var item in UserList)
            {
                Console.Write(" " + item);     // [197363057, Mai Van Tu] [197363058, Khanh Nhi]       
            }
            // duyệt mảng cách 2:
            Console.WriteLine("\n");
            foreach (KeyValuePair<int, string> item in UserList)// KeyValuePair: trả ề kiểu struct.
            {
                Console.Write(" " + item);// [ 197363057, Mai Van Tu] [197363058, Khanh Nhi]
            }
            // ngoài ra còn nhiều methods của nó:
            // Từ .NET 3.0 cung cấp Khởi tạo nhanh không cần phải add từng cái 1 như trên:
            Console.WriteLine("\n");
            Dictionary<int, string> UserList2 = new Dictionary<int, string>() { {197363059,"Hong Dao" },{197363060,"Quynh Xuan Vu" } };
            foreach (KeyValuePair<int, string> item in UserList2)// KeyValuePair: trả ề kiểu struct.
            {
                Console.Write(" " + item);//  [197363059, Hong Dao] [197363060, Quynh Xuan Vu]
            }
            Console.ReadLine();
        }
    }
}
