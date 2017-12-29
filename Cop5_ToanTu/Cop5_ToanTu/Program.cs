using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop5_ToanTu
{
    class Program
    {
        static void Main(string[] args)
        {
            // nhấn : để region chỉnh code.
            #region Ví dụ 1: 
            int i = 5, j = 5;
            //Console.WriteLine(i++); // kq: 5, sử dụng giá trị i để in ra rồi mới tăng i
            //Console.WriteLine(++j); // kq: 6, Tăng j lên rồi mới in giá trị ra màn hình
            //Console.ReadKey();
            #endregion:
            #region Ví dụ 2: 
            //int a, b, c;
            //a = b = c = 10;
            //Console.WriteLine("a = {0}, b = {1}, c= {2}", a,b,c);// kq: a =10, b =10, c = 10
            //a += b = c = 10;
            //Console.WriteLine("a = {0}, b = {1}, c= {2}", a, b, c);// kq: a =20, b =10, c = 10
            //Console.ReadKey(); // nếu có 1 readkey trước thì các dòng code sau không biên dịch nữa.                     
            #endregion:
            #region Ví dụ 3: 
            //int a, b, c;
            //a = b = (c = 9) + 1;
            //Console.WriteLine("a = {0}, b= {1}, c ={2}", a, b, c);//kq: a= 10, b=10, c=9
            //a += b;
            //b = c++;
            //--c;
            //Console.WriteLine("a = {0}, b= {1}, c ={2}", a, b, c); //kq: a=20, b= 9, c= 9
            //Console.ReadKey();
            #endregion:
            #region Ví dụ 4: 
            string strSoNguyen;
            int SoNguyen;
            string KetQua;
            Console.Write("Moi ban nhap so nguyen: ");
            strSoNguyen = Console.ReadLine();
            SoNguyen = Int32.Parse(strSoNguyen);// ép kiểu dữ liệu vừa nhập vào
            KetQua = (SoNguyen % 2 == 0) ? "So Chan" : "So Le";
            Console.WriteLine("{0} la {1}", SoNguyen, KetQua);
            Console.ReadKey();
            #endregion:
        }
    }
}
