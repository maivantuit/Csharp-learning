using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            var db = new ModelNhanSu2();
            Console.WriteLine("question 1: get staff have MaNV == 1,use method syntax:");
            var kq1 = db.Staffs.Where(s => s.MaNV == 1).Select(s => s.TenNV);
            foreach (var item in kq1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("question 1: get staff have MaNV ==1:, use linq syntax:");
            var kq2a = from e in db.Staffs
                       where e.MaNV == 1
                       select e.TenNV;
            foreach (var item in kq2a)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("question 2: get list staff in department have MaDV ==2:, use method syntax:");
            var kq2 = db.Staffs.Where(s => s.MaDV == 2).Select(s => s.TenNV);
            foreach (var item in kq2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("question 2: get list staff in department have MaDV ==2:, use linq syntax:");
            var kq2b = from e in db.Staffs
                       where e.MaDV == 2
                       select e.TenNV;
            foreach (var item in kq2b)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("question 3: View staff have name start with 'T': ");
            var kq3 = (from s in db.Staffs
                      where s.TenNV.StartsWith("T")
                      select s).First();
            Console.WriteLine(kq3.TenNV);
            Console.WriteLine("question 4: View staffs have name start with 'T': ");
            var kq3a = (from s in db.Staffs
                       where s.TenNV.StartsWith("T")
                       select s);
            foreach (var item in kq3a)
            {
                Console.WriteLine(item.TenNV);
            }
            Console.WriteLine("question 5: insert a staff into staff and into a department: ");
            // bước 1: convert table staff to a list:
            List<Staff> list1 = (from s in db.Staffs
                                 select s).ToList();
            foreach (var item in list1)
            {
                Console.WriteLine(item.TenNV);
            }
            // bước 2: insert a staff any into that list:            
            Staff s1 = new Staff { MaDV = 1, MaNV = 7, TenNV = "Hạnh Nhân" };
            Staff s2 = new Staff { MaDV = 1, MaNV = 6, TenNV = "Thanh Ngọc" };
            // bước 3: add into database and save:
            //db.Staffs.Add(s1);// exception! saved into database.
            //db.Staffs.Add(s2);            
            db.SaveChanges();
            Console.WriteLine("question 6: insert multiple staffs into table staff and department: ");
            List<Staff> list2 = new List<Staff>();
            list2.Add(new Staff { MaDV = 1, MaNV = 8, TenNV = "Trương Duyên" });
            list2.Add(new Staff { MaDV = 1, MaNV = 9, TenNV = "Huỳnh Thúy Kiều" });
            //db.Staffs.AddRange(list2);
            db.SaveChanges();
            Console.WriteLine("question 7: update staff: ");
            Staff s3 = (from s in db.Staffs
                     where s.MaNV == 9
                     select s).First();
            //s3.TenNV = "Lúm Huynh";
            db.SaveChanges();
            Console.WriteLine("question 8: delete staff: ");
            Staff s4= (from s in db.Staffs
                        where s.MaNV == 9
                        select s).First();
            db.Staffs.Remove(s4);
            db.SaveChanges();
            Console.ReadLine();

        }
    }
}

