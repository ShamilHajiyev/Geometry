using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Square : Shape
    {
        public override double GetArea(double[] sizes)
        {
            double area = sizes[0] * sizes[0];
            return area;
        }

        public override double GetPerimeter(double[] sizes)
        {
            double area = 4 * sizes[0];
            return area;
        }
    }
}
