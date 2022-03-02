using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopInterfaces
{
    public class SheetOfPaper : IObjectWithArea , ITranslatableObject
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

        public void Translate(int dx, int dy)
        {
            Console.WriteLine($"S-a miscat foaia");
        }
    }
}
