using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop46_Exception
{
   
    class ExceptionDemo
    {
        public static double TinhHaiSo(int a, int b)
        {
            double c=0;
            string str = "Mai Van Tu";
            string stra=" ";
            try
            {
                c = a / b;
                stra = str.Substring(0,3);
                
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Loi chia cho so 0, vui long nhap lai! ");               
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Error: Khong duoc lay qua so luong ki tu chuoi dang co!, vui long xem lai");                
            }
            catch (Exception e)
            {
                Console.WriteLine("Loi du lieu chung, vui long xem lai! ");                
            }
            finally
            {
                Console.WriteLine("Ket qua la: "+c);
                Console.WriteLine("Ket qua substring: "+stra);
            }
            return c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double result = ExceptionDemo.TinhHaiSo(10,0);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
/*
 * 1. TryCatch: Try: cố gắng làm điều gì đó, nếu nó exception, thì bắt lấy nó chuyển vào cho catch để xữ lý
 * 2. Finally: Dù có lỗi hay không có lỗi thì finally vẫn chạy, trong các trường hợp như: như trên, đóng các connection, các giao tiếp IO, tiết kiệm bộ nhớ...
 * 3. Sử dụng Console.WriteLine(e.ToString()); để xem lỗi.
 * 4. Exception là cha, nên luôn luôn bỏ sau, chỉ sau finally. 
 * 5. Khi sử dụng không biết lỗi gì thì bỏ Exception là an toàn nhất.
 * 6. Chạy in ra exception, copy exception catch vào xữ lý.
 * 7. Uu điểm của trycatch rất nhiều nhưng nhược điểm:
 *  - Khi xữ lý nhiều lỗi rất dễ phát sinh trong 1 khối try, thì catch chỉ bắt lỗi đầu tiên. Khi cho 2 trường hợp trên có xảy ra ngoại lệ. Các nào đứng trước sẽ được xữ lý trước và vào catch tương ứng trước. Và cái còn lại đương nhiên là không được xữ lý và k đưa vào catch của nó.
 *  - Cách tốt nhất là mỗi cái dễ sinh ra lỗi thì bỏ 1 try catch bắt lỗi và đưa ra thông báo lỗi tương ứng. Vậy mỗi lần như vậy thì có rất nhiều trycatch. 
 */
