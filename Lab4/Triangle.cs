using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Triangle : Shape
    {
        public override void GetArea(double firstSide, double height)
        {
            double area = (firstSide * height) / 2;
            Console.WriteLine("\nThe area is: " + area);
        }

        public override void GetPerimeter(double firstSide, double secondSide)
        {
            double perimeter = firstSide + secondSide + 10;
            Console.WriteLine("\nThe perimeter is: " + perimeter);
        }
    }
}
