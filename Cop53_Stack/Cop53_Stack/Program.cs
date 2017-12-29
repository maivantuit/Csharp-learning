using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop53_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();            
            st.Push("Mai Van Tu");
            st.Push("Khanh Nhi");
            st.Push("vu Xuan Quynh");
            st.Push("Hong Dan");
            st.Push("Tran The");
            st.Push("Hong Duong");
            //duyet Stack
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            // Ket qua: vao truoc ra sau: 
            /*Hong Duong
                Tran The
                Hong Dan
                vu Xuan Quynh
                Khanh Nhi
                Mai Van Tu
             */
            //void Push(object obj): chen phan tu tren cung vao Stack(vao sau ra truoc).            
            st.Push("Trinh Hong Dao");
            Console.WriteLine("\nMang sau khi them/TrinhHongDao: ");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            /*Mang sau khi them/TrinhHongDao:
                Trinh Hong Dao
                Hong Duong
                Tran The
                Hong Dan
                vu Xuan Quynh
                Khanh Nhi
                Mai Van Tu

             */
            //virtual object Pop(): Xoa di phan tu tren cung cua Stack.
            Console.WriteLine("\nMang truoc pop: ");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            Object oje1 = st.Pop();
            Console.WriteLine("\nSau khi Pop:  "+oje1);
            Console.WriteLine("\nMang sau pop: ");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            /*
             * Mang truoc pop:
                Trinh Hong Dao
                Hong Duong
                Tran The
                Hong Dan
                vu Xuan Quynh
                Khanh Nhi
                Mai Van Tu
             * Sau khi Pop:  Trinh Hong Dao
                Mang sau pop:
                Hong Duong
                Tran The
                Hong Dan
                vu Xuan Quynh
                Khanh Nhi
                Mai Van Tu
             */
            //virtual void Clear(): go bo tat ca cac phan tu trong Stack (comment lai de demo cac methods tiep theo)
            /*
            st.Clear();
            Console.WriteLine("\nStack sau clear: ");
            foreach (var item in st)
            {
                Console.WriteLine(item);//Stack sau clear:
            }
            */

            //virtual bool Contains(object obj): kiem tra doi tuong co ton tai trong stack
            bool result = st.Contains("Khanh Nhi");
            //bool result = st.Contains("Mai Van Cop");
            if (result == true)
            {
                Console.WriteLine("\nCo phan tu nay trong stack");//Danh cho Khanh Nhi
            }
            else
            {
                Console.WriteLine("\nKhong co phan tu nay trong stack");// Danh cho Mai Van Cop
            }
            // virtual object[] ToArray(): Sao chép Stack tới một mảng mới
            Object[] array = st.ToArray();
            Console.WriteLine("\nMang sau khi chuyen tu Stack: ");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            /* Mang sau khi chuyen tu Stack:
                Hong Duong
                Tran The
                Hong Dan
                vu Xuan Quynh
                Khanh Nhi
                Mai Van Tu
             */
            Console.ReadLine();
        }
    }
}
