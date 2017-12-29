using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop4_KieuDuLieu
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ví dụ 1
            byte BienByte = 3;
            short BienShort = 9;
            int BienInt = 10;
            long BienLong = 0;
            //BienByte = BienShort; // error: because byte < short
            BienLong = BienInt; // not error. becase long > int
            BienShort = BienByte;
            Console.WriteLine("BienByte = " + BienByte); // kq: tương ứng với +TenBien, BienByte = 3
            Console.WriteLine("BienByte = {0}", BienByte);// BienByte = 3
            // tương tự cho các kiểu các. Chú ý là: BienByteLon = BienByteNho, biến byte lớn được gán với biến byte nhỏ.            
            #endregion
            #region Ví dụ 2
            int a;
            //Console.WriteLine("a = " +a);// error: Use of unassigned local variable 'a' : biến chưa được gán
            //int b = 10.9; // error: int not double
            //byte c = 1009; //byte vượt quá số byte
            //string d = 'K';// error: nháy đơn, thay bằng nháy đôi
            //int e = null; // error: không được gán null cho các kiểu long, int, byte ..
            int? f = null; // cách khắc phục trên.
            int g = 10;
            byte h = g;// error: kích thước byte:  byte < int
            string k = "Hello Cop";
            Console.WriteLine("k ="+K);// error: phân biệt k thường với K hoa.
            Console.ReadKey();
            #endregion
        }
    }
}
/*
 * 
 * 
 * 
 * 
 */