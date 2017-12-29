using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncDelegate
{
    class Product
    {
        int id;
        string name;
        int price;
        public Product(int i, string n, int p)
        {
            this.id = i;
            this.name = n;
            this.price = p;
        }
        public int ID
        {
            set
            {
                this.id = ID;
            }
            get
            {
                return id;
            }
        }
        public int PRICE
        {
            set
            {
                this.price = PRICE;
            }
            get
            {
                return price;
            }
        }
        public string NAME
        {
            set
            {
                this.name = NAME;
            }
            get
            {
                return name;
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>() {
                new Product(1, "Coca",300),
                new Product(2, "pepsi",200),
                new Product(3, "suprire",400),
                new Product(4, "milk",250),
                new Product(5, "yaua",700),                
            };
            Console.WriteLine("--- Tat ca cac san pham: ");
            foreach (Product item in list)
            {
                Console.WriteLine(item.ID+" "+item.NAME+" "+item.PRICE);
            }
            /// Question:tìm sản phẩm có giá từ 300 -> 600   
            Func<Product, bool> tim1 = (sanpham => sanpham.PRICE >= 300 && sanpham.PRICE <= 600);
            // cách 1:          
            var kq1 = from sanpham in list
                      where tim1(sanpham)
                      select sanpham;
            Console.WriteLine("--- Cac san pham co gia tu 300->600: ");
            foreach (Product item in kq1) // kiểu dữ liệu var vẫn ok.
            {
                Console.WriteLine(item.ID + " " + item.NAME + " " + item.PRICE);
            }
            // cách 2: 
            Console.WriteLine("--- Cac san pham co gia tu 300->600: ");
            var kq2 = list.Where(tim1);
            foreach (Product item in kq2) // kiểu dữ liệu var vẫn ok.
            {
                Console.WriteLine(item.ID + " " + item.NAME + " " + item.PRICE);
            }
            //cách 3:
            Console.WriteLine("--- Cac san pham co gia tu 300->600: ");
            var kq3 = list.Where(sanpham => sanpham.PRICE >= 300 && sanpham.PRICE <= 600);
            foreach (Product item in kq3) // kiểu dữ liệu var vẫn ok.
            {
                Console.WriteLine(item.ID + " " + item.NAME + " " + item.PRICE);
            }
            Console.ReadLine();                            
        }
    }
}
/*
    result:
    --- Tat ca cac san pham:
1 Coca 300
2 pepsi 200
3 suprire 400
4 milk 250
5 yaua 700
--- Cac san pham co gia tu 300->600:
1 Coca 300
3 suprire 400
--- Cac san pham co gia tu 300->600:
1 Coca 300
3 suprire 400
--- Cac san pham co gia tu 300->600:
1 Coca 300
3 suprire 400

*/
