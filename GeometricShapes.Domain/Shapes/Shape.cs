using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes.Domain.Shapes
{
    public abstract class Shape : IShape
    {
        public abstract double GetArea();
    }
}
