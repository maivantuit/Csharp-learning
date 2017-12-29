using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop38_Static3
{
    class MauSac
    {
        public static string MauChuDao;
        static MauSac()
        {
            // khai bao doi tuong ngay gio va lay ngay gio hien tai cua he thong
            DateTime now = DateTime.Now;
            //lay ra thu cua ngay hien tai va so sanh voi 7 ngay trong tuan
            switch (now.DayOfWeek)
            {
                case DayOfWeek.Friday: MauChuDao = "Black";break;
                case DayOfWeek.Monday: MauChuDao = "Blue"; break;
                case DayOfWeek.Saturday: MauChuDao = "Green"; break;
                case DayOfWeek.Sunday: MauChuDao = "Yellow"; break;
                case DayOfWeek.Thursday: MauChuDao = "Pink"; break;
                case DayOfWeek.Tuesday: MauChuDao = "Red"; break;
                case DayOfWeek.Wednesday: MauChuDao = "Purple"; break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mau chu dao cua hom nay: "+MauSac.MauChuDao);
            //Neu khong co static: Ket qua la: Mau chu dao cua hom nay:
            //Neu co static truoc constructor: Ket qua la: Mau chu dao cua hom nay: Red. (Hom do la thu 3)
            // Ngoai class goi thong qua ten lop.
        }
    }
}
