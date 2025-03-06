// See https://aka.ms/new-console-template for more information

namespace Module1Review
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Circle -- Please enter the radius:");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area of such a circle is:");
            Console.WriteLine(Circle(radius));
            Console.WriteLine();


            Console.WriteLine("Triangle -- Please enter the length of the base:");
            double baseLength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the height.");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The area of that triangle is:");
            Console.WriteLine(Triangle(baseLength, height));
            Console.WriteLine();


            Console.WriteLine("Rectangle -- Please enter the length of the rectangle:");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the width.");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The area is:");
            Console.WriteLine(Rectangle(length, width));
            Console.WriteLine();



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
