using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a shape:\n\n1.Rectangle\n\n2.Triangle\n\n3.Square\n");
            byte selection = Convert.ToByte(Console.ReadLine());

            byte action;
            double[] sizes;

            switch (selection)
            {
                case 1:
                    Rectangle rect = new Rectangle();
                    Console.WriteLine("\n\nEnter the action:\n\n1.Calculate the Area\n\n2.Calculate the Perimeter\n");
                    action = Convert.ToByte(Console.ReadLine());
                    switch (action)
                    {
                        case 1:
                            rect.N = 2;
                            sizes = new double[rect.N];
                            ArrayInput(sizes);
                            Console.WriteLine("Area: " + rect.GetArea(sizes));
                            break;
                        case 2:
                            rect.N = 2;
                            sizes = new double[rect.N];
                            ArrayInput(sizes);
                            Console.WriteLine("Perimeter: " + rect.GetPerimeter(sizes));
                            break;
                        default:
                            Console.WriteLine("\nPlease, select a valid number.");
                            break;
                    }
                    break;
                case 2:
                    Triangle trig = new Triangle();
                    Console.WriteLine("\n\nEnter the action:\n\n1.Calculate the Area\n\n2.Calculate the Perimeter\n");
                    action = Convert.ToByte(Console.ReadLine());
                    switch (action)
                    {
                        case 1:
                            trig.N = 2;
                            sizes = new double[trig.N];
                            ArrayInput(sizes);
                            Console.WriteLine("Area: " + trig.GetArea(sizes));
                            break;
                        case 2:
                            trig.N = 3;
                            sizes = new double[trig.N];
                            ArrayInput(sizes);
                            Console.WriteLine("Perimeter: " + trig.GetPerimeter(sizes));
                            break;
                        default:
                            Console.WriteLine("\nPlease, select a valid number.");
                            break;
                    }
                    break;
                case 3:
                    Square sqr = new Square();
                    Console.WriteLine("\n\nEnter the action:\n\n1.Calculate the Area\n\n2.Calculate the Perimeter\n");
                    action = Convert.ToByte(Console.ReadLine());
                    switch (action)
                    {
                        case 1:
                            sqr.N = 1;
                            sizes = new double[sqr.N];
                            ArrayInput(sizes);
                            Console.WriteLine("Area: " + sqr.GetArea(sizes));
                            break;
                        case 2:
                            sqr.N = 1;
                            sizes = new double[sqr.N];
                            ArrayInput(sizes);
                            Console.WriteLine("Perimeter: " + sqr.GetPerimeter(sizes));
                            break;
                        default:
                            Console.WriteLine("\nPlease, select a valid number.");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Please, select a valid number.");
                    break;
            }
        }
        public static void ArrayInput(double[] arr)
        {
            Console.WriteLine("\n\nEnter the values:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("\n");
        }
        public static void Set(byte n)
        {

        }
    }
}
