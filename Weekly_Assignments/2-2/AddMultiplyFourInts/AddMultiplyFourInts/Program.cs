using System;

namespace AddMultiplyFourInts
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize four integer variables
            int num1 = 13;
            int num2 = 55;
            int num3 = 123;
            int num4 = 325;

            // Calculate the sum
            int sum = num1 + num2 + num3 + num4;

            // Calculate the product
            long product = (long)num1 * num2 * num3 * num4;

            // Output the results
            Console.WriteLine("Couch, Zachery's Copy");
            Console.WriteLine($"The sum of {num1}, {num2}, {num3}, and {num4} = {sum}");
            Console.WriteLine($"The product of {num1}, {num2}, {num3}, and {num4} = {product}");
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
