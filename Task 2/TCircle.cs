using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class TCircle
    {
        protected double radius;

        // конструктор без параметрів
        public TCircle()
        {
            this.radius = 1;
        }

        // конструктор з параметрами
        public TCircle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius can't be a negative number.");
            }
            this.radius = radius;
        }

        // конструктор копіювання
        public TCircle(TCircle previousCircle)
        {
            this.radius = previousCircle.radius;
        }

        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                if (value >= 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentException("Radius can't be a negative number.");
                }
            }
        }

        // 
        public override string ToString()
        {
            return $"Circle with a radius {radius}.";
        }

        // введення даних
        public void Input()
        {
            Console.Write("Input a radius: ");
            double radius = double.Parse(Console.ReadLine());
            if (radius < 0)
            {
                throw new ArgumentException("Radius can't be a negative number.");
            }
            this.radius = radius;
        }

        // виведення даних
        public void Output()
        {
            Console.WriteLine(this.ToString());
        }

        // визначення площі круга (обмеженого колом)
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        // визначення довжини кола
        public double CalculateLength()
        {
            return 2 * Math.PI * radius;
        }

        // порівняння з іншим колом
        public int Compare(TCircle circle1, TCircle circle2)
        {
            if (circle1.radius > circle2.radius)
            {
                return 1;
            }

            if (circle1.radius < circle2.radius)
            {
                return -1;
            }

            return 0;
        }

        // перевантаження операторів: + (додавання радіусів), - (віднімання радіусів),
        // * (множення радіуса на число (число*коло та коло*число))
        public static TCircle operator +(TCircle circle1, TCircle circle2)
        {
            return new TCircle(circle1.radius + circle2.radius);
        }

        public static TCircle operator -(TCircle circle1, TCircle circle2)
        {
            if (circle1.radius < circle2.radius)
            {
                return new TCircle(circle2.radius - circle1.radius);
            }
            return new TCircle(circle1.radius - circle2.radius);
        }

        public static TCircle operator *(TCircle circle, double num)
        {
            return new TCircle(circle.radius * num);
        }

        public static TCircle operator *(double num, TCircle circle)
        {
            return new TCircle(num * circle.radius);
        }
    }
}
