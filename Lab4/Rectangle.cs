﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Rectangle : Shape
    {
        public override double GetArea(double[] sizes)
        {
            double area = sizes[0] * sizes[1];
            return area;
        }

        public override double GetPerimeter(double[] sizes)
        {
            double perimeter = 2 * (sizes[0] + sizes[1]);
            return perimeter;
        }
    }
}
