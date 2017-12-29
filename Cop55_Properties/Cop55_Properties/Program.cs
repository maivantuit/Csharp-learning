using System;

namespace Cop55_Properties
{
    //Một điểm mới của ngôn ngữ C#.
    class SinhVien
    {
        //Tạo các fields, trường
        private string hoten;
        private int namsinh;
        private double diemtoan;
        private double diemhoa;
        //Tạo property (thuộc tính) cho hoten.
        public string HoTen
        {
            get
            {
                return hoten;
            }
            set
            {
                hoten = value;
            }
        }
        //Tạo property cho namsinh
        public int NamSinh
        {
            get
            {
                return namsinh;
            }
            set
            {
                namsinh = value;
                     
            }
        }
        //Tao property cho diemtoan
        public double DiemToan
        {
            get
            {
                return diemtoan;
            }
            set
            {
                
                    diemtoan = value;
               
            }
        }
        //Tao property cho diemhoa
        public double DiemHoa
        {
            get
            {
                return diemhoa;
            }
            set
            {
                diemhoa = value;
                /*
                if (DiemHoa <= 10 && DiemHoa >= 0)
                {
                    diemhoa = value;
                   
                }
                else {
                    Console.WriteLine("Diem khong hop le");
                    // throw new Exception("Diem khong hop le!");
                }
                Khi sử dụng ràng buộc này đúng sai gì nó cũng chạy ra, vậy tại sao
                */

            }
        }
        //Tạo property cho điểm trung bình. Ở đây ta không cần tạo 1 fileds DTB, bởi vì dữ thừa dữ liệu. Ta tạo 1 property cho nó và gán kết quả
        public double DiemTrungBinh
        {
            get
            {
                return (DiemHoa + DiemToan) / 2;
            }
            set
            {
                //không cần gán
            }
        }
        //Xuat
        public void Xuat()
        {
            Console.WriteLine("Ho ten: {0}, Nam Sinh: {1}, Diem Tring Binh: {2}",HoTen,NamSinh,DiemTrungBinh);
        }
    }    
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv1 = new SinhVien();
            sv1.HoTen = "Mai Van Tu";
            sv1.NamSinh = 1995;
            sv1.DiemHoa = 8;
            sv1.DiemToan = 10;
            sv1.Xuat();//Ho ten: Mai Van Tu, Nam Sinh: 1995, Diem Tring Binh: 9
            Console.ReadLine();
            
        }
    }
}
