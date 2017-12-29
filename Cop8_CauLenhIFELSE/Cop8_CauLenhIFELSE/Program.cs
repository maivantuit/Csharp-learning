using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop8_CauLenhIFELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Kiểm tra số chẵn hay số lẻ nhập bằng Parse();
            int a;
            string stra;
            //nhap a tu bàn phím
            Console.WriteLine("Moi ban nhap so a: ");
            stra = Console.ReadLine();
            a = Int32.Parse(stra);
            if (a % 2 == 0)
            {
                Console.WriteLine("a la so Chan");
            }
            else
            {
                Console.WriteLine("a la so Le");
            }
            //nếu nhập vào ký tự chữ tring thì bị lỗi.
            Console.ReadKey();
            #endregion :
            #region Tính điểm trung bình, xét xếp loại cho học sinh 
            double dtb;
            double diemHoa;
            double diemLy;
            double diemToan;
            string strDiemHoa;
            string strDiemLy;
            string strDiemToan;          
            Console.WriteLine("\nNhap diem toan: ");
            strDiemToan = Console.ReadLine();
            diemToan = Double.Parse(strDiemToan);
            Console.WriteLine("\nNhap diem ly: ");
            strDiemLy = Console.ReadLine();
            diemLy = Double.Parse(strDiemLy);
            Console.WriteLine("\nNhap diem hoa: ");
            strDiemHoa = Console.ReadLine();
            diemHoa = Double.Parse(strDiemHoa);
            dtb = (diemToan * 2 + diemHoa + diemLy) / 4;
            //Console.WriteLine("Diem Toan {0}, Diem Ly {1}, Diem Hoa {3}, Diem Trung Binh {4}", diemToan,diemLy,diemHoa,dtb); // bị lỗi không hiểu sao
            Console.WriteLine("Diem Trung Binh: "+dtb);
            if (dtb>8.5 && dtb <10)
            {
                Console.WriteLine("Xep loai Gioi");
            }
            else if(dtb>7.0 && dtb <8.5)
                {
                    Console.WriteLine("Xep loai kha");
                }else if (dtb > 5.0 &&  dtb <7.0)
                        {
                            Console.WriteLine("Xep loai trung binh");
                        }else
                        {
                            Console.WriteLine("Xep loai yeu");
                        }
            Console.ReadKey();
            #endregion:
        }
    }
}
