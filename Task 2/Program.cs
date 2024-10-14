using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TCircle circle1 = new TCircle();
                Console.WriteLine("Circle 1:");
                circle1.Input();
                circle1.Output();

                Console.WriteLine($"Circle area: {circle1.CalculateArea()}");
                Console.WriteLine($"Circle length: {circle1.CalculateLength()}");

                Console.WriteLine();
                TCircle circle2 = new TCircle();
                Console.WriteLine("Circle 2:");
                circle2.Input();
                circle2.Output();

                Console.WriteLine();
                TCircle circ = new TCircle();
                int result = circ.Compare(circle1, circle2);
                switch (result)
                {
                    case 1:
                        Console.WriteLine("Circle 1 is larger than Circle 2.");
                        break;
                    case -1:
                        Console.WriteLine("Circle 2 is larger than Circle 1.");
                        break;
                    case 0:
                        Console.WriteLine("Circle 1 and Circle 2 are equal.");
                        break;

                }

                Console.WriteLine();
                TCircle res1 = circle1 + circle2;
                Console.WriteLine($"Result of adding 2 radiuses: {res1.Radius}");
                TCircle res2 = circle1 - circle2;
                Console.WriteLine($"Result of substracting 2 radiuses: {res2.Radius}");

                Console.WriteLine();
                Console.Write("Input a number: ");
                double num = double.Parse(Console.ReadLine());
                TCircle res3 = circle1 * num;
                Console.WriteLine($"Result of multyplying a radius {circle1.Radius} by a number {num}: {res3.Radius}");
                TCircle res4 = num * circle1;
                Console.WriteLine($"Result of multyplying a number {num} by a radius {circle1.Radius}: {res4.Radius}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid number.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine();
            try
            {
                TCylinder cylinder1 = new TCylinder();
                Console.WriteLine("Cylinder1:");
                cylinder1.Input();
                cylinder1.Output();

                Console.WriteLine($"Cylinder surface area: {cylinder1.CalculateArea()}");
                Console.WriteLine($"Cylinder volume: {cylinder1.CalculateVolume()}");

                ///

                Console.WriteLine();
                TCylinder cylinder2 = new TCylinder();
                Console.WriteLine("Cylinder1:");
                cylinder2.Input();
                cylinder2.Output();

                Console.WriteLine();
                TCylinder cylin = new TCylinder();
                int result = cylin.Compare(cylinder1, cylinder2);
                switch (result)
                {
                    case 1:
                        Console.WriteLine("Cylinder 1 is larger than Cylinder 2.");
                        break;
                    case -1:
                        Console.WriteLine("Cylinder 2 is larger than Cylinder 1.");
                        break;
                    case 0:
                        Console.WriteLine("Cylinder 1 and Cylinder 2 are equal.");
                        break;

                }

                Console.WriteLine();
                TCylinder res1 = cylinder1 + cylinder2;
                Console.WriteLine($"Result of adding: radius {res1.Radius} and height {res1.Height}.");
                TCylinder res2 = cylinder1 - cylinder2;
                Console.WriteLine($"Result of substracting: radius {res2.Radius} and height {res2.Height}.");

                Console.WriteLine();
                Console.Write("Input a number: ");
                double num = double.Parse(Console.ReadLine());
                TCylinder res3 = cylinder1 * num;
                cylinder1.Output();
                Console.WriteLine($"Result of multyplying a radius {cylinder1.Radius} by a number {num}: {res3.Radius}.\nResult of multyplying a height {cylinder1.Height} by a number {num}: {res3.Height}.");
                TCylinder res4 = num * cylinder1;
                Console.WriteLine($"Result of multyplying a number {num} by a radius {cylinder1.Radius}: {res4.Radius}.\nResult of multyplying a height {cylinder1.Height} by a number {num}: {res4.Height}.");
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
