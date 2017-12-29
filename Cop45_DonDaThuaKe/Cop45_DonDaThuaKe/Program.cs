using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop45_DonDaThuaKe
{
    //1 class chỉ có thể đơn thừa kế class, không thể thừa kế nhiều class
    //1 class chỉ có thể đơn thừa kế 1 abstract class
    //1 class không thể vừa thừa kế class, vừa thừa kế abstract class
    //1 class thực thi nhiều interface
    //1 class có thể vừa đơn thừa kế 1 abstract class, vừa đa thừa kế (đa thực thi) nhiều interface
    class A1
    { }
    class A2
    { }
    class A3 : A6, A7
    { }
    abstract class A4
    { }
    abstract class A5
    { }
    interface A6
    { }
    interface A7
    { }
    // 1 abstract class chỉ đơn thừa 1 abstrac class, không thể thừa kế nhiều abstract class
    // 1 abstract class chỉ thừa 1 class, không đa thừa kế nhiều class
    // 1 abstract class đa thừa kế (thực thi) interface
    // 1 abstract class vừa đơn thừa kế 1 class (hoặc abstrac class), vừa nhiều interface
    abstract class B1
    {}
    abstract class B2: B4
    { }
    abstract class B3 : B4, B6, B7
    { }
    class B4
    {}
    class B5
    {}
    interface B6
    {}
    interface B7
    {}
    // 1 interface thừa kế 1 interface
    // 1 interface thực thi nhiều interface    
    // 1 interface không thừa kế class hay abstract class. Nó chỉ thực thi các interface khác.
    interface C1
    { }
    interface C2 
    { }
    interface C3 : C1, C2
    { }
    class C4
    { }
    class C5
    { }
    abstract class C6 { }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
