using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Cop52_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            //them phan tu, khong giong nhu cac loai khac la add(), ma la  virtual void Enqueue(object obj).
            q.Enqueue("Mai Van Tu");
            q.Enqueue("Khanh Nhi");
            q.Enqueue("Trinh Hong Dao");
            q.Enqueue("Vu Xuan Quynh");
            q.Enqueue("Hong Dan");
            q.Enqueue("Hong Duong");
            // duyet queue.
            Console.WriteLine("\nMang vua tao la: ");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            /*Mang vua tao la:
                Mai Van Tu
                Khanh Nhi
                Trinh Hong Dao
                Vu Xuan Quynh
                Hong Dan
                Hong Duong
             * 
             */
            //virtual object Dequeue(): go bo phan tu dau tien cua Queue
            q.Dequeue();
            Console.WriteLine("\nMang vua go la: ");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            /*Mang vua go la:
                Khanh Nhi
                Trinh Hong Dao
                Vu Xuan Quynh
                Hong Dan
                Hong Duong
             */

            // virtual void Clear(): go bo tat cac phan tu trong Queue (comment lai de demo cac methods sau)
            /*
            q.Clear();            
            Console.WriteLine("\nMang sau khi vua clear la: ");//Mang sau khi vua clear la:
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            */

            // virtual bool Contains(object obj): 
            bool result = q.Contains("Khanh Nhi");
            //bool result = q.Contains("Mai Van Cop");
            if (result ==true)
            {
                Console.WriteLine("\nCo phan tu nay trong Queue");// danh cho Khanh Nhi
            }
            else
            {
                Console.WriteLine("\nKhong co phan tu nay trong Queue");// danh cho Mai Van Cop
            }

            //virtual void TrimToSize() : Thiết lập capacity tới số phần tử thực sự trong Queue, cai này vẫn chưa được hiểu, tìm hiểu sau
            //virtual object[] ToArray(): Sao chép Queue tới một mảng mới
            Object[] array =q.ToArray();
            Console.WriteLine("\nMang sau khi chuyen bang for: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("\nMang sau khi chuyen bang foreach: ");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

