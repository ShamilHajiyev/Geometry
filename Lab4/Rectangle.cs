using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Rectangle : Shape
    {
        public override void GetArea(double width, double length)
        {
            double area = width * length;
            Console.WriteLine("\nThe area is: " + area);
        }

        public override void GetPerimeter(double width, double length)
        {
            double perimeter = 2 * (width + length);
            Console.WriteLine("\nThe perimeter is: " + perimeter);
        }
    }
}
