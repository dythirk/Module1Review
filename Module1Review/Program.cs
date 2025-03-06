// See https://aka.ms/new-console-template for more information

namespace Module1Review
{
    public class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please enter an integer:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter another integer:");
            double b = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine($"{a} plus {b} equals:");
            Console.WriteLine(Add(a, b));

            Console.WriteLine($"{a} minus {b} equals:");
            Console.WriteLine(Subtract(a, b));

            Console.WriteLine($"{a} times {b} equals:");
            Console.WriteLine(Multiply(a, b));

            Console.WriteLine($"{a} divided by {b} equals:");
            Console.WriteLine(Divide(a, b));


            static double Add(double a, double b)
            {
                return a + b;
            }

            static double Multiply(double a, double b)
            {
                return a * b;
            }

            static double Subtract(double a, double b)
            {
                return a - b;
            }

            static double Divide(double a, double b)
            {
                return a / b;
            }
        }
    }
}
