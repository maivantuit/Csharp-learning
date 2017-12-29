using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cop48_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Xem double ArrayList = > F12 , hoặc Go to Definition
            ArrayList arr = new ArrayList();
            arr.Add(4);
            arr.Add(4.8);
            arr.Add("Mai Văn Tú");
            arr.Add('K');
            // In ra danh sách add trên
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
            // Dùng foreach để duyệt array list
            foreach (var elements in arr)
            {
                Console.WriteLine(elements);
            }
            Console.ReadLine();
            /*
             * 4
                4.8
                Mai Van Tú
                K
             */ 
        }
    }
}

