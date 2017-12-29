using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop37_Inheritance
{
    public class Hinh
    {
        //class varibles
        protected int chieuDai;
        protected int chieuRong;
        //class get and set
        public int getChieuDai()
        {
            return this.chieuDai;
        }
        public int getChieuRong()
        {
            return this.chieuRong;
        }
        public void setChieuDai(int cdai)
        {
            chieuDai = cdai;            
        }
        public void setChieuRong(int crong)
        {
            chieuRong = crong;
        }            
    }
    //interface
    public interface PaintCost
    {
        int getCost(int area);
    }
    // inheritance
    class HinhChuNhat: Hinh, PaintCost
    {
        
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
