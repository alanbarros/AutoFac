using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes.Domain.Shapes
{
    public class Square : Shape, IShape
    {
        public double Side { get; private set; }

        public Square(double side)
        {
            Side = side;
        }
        public Square()
        {

        }
        public override double GetArea()
        {
            return Math.Pow(Side, 2);
        }
    }
}
