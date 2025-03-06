// See https://aka.ms/new-console-template for more information

namespace Module1Review
{
    public class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Please enter 1 for a Circle, 2 for a Triangle, 3 for a Rectangle, or 4 for a Square:");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:

                    Console.WriteLine("Circle -- Please enter the radius:");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("The area of such a circle is:");
                    Console.WriteLine(Circle(radius));
                    Console.WriteLine();
                    break;
                
                case 2:

                    Console.WriteLine("Triangle -- Please enter the length of the base:");
                    double baseLength = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter the height:");
                    double height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("The area of that triangle is:");
                    Console.WriteLine(Triangle(baseLength, height));
                    Console.WriteLine();
                    break;
                
                case 3:

                    Console.WriteLine("Rectangle -- Please enter the length of the rectangle:");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter the width:");
                    double width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("The area is:");
                    Console.WriteLine(Rectangle(length, width));
                    Console.WriteLine();
                    break;
                
                case 4:

                    Console.WriteLine("Square -- Please enter the length of a side:");
                    double side = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("The area is:");
                    Console.WriteLine(Square(side));
                    Console.WriteLine();
                    break;
                
                default:

                    Console.WriteLine("You entered something improper.");
                    break;
            }

            static double Circle(double radius)
            {
                return 3.141593 * radius * radius;
            }

            static double Triangle(double baseLength, double height)
            {
                return .5 * baseLength * height;
            }

            static double Rectangle(double length, double width)
            {
                return length * width;
            }

            static double Square(double side)
            {
                return side * side;
            }
        }
    }
}
