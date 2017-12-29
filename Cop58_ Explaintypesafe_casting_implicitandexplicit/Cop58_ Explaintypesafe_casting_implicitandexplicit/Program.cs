using System;
using System.Collections.Generic;

namespace Cop58__Explaintypesafe_casting_implicitandexplicit
{
    class Program
    {      

        class Shape
        {
            protected int x;
            protected int y;
            public int HEIGHT
            {
                set;
                get;
            }
            public int X
            {
                set;
                get;
            }
            public Shape() { }
            public Shape(int x, int y) {
                this.x = x;
                this.y = y;
            }
            public virtual void Draw()
            {
                Console.WriteLine("Drawing a SHAPE at {0}, {1}",x,y);
            }
        }
        class Circle :Shape
        {
            public Circle() { }
            public Circle(int x, int y):base(x,y) { }
            public override void Draw()
            {
                Console.WriteLine("Drawing a CIRCLE at {0}, {1}", x, y);
            }
            public void FillCircle()
            {
                Console.WriteLine("Fill a CIRCLE at {0}, {1}", x, y);
            }
        }
        class Square : Shape
        {
            public Square() { }
            public Square(int x, int y):base(x,y) { }
            public override void Draw()
            {
                Console.WriteLine("Drawing a Square at {0}, {1}", x, y);
            }
            public void FillSquare()
            {
                Console.WriteLine("Fill a Square at {0}, {1}", x, y);
            }
        }
        static void Main(string[] args)
        {

            //Up-casting:
            Shape s = new Circle(100, 100);
            //Down-casting:
            Shape s2 = new Circle(100, 100);
            //how to call methods FillCircle in Circle class ?:
            //s.FillCircle :error, 'cuz s not is a Circle however Circle is a Shape. So cast "s" to Circle type, then call this method.
            Circle c = (Circle)s;
            c.FillCircle();
            // or is: ((Circle)s).FillCircle();
            // using as: c # cung cấp từ khoá "as" để nhanh chóng xác định tại RunTime cho dù một kiểu nào đó có tương thích với nhau bằng cách kiểm tra đối với giá trị trả về null
            Circle c2 = s as Circle;
            if (c != null)
            {
                c.FillCircle();
            }
            // using is:là từ khóa để xác định xem hai mục có tương thích hay không, return false nếu kiểu là không tương thích
            List<Shape> shapes = new List<Shape>{new Shape(3, 4), new Shape(6,5), new Shape(8,7), new Shape(9,9)};
            foreach (Shape shape in shapes)
            {
                shape.Draw();
                if (shape is Circle)
                {                    
                    ((Circle)shape).FillCircle();
                }
                if (shape is Square)
                {                    
                    ((Square)shape).FillSquare();
                }
            }
            Console.ReadLine();
        }
    }
}
