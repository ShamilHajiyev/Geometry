using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    abstract class Shape
    {
        public double[] Sizes;
        public byte N;

        public abstract double GetArea(double[]sizes);

        public abstract double GetPerimeter(double[] sizes);
    }
}
