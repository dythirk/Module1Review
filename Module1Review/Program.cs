// See https://aka.ms/new-console-template for more information

namespace Module1Review
{
    public class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please enter an integer:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter another integer:");
            int b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"{a} plus {b} equals:");
            Console.WriteLine(Add(a, b));

            Console.WriteLine($"{a} minus {b} equals:");
            Console.WriteLine(Subtract(a, b));

            Console.WriteLine($"{a} times {b} equals:");
            Console.WriteLine(Multiply(a, b));

            Console.WriteLine($"{a} divided by {b} equals:");
            Console.WriteLine(Divide(a, b));


            static int Add(int a, int b)
            {
                return a + b;
            }

            static int Multiply(int a, int b)
            {
                return a * b;
            }

            static int Subtract(int a, int b)
            {
                return a - b;
            }

            static int Divide(int a, int b)
            {
                return a / b;
            }
        }
    }
}
