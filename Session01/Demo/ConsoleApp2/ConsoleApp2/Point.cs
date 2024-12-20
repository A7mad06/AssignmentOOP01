using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal struct Point
    {
        public int x;
        public int y;
        //------------------------
        //Constructor: is special function
        //1 named always as class or struct name
        //2 has no return
        public Point()
        {
            x = 0;y = 0;
        }
        public Point(int _x,int _y)
        {
            x = _x;
            y = _y;
        }
        public override string ToString()
        {
            return $"x={x} and y={y}";
        }
    }
}
