using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Query_3_Filtering_Operators
{
    class Department
    {
        public int iddpm { get; set; }
        public string namedpm { get; set; }
        public static List<Department> getDepartment()
        {
            return new List<Department>()
            {
                new Department{ iddpm =1 , namedpm ="IT"},
                new Department{ iddpm =2 , namedpm ="Marketing"},
            };
        }
    }
    class Staff
    {
        public int ids { get; set; }
        public int iddpm { get; set; }
        public string names { get; set; }
        public static List<Staff> getStaff()
        {
            return new List<Staff>()
            {
                new Staff{ ids =1, names = "Laura", iddpm=1},
                new Staff{ ids =2, names = "Smith",iddpm=1},
                new Staff{ ids =3, names = "Luiz",iddpm=2},
                new Staff{ ids =4, names = "Ran",iddpm=1},
                new Staff{ ids =5, names = "Gin",iddpm=2},
            };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //1. Group join: 
            // use query syntax:
            var group1 = from d in Department.getDepartment()
                         join s in Staff.getStaff()
                         on d.iddpm equals s.iddpm into sGroup //Department.idpdm = Staff.iddpm 
                         select new
                         {
                             Department = d,
                             Staff = sGroup
                         };
            Console.WriteLine(" use query syntax: group join");
            foreach (var itemdepartment in group1)
            {
                Console.WriteLine("Department: " + itemdepartment.Department.namedpm + " have:");
                foreach (var itemstaff in itemdepartment.Staff)
                {
                    Console.WriteLine("Staff: " + itemstaff.names);
                }
            }
            // use method syntax:
            var group2 = Department.getDepartment()
                            .GroupJoin(Staff.getStaff(),
                            d => d.iddpm,
                            e => e.iddpm,
            (department, staff) => new
            {
                Department = department,
                Staff = staff
            });
            Console.WriteLine(" use method syntax: group join");
            foreach (var itemdepartment in group2)
            {
                Console.WriteLine("Department: " + itemdepartment.Department.namedpm + " have:");
                foreach (var itemstaff in itemdepartment.Staff)
                {
                    Console.WriteLine("Staff: " + itemstaff.names);
                }
            }
            // inner join:
            // use query syntax:
            var innerjoin1 = from s in Staff.getStaff()
                             join d in Department.getDepartment()
                             on s.iddpm equals d.iddpm
                             select new
                             {
                                 StaffName  = s.names,
                                 DepartmentName = d.namedpm
                             };
            Console.WriteLine("Inner join:(use query syntax) ");
            foreach (var itemstaff in innerjoin1)
            {
                Console.WriteLine(" {0} - {1}",itemstaff.StaffName,itemstaff.DepartmentName);
            }
            // use method syntax:
            var innerjoin2 = Staff.getStaff().Join(Department.getDepartment(),
                                s => s.iddpm,
                                d => d.iddpm,
                                (staffA, departmentA) => new
                                {
                                    StaffName = staffA.names,
                                    DepartmentName = departmentA.namedpm
                                });

            Console.WriteLine("Inner join:(use method syntax) ");
            foreach (var itemstaff in innerjoin2)
            {
                Console.WriteLine(" {0} - {1}", itemstaff.StaffName, itemstaff.DepartmentName);
            }
            // left join:
            var leftjoin1 = from s in Staff.getStaff()
                            join d in Department.getDepartment()
                            on s.iddpm equals d.iddpm into sGroup
                            from d in sGroup.DefaultIfEmpty()
                            select new
                            {
                                StaffName = s.names,
                                DepartmentName = d == null ? "No department" : d.namedpm
                            };
            Console.WriteLine("Left join:(use method syntax) ");
            foreach (var itemstaff in leftjoin1)
            {
                Console.WriteLine(" {0} - {1}", itemstaff.StaffName, itemstaff.DepartmentName);
            }

            Console.ReadLine();
        }
    }
}
