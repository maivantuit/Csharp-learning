using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Cop20_TuKhoaRefVaOut
{
    class Program
    {
        static void IncreaseValue(out int value)
        {
            value = 0;
            value++;
        }
        static void Main(string[] args)
        {
            int value = 5;
            Console.WriteLine("Value before increase: {0}", value);//kq 1: 5, kq 2 (dùng out): 5
            IncreaseValue(out value);// kq 1: không chạy
            Console.WriteLine("Value after increase: {0}", value);// kq 1: 5, kq 2 (dùng out): 1
            Console.ReadKey();
        }
      
    }
}
/*
 * Lưu ý:
 Từ khóa out cũng tương tự từ khóa ref. Đó là:

Vùng nhớ của các parameter sẽ được hàm sử dụng thao tác trực tiếp, dẫn đến khi kết thúc lời gọi hàm giá trị của các parametter có thể bị thay đổi.
 Phải có từ khóa out trước tên parameter của hàm và trước tên biến truyền vào khi gọi hàm sử dụng.
Nhưng có một sự khác biệt đó là:

 Biến truyền vào có từ khóa out sẽ không cần khởi tạo giá trị ban đầu.
 Parameter đó chỉ như một thùng chứa kết quả trả về khi kết thúc gọi hàm.
 Đồng thời parameter đó phải được khởi tạo ngay bên trong lời gọi hàm.
 */


