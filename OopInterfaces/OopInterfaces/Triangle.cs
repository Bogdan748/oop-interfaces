using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopInterfaces
{
    class Triangle : Shape
    {
        public Triangle(Point p1, Point p2, Point p3)
            : base(p1, p2, p3)
        {
        }
        public override double GetArea()
        {
            // see: https://www.mathopenref.com/coordtrianglearea.html
            double area = Math.Abs(P1.X * (P2.Y - P3.Y) + P2.X * (P3.Y - P1.Y) + P3.X * (P1.Y - P2.Y)) / 2;

            return Math.Round(area, 2);
        }
    }
}
