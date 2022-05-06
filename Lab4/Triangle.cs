using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Triangle : Shape
    {
        public override double GetArea(double[] sizes)
        {
            double area = (sizes[0] * sizes[1]) / 2;
            return area;
        }

        public override double GetPerimeter(double[] sizes)
        {
            double perimeter = sizes[0] + sizes[1] + sizes[2];
            return perimeter;
        }
    }
}
