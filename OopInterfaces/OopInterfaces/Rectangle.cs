using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopInterfaces
{
    class Rectangle : Shape
    {
            public Rectangle(Point topleft,int width, int height)
                    :base(topleft,
                         new Point(topleft.X+width, topleft.Y), //topRight
                         new Point(topleft.X + width, topleft.Y- height), //bottomRight
                         new Point(topleft.X, topleft.Y+height))//bottom
            {
                Width = width;
                Height = height;
            }

            public int Height { get; }

            public int Width { get; }

            public override double Area
            {
                get
                {
                    return Width * Height;
                }
            }
        
    }
}
