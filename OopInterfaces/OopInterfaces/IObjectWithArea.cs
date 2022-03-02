using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopInterfaces
{
    public interface IObjectWithArea
    {
        double Area { get; }
    }

    public abstract class Shape : IObjectWithArea
    {

        public abstract double Area { get; }
    }

    
    public class SheetOfPaper : IObjectWithArea
    {
        public SheetOfPaper(SheetOfPaerFormat format)
        {
            Format = format;
            switch (format)
            {
                case SheetOfPaerFormat.A0:
                    Area = 100;
                    break;
                case SheetOfPaerFormat.A1:
                    Area = 50;
                    break;
                case SheetOfPaerFormat.A2:
                    Area = 20;
                    break;
                case SheetOfPaerFormat.A3:
                    Area = 10;
                    break;
                case SheetOfPaerFormat.A4:
                    Area = 5;
                    break;
            }
        }
        public SheetOfPaerFormat Format { get; }
        public double Area { get; }

    }

    public enum SheetOfPaerFormat
    {
        A0=0,
        A1,
        A2,
        A3,
        A4
    }

    public static class AreaCalculator
    {
        public static double SumAreas (params IObjectWithArea[] objects)
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
