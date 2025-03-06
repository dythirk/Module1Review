// See https://aka.ms/new-console-template for more information

namespace Module1Review
{
    public class Program
    {
        static void Main(string[] args)
        {
            //double a, b;

            //Console.WriteLine("Please enter an integer:");
            //a = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Please enter another integer:");
            //b = Convert.ToDouble(Console.ReadLine());



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


            //Console.WriteLine($"{a} plus {b} equals:");
            //Console.WriteLine(Add(a, b));

            //Console.WriteLine($"{a} minus {b} equals:");
            //Console.WriteLine(Subtract(a, b));

            ////Console.WriteLine($"{a} times {b} equals:");
            ////Console.WriteLine(Multiply(a, b));

            //Console.WriteLine($"{a} divided by {b} equals:");
            //Console.WriteLine(Divide(a, b));


            static double Circle(double a)
            {
                return 3.141593*a*a;
            }

            static double Triangle(double b, double h)
            {
                return .5 * b * h;
            }

            static double Rectangle(double a, double b)
            {
                return a - b;
            }

            static double Square(double a, double b)
            {
                return a / b;
            }
        }
    }
}
