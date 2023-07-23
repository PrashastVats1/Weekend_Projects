using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("\n");
            Console.WriteLine("Enter your name: \t");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello, " + userName + "!");
            Console.WriteLine("\n");
            Console.WriteLine("Enter first number: \t");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: \t");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);

            if (num2 != 0)
            {
                int quotient = num1 / num2;
                int remainder = num1 % num2;
                Console.WriteLine("Division: " + quotient);
                Console.WriteLine("Modulus: " + remainder);
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
            Console.WriteLine("\n");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
            int[] numbers = { 5, 10, 15, 20, 25 };

            int sum1 = 0;
            foreach (int num in numbers)
            {
                sum1 += num;
            }

            double average = (double)sum1 / numbers.Length;

            Console.WriteLine("Sum: " + sum1);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("\n");
            Console.WriteLine("Please enter a positive integer:");
            int input = int.Parse(Console.ReadLine());

            int factorial = CalculateFactorial(input);

            Console.WriteLine("Factorial of " + input + " is: " + factorial);
            Console.WriteLine("\n");
            int age = 0;
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.WriteLine("Please enter your age:");
                string ageInput = Console.ReadLine();

                if (int.TryParse(ageInput, out age))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid age.");
                }
            }

            if (age < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else if (age >= 18 && age < 65)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior.");
            }
            Console.ReadKey();
        }
        static int CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;

            return n * CalculateFactorial(n - 1);
        }
    }
}
