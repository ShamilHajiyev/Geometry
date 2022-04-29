using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select a shape:\n\n1.Rectangle\n\n2.Triangle\n");
                byte selection = Convert.ToByte(Console.ReadLine());
                byte action;
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("\n\nEnter the action:\n\n1.Calculate the Area\n\n2.Calculate the Perimeter\n");
                        action = Convert.ToByte(Console.ReadLine());
                        double width;
                        double length;
                        Rectangle rect = new Rectangle();
                        switch (action)
                        {
                            case 1:
                                Console.WriteLine("\nEnter the width:");
                                width = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("\nEnter the length:");
                                length = Convert.ToDouble(Console.ReadLine());
                                rect.GetArea(width, length);
                                break;
                            case 2:
                                Console.WriteLine("\nEnter the width:");
                                width = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("\nEnter the length:");
                                length = Convert.ToDouble(Console.ReadLine());
                                rect.GetPerimeter(width, length);
                                break;
                            default:
                                Console.WriteLine("\nPlease, select a valid number.");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("\n\nEnter the action:\n\n1.Area\n\n2.Perimeter\n");
                        action = Convert.ToByte(Console.ReadLine());
                        double firstSide;
                        double secondSide;
                        double height;
                        Triangle trig = new Triangle();
                        switch (action)
                        {
                            case 1:
                                Console.WriteLine("\nEnter the base side:");
                                firstSide = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("\nEnter the height:");
                                height = Convert.ToDouble(Console.ReadLine());
                                trig.GetArea(firstSide, height);
                                break;
                            case 2:
                                Console.WriteLine("\nEnter the first side:");
                                firstSide = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("\nEnter the second side:");
                                secondSide = Convert.ToDouble(Console.ReadLine());
                                Triangle obj2 = new Triangle();
                                obj2.GetPerimeter(firstSide, secondSide);
                                break;
                            default:
                                Console.WriteLine("Please, select a valid number.");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Please, select a valid number.");
                        break;
                }
            }
        }
    }
}
