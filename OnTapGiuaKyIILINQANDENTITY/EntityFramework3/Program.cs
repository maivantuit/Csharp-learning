using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //get tên NV có MaNV == 1:
            //use method syntax:
            var db = new ModelNhanSu();
            var staff = db.Staffs
                .Where(s => s.MaDV == 1)
                .Select(s => s.TenNV);
            Console.WriteLine("Danh sach nhan vien trong DonVi co MaDV==1:");
            foreach (var item in staff)
            {
                Console.WriteLine(item);
            }
            /*
            Danh sach nhan vien trong DonVi co MaDV==1:
            Mai Văn Tú
            Trần Quang Bảo
            */
            // thêm 1 staff: (có thể vào đơn vị nào?):
            // đầu tiên ta phải chuyển về collection để add vào:
            var kq1 = (from s in db.Staffs // kiểu var vẫn ok
                       select s);

            Console.WriteLine("Danh sach nhan vien:");
            foreach (var item in kq1)
            {
                Console.WriteLine(item.MaDV +" - "+item.MaNV+" - "+item.TenNV);
            }
            //kq1.Add(new Staff(1, 6, "Trương Phước Tiến"));
            
            // Lưu ý quan trọng: không được tạo contructor! nhé
            
            List<Staff> kq2 = (from s in db.Staffs // kiểu var vẫn ok
                       select s).ToList();
            foreach (Staff item in kq2)
            {
                Console.WriteLine(item.TenNV);
            }
            kq2.Add(new Staff { MaDV= 1, TenNV= "Thanh Ngọc",MaNV = 6});
            kq2.Add(new Staff { MaDV = 1, TenNV = "Châu Ngọc", MaNV = 7 });
            
            Console.WriteLine("List after add: ");
            foreach (Staff item in kq2)
            {
                Console.WriteLine(item.MaDV+" - "+item.MaNV+" - "+item.TenNV);
            }
            // view first staff in list:
            var kq3 = (from s in db.Staffs
                         where s.TenNV.StartsWith("M")
                       select s).First();
            Console.WriteLine("After view first: ");
            Console.WriteLine(kq3.TenNV); // Mai Văn Tú
            
            //var kq4 = (from s in db.Staffs
            //           //where s.TenNV= "Đỗ Lọ"
            //           select s).SingleOrDefault();
            Console.WriteLine("After view single or default: ");
            //Console.WriteLine(kq4.TenNV);
            db.SaveChanges();

            // add multiple staff:
            Staff s10 = new Staff { MaDV = 1, MaNV = 9, TenNV = "Đỗ Lọ"                                    
            };
            List<Staff> listadd = new List<Staff>() {
                new Staff{ MaDV = 1, MaNV = 10, TenNV = "Đỗ Lọ2"},
                new Staff{ MaDV =1, MaNV = 11, TenNV = "Đỗ Lọ 3"},
                new Staff{ MaDV =1, MaNV = 12, TenNV = "Đỗ Lọ 4"},
            };
            kq2.Add(s10);
            //kq2.Add(listadd);
            db.SaveChanges();
            Console.WriteLine("List after add multiple: ");
            foreach (Staff item in kq2)
            {
                Console.WriteLine(item.MaDV + " - " + item.MaNV + " - " + item.TenNV);
            }
            Console.ReadLine();
        }
    }
}
