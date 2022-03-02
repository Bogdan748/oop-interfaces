using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopInterfaces
{
    public abstract class Shape : IObjectWithArea, 
                                  ITranslatableObject, 
                                  IrotatetableObject
    {
        public Shape(params Point[] points)
        {
            this.Points = points ?? new Point[0];
        }
        public Point[] Points { get; }

        public abstract double Area { get; }

        public void Translate(int dx, int dy)
        {
            foreach(Point p in Points)
            {
                p.Translate(dx, dy);
            }
        }

        public void Rotate(double angleDegrees)
        {
            foreach (Point p in Points)
            {
                p.Rotate(angleDegrees);
            }
        }
    }
}
