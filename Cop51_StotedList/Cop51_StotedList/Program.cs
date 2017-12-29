using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop51_StotedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add("4", "Song Anh");
            sl.Add("5", "Truong Duyen");
            sl.Add("6", "Tran The");
            sl.Add("1", "Mai Van Tu");
            sl.Add("2", "Khanh Nhi");
            sl.Add("3", "Vu Xuan Quynh");
            //duyet collection, lay tap hop cac key
            ICollection key = sl.Keys;
            //dung foreach de duyet sortedlist
            foreach (var item in key)
            {
                Console.WriteLine(item + ": "+ sl[item]);
            }
            /*1: 1: Mai Van Tu
                    2: Khanh Nhi
                    3: Vu Xuan Quynh
                    4: Song Anh
                    5: Truong Duyen
                    6: Tran The
                => ket qua da duoc sap xep theo thu tu cua key.(neu key la a,b,c thi sao?=> no cung sap xep theo thu tu anlphabe(da kiem thu))
             */
            // Doi voi cac thuoc tinh, chua hieu ro cach thuc cua chung

            // virtual void Add(object key, object value): them 1 phan tu key/value, duoc sap xep thu tu trong sortedlist theo key. (co the la so, co the la chu cai)
            sl.Add("0","Hong Dao");
            sl.Add("7","Hong Dan");
            Console.WriteLine("\nMang sau khi add: 0/HongDao, 7/HongDan: ");
            foreach (var item in key)
            {
                Console.WriteLine(item+ ": "+sl[item]);
            }
            /*
             * Mang sau khi add: 0/HongDao, 7/HongDan:
                0: Hong Dao
                1: Mai Van Tu
                2: Khanh Nhi
                3: Vu Xuan Quynh
                4: Song Anh
                5: Truong Duyen
                6: Tran The
                7: Hong Dan
             */

            // virtual void Clear(): go bo tat ca cac phan tu co trong sortedlist (comment lai, de demo cac methods of sortedlist tiep)
            /*
            sl.Clear();
            Console.WriteLine("\nMang sau khi da clear: ");
            foreach (var item in key)
            {
                Console.WriteLine(item+ ": "+sl[item]);//Mang sau khi da clear:
            }
            */

            //bool ContainsKey(object key): tra ve kieu luan ly, parameter pass la obj key: => Kiem tra key nay co ton tai, (dc chua) trong SortedList hay khong.
            //bool result = sl.ContainsKey("1");
            bool result = sl.ContainsKey("100");
            if (result == true)
            {
                Console.WriteLine("\nTrong SortedList co key nay");// danh cho key "1"
            }
            else
            {
                Console.WriteLine("\nTrong SortedList khong co key nay"); // danh cho key "100"
            }

            // bool ContainsValue(object value): Cung tuong tu nhu ContainsValue: Kiem tra 1 gia tri co ton tai trong SortedList hay khong.
            bool result2 = sl.ContainsValue("Mai Van Tu");
            //bool result2 = sl.ContainsKey("Mai Van Cop");
            if (result2 == true)
            {
                Console.WriteLine("\nTrong SortedList co value nay");// danh cho value "Mai Van Tu"
            }
            else
            {
                Console.WriteLine("\nTrong SortedList khong co value nay"); // danh cho value "Mai Van Cop"
            }

            //virtual object GetByIndex(int index): lay gia tri tai index duoc dinh san trong SortedList
            Object ojb1 = sl.GetByIndex(1);// nên nhớ là index
            Console.WriteLine("\nGia tri da lay tai index/1: "+ojb1);//Gia tri da lay tai index/1: Mai Van Tu
            /*
             * Chú ý về các lấy index:
             *  - Nếu trong Sorted có key theo thứ tự là số, thì số index = số mã key(ket qua nhu tren) 
             *  - Nếu trong Sorted có key vừa là chữ, vùa là số, thì số index = sẽ lấy bắt đầu các key có số theo thứ tự.(index: 1 2 3 4 ; key 2 4 7 'A' 9 thì 1=2, 2=4, 3=7, 4=9) =: lay tai
             */ 

            // virtual object GetKey(int index): lay key tai index duoc dinh san trong SortedList
            Object ojb2 =sl.GetKey(1);
            Console.WriteLine("\nKey vua lay tai index/1: "+ojb2);
            //Key vua lay tai index/1: 1 ()
            /*
            * Chú ý về lấy key bằng index:
            *  - Nếu trong Sorted có các key là thứ tự số, thì số index = số mã key (kết quả cho ta thấy điều đó)
            *  - Nếu trong Sorted có các key, key = so, key = chu. Thì thì số index = sẽ lấy bắt đầu các key có số theo thứ tự.(nghia la. index: 1 2 3 4 ; key 2 'A' 4 7 9 thì 1=2, 2=4, 3=7, 4=9) =: lay tai
            */

            //  virtual IList GetKeyList(): Lay danh sach key co trong SortedList
            IList il = sl.GetKeyList();
            Console.WriteLine("\nDanh sach cac key trong SortedList: "+il);//Danh sach cac key trong SortedList: System.Collections.SortedList+KeyList
            // minh co the dung forech de lay cac key, dung lay dc bang cach duoi.
            Console.WriteLine("\nDanh sach key trong SortedList lay bang foreach: ");
            foreach (var item in key)
            {
                Console.WriteLine(item); // item khac i(for nhe), neu key la 100 thi van lay ma k phai 100 la 8.
            }
            /*  0
                1
                3
                2   
                4
                5
                6
                7                
             */

            //virtual IList GetValueList(): lay danh sach gia tri trong SortedList
            IList il2 = sl.GetValueList();
            Console.WriteLine("\nDanh sach gia tri trong SortedList: "+il2);//Danh sach gia tri trong SortedList: System.Collections.SortedList+ValueList
            // minh co the lay vua key vua gia tri bang cach duoi.
            Console.WriteLine("\nDanh sach value trong SortedList lay bang foreach: ");
            foreach (var item in key)
            {
                Console.WriteLine(item + ": "+sl[item]); // 
            }
            // => 2 cach getkeylist() va getvaluelist minh co the dung foreach.
            // nhung doi voi cach lay 1 thi chua duoc ro. tim hieu them

            //  virtual int IndexOfKey(object key):Tra ve index duoc lay bang key.
            int result3 = sl.IndexOfKey("1");
            Console.WriteLine("\nIndex duoc lay bang key/1: "+result3);//1
            // Neu vua key so, vua key chu: ket qua duoc giai thich nhu GetByIndex() va GetKey().

            // virtual int IndexOfValue(object value): tra ve
            int result4 = sl.IndexOfValue("Mai Van Tu");
            Console.WriteLine("\nIndex duoc lay bang value/Mai Van Tu: "+result4);//Index duoc lay bang value/Mai Van Tu: 1
            // Neu vua key so, vua key chu: ket qua duoc giai thich nhu GetByIndex() va GetKey().

            //void Remove(object key): Xoa 1 phan tu tai key duoc chi dinh.
            // virtual void RemoveAt(int index): xoa 1 phan tu tai index duoc chi dinh
            Console.WriteLine("\nSortedList truoc khi xoa: ");
            foreach (var item in key)
            {
                Console.WriteLine(item+ ": "+sl[item]);
            }
            sl.Remove("6");// tai key
            sl.RemoveAt(5); // tai index
            Console.WriteLine("\nSortedList sau khi xoa 6/TranThe va 5/TruongDuyen: ");
            foreach (var item in key)
            {
                Console.WriteLine(item + ": " + sl[item]);
            }
            /*
             * SortedList truoc khi xoa:
                0: Hong Dao
                1: Mai Van Tu
                2: Khanh Nhi
                3: Vu Xuan Quynh
                4: Song Anh
                5: Truong Duyen
                6: Tran The
                7: Hong Dan

                SortedList sau khi xoa 6/TranThe va 5/TruongDuyen:
                0: Hong Dao
                1: Mai Van Tu
                2: Khanh Nhi
                3: Vu Xuan Quynh
                4: Song Anh
                7: Hong Dan
             */

            // virtual void TrimToSize(): Thiết lập capacity tới số phần tử thực sự trong SortedList
            sl.TrimToSize();            
            //thiet lap? van chua hieu ve cai nay, tim hieu sau.
            Console.ReadLine();
            //Vi SortedList vua la ArrayList, vua la HashTable nen nhieu methods kem theo.
            
        }
    }
}
