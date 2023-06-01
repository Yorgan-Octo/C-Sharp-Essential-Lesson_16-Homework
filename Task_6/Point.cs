using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    public struct Point
    {

        public int X {  get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Point operator +(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public override string ToString()
        {
            return $"X - {X}; Y - {Y}; Z - {Z};";
        }

    }
}
