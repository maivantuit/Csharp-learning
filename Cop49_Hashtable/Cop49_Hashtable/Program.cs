using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Cop49_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("4", "Song Anh");
            ht.Add("5", "Truong Duyen");
            ht.Add("7", "Tran The");
            ht.Add("1", "Mai Van Tu");
            ht.Add("2", "Khanh Nhi");
            ht.Add("3", "Vu Xuan Quynh");
           

            // lay tap hop cac key, doi voi hashtable phai co cai nay, de lay ra tap hop key.
            ICollection key = ht.Keys;
            // duyệt hashtable
            foreach (string k in key)
            {
                Console.WriteLine(" "+k + ": " + ht[k]);
            }
            /*   1: Mai Van Tu
                2: Khanh Nhi
                3: Vu Xuan Quynh
                4: Song Anh
                5: Truong Duyen
                6: Tran The
                => nó tự sắp xếp key.
            */
            // virtual void Add(object key, object value): thêm 1 value/ key.
            ht.Add("0", "Hong Dao");
            ht.Add("6","Ngoc Chau");
            ht.Add("8", "Phuong Quynh");
            Console.WriteLine("\nMang sau khi them 0/HongDao, 6/NgocChau va 8/PhuongQuynh: ");
            foreach (string k in key)
            {
                Console.WriteLine(" " + k + ": " + ht[k]);
            }
            /*
             * Mang sau khi them 0/HongDao, 6/NgocChau va 8/PhuongQuynh:
             0: Hong Dao
             1: Mai Van Tu
             2: Khanh Nhi
             3: Vu Xuan Quynh
             4: Song Anh
             5: Truong Duyen
             6: Ngoc Chau
             7: Tran The
             8: Phuong Quynh
             => kết quả thêm sẽ thêm vào thứ tự tăng dần của key tương ứng, kết quả cho thấy điều đó.
             */

            // virtual void Clear(): Gỡ bỏ tất cả phần tử từ Hashtable (comment lai de demo cac methods tiep theo)
            /*
            ht.Clear();
            Console.WriteLine("\nHasble sau khi clear: ");
            foreach (string k in key)
            {
                Console.WriteLine(" " + k + ": " + ht[k]);//Hasble sau khi clear:
            }
            */

            // virtual bool ContainsKey(object key): kiểm tra key bất kỳ có thuộc hashtable không
            //bool result = ht.ContainsKey("1");
            bool result = ht.ContainsKey("12");

            if (result == true)
            {
                Console.WriteLine("\nCo key nay trong hashtable");// danh cho key "1"
            }
            else
            {
                Console.WriteLine("\nKhong co key nay trong hashtable"); //danh cho key "12"
            }

            // bool ContainsValue(object value): kiểm tra giá trị có trong hashtable không
            //bool result2 = ht.ContainsValue("Mai Van Tu");
            bool result2 = ht.ContainsValue("Mai Van Cop");
            if (result2 == true)
            {
                Console.WriteLine("\nCo phan tu nay trong hashtable"); // danh cho phan tu "Mai Van Tu"
            }
            else
            {
                Console.WriteLine("\nKhong co phan tu nay trong hashtable");// danh cho phan tu "Mai Van Cop"
            }

            // void Remove(object key): Xóa 1 phần tử bằng key tương ứng
            ht.Remove("8");
            ht.Remove("6");
            Console.WriteLine("\nMang sau khi xoa key/8 va key/6: ");
            foreach (string k in key)
            {
                Console.WriteLine(" " + k + ": " + ht[k]);
            }
            /*
             * Mang sau khi xoa key/8 va key/6:
             0: Hong Dao
             1: Mai Van Tu
             2: Khanh Nhi
             3: Vu Xuan Quynh
             4: Song Anh
             5: Truong Duyen
             7: Tran The
             */
            Console.ReadLine();
        }
    }
}
