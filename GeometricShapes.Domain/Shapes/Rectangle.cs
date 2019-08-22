using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes.Domain.Shapes
{
    public class Rectangle : Shape, IShape
    {
        public double Base { get; private set; }
        public double Height { get; private set; }

        public Rectangle(double Base, double Height)
        {
            this.Base = Base;
            this.Height = Height;
        }

        public Rectangle()
        {

        }

        public override double GetArea()
        {
            return this.Height * this.Base;
        }
    }
}
