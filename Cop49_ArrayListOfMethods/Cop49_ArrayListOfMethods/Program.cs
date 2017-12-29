using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop49_ArrayListOfMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add(4);
            arr.Add(7);
            arr.Add(3);
            arr.Add(10);
            arr.Add(2);            
            arr.Add(9);
            arr.Add(1);
            // duyet arraylist bang for           
            Console.Write("Mang in cua for loop: ");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(" "+arr[i]);//Mang in cua for loop: 4 7 3 10 2 9 1                
            }
            // duyet arraylist bang foreach
            Console.Write("\nMang in cua foreach loop: ");
            foreach (var item in arr)
            {
                Console.Write(" "+item);// Mang in cua foreach loop:  4 7 3 10 2 9 1
            }
            // virtual  int add(object value): them gia tri, no them vao cuoi cung.
            Console.Write("\nMang in sau khi add: ");
            arr.Add(11);
            foreach (var item in arr)
            {
                Console.Write(" " +item);//Mang in sau khi add 4 7 3 10 2 9 1 11
            }
            // virtual  void addrange(ICollection c): Thêm các phần tử của một ICollection (I: la interface) vào phần cuối của ArrayList => Thu chua hieu, tim hieu sau.

            // virtual  void clear(): (Tech) xóa, gỡ bỏ tất cả các phần tử trong arraylist, (comment lại, để biểu diễn các methods sau)
            /*
            Console.Write("\nMang in sau khi clear: \n");
            arr.Clear();
            foreach (var item in arr)
            {
                Console.Write(" " + item);//Mang in sau khi clear: <bi rong>
            }
            */

            // virtual bool Contains(object item): (Tech): chứa, kiểm tra phần tử có trong arraylist không.
            //bool reult = arr.Contains(10);
            bool reult = arr.Contains(100);
            if (reult==true) // == nhé
            {
                Console.WriteLine("\nCo phan tu trong arraylist"); //danh cho: 10
            }
            else
            {
                Console.WriteLine("\nKhong phan tu trong arraylist");//danh cho: 100
            }
            // virtual ArrayList GetRange(int index, int count): trả về là kiểu arraylist, biểu diễn một tập con của các phần tử trong ArrayList nguồn => van chua hieu duoc, tim  hieu sau (comment lai)
            /*
            Console.WriteLine("\nMang sau khi getrange: ");
            ArrayList a =arr.GetRange(0,8);
            Console.WriteLine(a);
            */

            // virtual int IndexOf(object): trả về kiểu int, là số index, lần xuất hiện đầu tiên của phần tử trong arraylist.(nếu là 2 số 10 thì nó lấy index xuất hiện đầu tiên của mảng theo thứ tự)
            int result3 = arr.IndexOf(10);
            Console.WriteLine("Ket qua cua IndexOf: "+result3);//Ket qua cua IndexOf: 3                        

            //virtual void Insert(int index, object value): chèn 1 giá trị kiểu đối tượng vào index được chỉ định (comment lại, để phù hợp nhớ các phần tử từ trước)
            /*
            arr.Insert(1,99);
            Console.Write("\nMang sau chen so 99 vao index 1: ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);//Mang sau chen so 99 vao index 1:  4 99 7 3 10 2 9 1 11
            }
            */

            // virtual void InsertRange(int index, ICollection c): Chèn một phần tử của một collection vào ArrayList tại chỉ mục đã xác định - Vẫn chưa hiểu chèn 1 Icollection c, tìm hiểu sau. (comment lại)
            //arr.InsertRange(1,?);

            // virtual void Remove(object obj): xóa 1 đối tượng kiểu object được chỉ định.
            Console.Write("\nMang truoc khi remove: ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);//Mang truoc khi remove:  4 7 3 10 2 9 1 11
            }
            arr.Remove(11);
            Console.Write("\nMang sau khi remove: ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);//Mang sau khi remove:  4 7 3 10 2 9 1
            }

            //virtual void RemoveAt(int index): xóa 1 đối tượng tại 1 index cụ thể.
            arr.RemoveAt(6);
            Console.Write("\nMang sau khi removeat tai index 6: ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);//Mang sau khi removeat tai index 6:  4 7 3 10 2 9
            }
            //virtual void RemoveRange(int index, int count): xóa phần tử từ index cụ thể với số lượng cụ thể. từ trái sang phải (comment lại để có dữ liệu review cái methods sau)
            /*
            arr.RemoveRange(1,5);
            Console.Write("\nMang sau khi removerange tu index 1 voi so luong 5: ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);//Mang sau khi removerange tu index 1 voi so luong 5:  4
            }
            */
            // virtual void SetRange(int index, ICollection c): Sao chép các phần tử của một collection qua một dãy các phần tử trong ArrayList, Icollection: minh van chua hinh dung duoc, tim hieu sau

            // virtual void TrimToSize(): Thiết lập capacity tới số phần tử thực sự trong ArrayList, capacity: (Tech) dung lượng; khả năng; năng lực; công suất

            // Console.WriteLine(arr.TrimToSize()); // Error: 

            // virtual void Sort(): sap xep tang dan. mac dinh la nhu vay.
            // virtual void Reverse(): dao nguoc thu tu phan tu trong arraylist
            // 2 methods ket hop de sap xep giam dan.
            arr.Sort();
            Console.Write("\nMang sau khi sap xep mac dinh la tang dan: ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);//Mang sau khi sap xep:  2 3 4 7 9 10
            }
            arr.Reverse();
            Console.Write("\nMang sau khi dao nguoc, truoc dc sap xep tang dan ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);//Mang sau khi dao nguoc, truoc dc sap xep tang dan  10 9 7 4 3 2
            }
            Console.ReadLine();// nên bỏ cái này đúng chỗ, bỏ giữa, những câu lệnh sau không được thực thi
        }
    }
}
