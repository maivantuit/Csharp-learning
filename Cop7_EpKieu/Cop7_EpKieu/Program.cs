using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop7_EpKieu
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Chuyển kiểu ngầm định
            //int k = 10;
            //long l = k; // tự động hiểu ngầm định, kích thước byte của long > k
            //float f = 10.9f;
            //double d = f;
            #endregion
            #region Chuyển kiểu tường minh
            //int i = 300;// 300 có mã nhị phần là 100101100
            //byte b = (byte)i; // do kiểu byte có giới hạn đến 255 thôi nên không thể chứa được mà kiểu byte có kích thước là 1 bytes tương đương 8bit. Như vậy ta cần cắt mã nhị phân 300 là 100101100 cắt từ trái qua 1 bit ta được 00101100 (đủ 8 bit) tương đương với số 44. Cuối cùng b sẽ mang giá trị là 44.
            //Console.WriteLine(i); //kq: 300
            //Console.WriteLine(b); // kq: 44

            //// chia lấy nguyên, lấy dư vậy lấy số đúng thì làm sao.
            //int a = 5;
            //int c = 2;
            ////float kq =  a / c;
            ////int kq = a % c;
            ////Console.WriteLine(kq);// kq: 2, for /
            ////Console.WriteLine(kq);// kq: 1, for %
            //float kq = (float)a / c;
            //Console.WriteLine(kq); //kq: 2.5, for /, khi ép kiểu
            ////or
            //float kq2 = a*1.0f / c;// nhân cho 1 số thực có hậu tố f sau
            //Console.WriteLine(kq2);// kq: 2.5, for /, k ép kiểu     

            #endregion
            #region Chuyển kiểu sử dụng phương thức Parse()
            //string s = "10";
            //int k = int.Parse(s);
            //double e = double.Parse("10.9");
            //Console.WriteLine(k);//kq: 10
            //Console.WriteLine(e); //kq: 10.9
            #endregion
            #region Chuyển kiểu sử dụng phương thức Tryparse(), hạn chế được lỗi khi sử dụng Parse()
            //int Result;// biến kết quả
            //bool isSuccess;// biến kiểm tra ép kiểu
            //string data1 = "10", data2 = "Cop"; // dữ liệu cần kiểm tra

            //isSuccess = int.TryParse(data1,out Result);
            //Console.WriteLine(isSuccess == true ? "Success !" : "Failed !"); // kq: Success
            //Console.WriteLine("Result = "+Result); // kq: Result = 10

            //isSuccess = int.TryParse(data2, out Result);
            //Console.WriteLine(isSuccess == true ? "Success !" : "Failed !"); // kq: Failed
            //Console.WriteLine("Result = " + Result); //kq: Result = 0
            #endregion
            #region Chuyển kiểu sử dụng phương thức lớp Convert()
            //int value = Convert.ToInt32("9");// Chấm thì có nhiều đối tượng chuyển tới
            //int a = 10;
            //int kq = a + value;
            //Console.WriteLine(value); // kq: 9
            //Console.WriteLine(kq); //kq: 19
            #endregion
            #region Ví dụ điển hình sử dụng Parse()
            int a, b;
            int tong, hieu, tich;
            double thuong;
            string stra, strb;

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Chuong trinh tinh tong, hieu, tich, thuong");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("\n Moi ban nhap so a: ");// lệnh in đầu, chưa đưa biến vào
            stra = Console.ReadLine(); // lệnh nhập
            a = int.Parse(stra);
            Console.WriteLine("\n Moi ban nhap so b: ");
            strb = Console.ReadLine();
            b = int.Parse(strb);
            tong = a + b;
            hieu = a - b;
            tich = a * b;
            thuong = (double)a / b;
            Console.WriteLine("Tong = "+tong);
            Console.WriteLine("Hieu = " + hieu);
            Console.WriteLine("Tich = " + tich);
            Console.WriteLine("Thuong = " + thuong);
            #endregion:
        }
    }
}
