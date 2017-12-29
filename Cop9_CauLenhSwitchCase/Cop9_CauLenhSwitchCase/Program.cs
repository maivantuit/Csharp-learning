using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop9_CauLenhSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            #region: Nhập vào thứ bằng số in ra thứ bằng chữ.
            int a;
            string stra;
            Console.WriteLine("Nhap so thu: ");
            stra = Console.ReadLine();
            a = Int32.Parse(stra);
            switch (a)
            {
                case 2: Console.WriteLine("Thu Hai");break;
                case 3: Console.WriteLine("Thu Ba"); break;
                case 4: Console.WriteLine("Thu Thu Tu"); break;
                case 5: Console.WriteLine("Thu Nam"); break;
                case 6: Console.WriteLine("Thu Sau"); break;
                case 7: Console.WriteLine("Thu Bay"); break;
                case 8: Console.WriteLine("Thu Chu Nhat");
                    int kq = a / 2;
                    if (kq==4)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                        break;
                default:
                    Console.WriteLine("Nhap so khong dung");    
                break;
            }
            Console.ReadLine();
            #endregion:
        }
    }
}
