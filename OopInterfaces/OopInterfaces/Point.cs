using System;

namespace OopInterfaces
{
    public class Point : ITranslatableObject, IrotatetableObject
    {
		public Point(double x, double y)
		{
			X = x;
			Y = y;
		}

		public double X { get; private set; } 

		public double Y { get; private set; }

        public void Rotate(double angleDegrees)
        {
			double angleRadians = (Math.PI / 180) * angleDegrees;

			// see: https://en.wikipedia.org/wiki/Rotation_matrix
			double originalX = X;
			double originalY = Y;

			X = originalX * Math.Cos(angleRadians) - originalY * Math.Sin(angleRadians);
			Y = originalX * Math.Sin(angleRadians) + originalY * Math.Cos(angleRadians);
		}

        public void Translate(int dx, int dy)
        {
            Y += dy;
            X += dx;
        }
    }
}
