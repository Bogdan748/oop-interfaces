using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopInterfaces
{
    class GeometryUtils
    {
        public void Translate(int dx, int dy, params Point[] Points)
        {
            foreach (Point p in Points)
            {
                p.Translate(dx, dy);
            }
        }

        public void Rotate(double angleDegrees, params Point[] Points)
        {
            foreach (Point p in Points)
            {
                p.Rotate(angleDegrees);
            }
        }
    }
}
