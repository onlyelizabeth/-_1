using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Input a natural number: ");
                int number = int.Parse(Console.ReadLine());

                NaturalNumber naturalNumber = new NaturalNumber(number);

                Console.WriteLine($"Reversed number: {naturalNumber.ReverseNumber()}");
                Console.WriteLine($"Amount of zeros in number: {naturalNumber.CalculateZeros()}");

                Console.WriteLine();
                Console.Write("Input the position of a digit (starting from 1): ");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine($"{index} digit of number: {naturalNumber[index]}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid number.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
