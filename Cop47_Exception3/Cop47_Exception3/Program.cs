using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ExceptionTutorial
{
    class AgeException : ApplicationException
    {

        public AgeException(String message)
            : base(message)
        {
        }
    }
    class TooYoungException : AgeException
    {
        public TooYoungException(String message)
            : base(message)
        {

        }
    }
    class TooOldException : AgeException
    {
        public TooOldException(String message)
            : base(message)
        {

        }
    }
    class AgeUtils
    {
        // Method này làm nhiệm vụ kiểm tra tuổi.
        // Nếu tuổi nhỏ hơn 18 method sẽ ném ra ngoại lệ TooYoungException
        // Nếu tuổi lớn hơn 40 method sẽ ném ra ngoại lệ TooOldException
        public static void checkAge(int age)
        {
            if (age < 18)
            {
                // Nếu tuổi nhỏ hơn 18, ngoại lệ sẽ được ném ra
                // Method này kết thúc tại đây.
                throw new TooYoungException("Age " + age + " too young");
            }
            else if (age > 40)
            {
                // Nếu tuổi lớn hơn 40, ngoại lệ sẽ được ném ra.
                // Method này kết thúc tại đây.
                throw new TooOldException("Age " + age + " too old");
            }
            // Nếu tuổi nằm trong khoảng 18-40.
            // Đoạn code này sẽ được chạy.
            Console.WriteLine("Age " + age + " OK!");
        }
    }
    class TryCatchDemo2
    {
        public static void Main(string[] args)
        {
            // Bắt đầu tuyển dụng
            Console.WriteLine("Start Recruiting ...");
            // Kiểm tra tuổi của bạn.
            Console.WriteLine("Check your Age");
            int age = 15;
            try
            {
                // Chỗ này có thể bị ngoại lệ TooOldException,
                // hoặc TooYoungException
                AgeUtils.checkAge(age);
                Console.WriteLine("You pass!");
            }
            catch (AgeException e)
            {
                // Nếu có ngoại lệ xẩy ra, kiểu AgeException
                // Khối catch này sẽ được chạy
                Console.WriteLine("Your age invalid, you not pass");
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }
    }

}