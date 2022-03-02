using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopInterfaces
{
    public static class AreaCalculator
    {
        public static double SumAreas(params IObjectWithArea[] objects)
        {
            double sum = 0;

            foreach (IObjectWithArea obj in objects)
            {
                sum += obj.Area;
            }

            return sum;
        }
    }
}
