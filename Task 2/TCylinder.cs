using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class TCylinder : TCircle
    {
        protected double height;

        // конструктор без параметрів
        public TCylinder() : base()
        {
            this.height = 1;
        }

        // конструктор з параметрами
        public TCylinder(double radius, double height) : base(radius)
        {
            if (height < 0)
            {
                throw new ArgumentException("Height can't be a negative number.");
            }
            this.height = height;
        }

        // конструктор копіювання
        public TCylinder(TCylinder previousCylinder) : base(previousCylinder)
        {
            this.height = previousCylinder.height;
        }

        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                if (value >= 0)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentException("Height can't be a negative number.");
                }
            }
        }
        // 
        public override string ToString()
        {
            return $"Cylinder with a radius {radius} and a height {height}.";
        }

        // введення даних
        public new void Input()
        {
            base.Input();
            Console.Write("Input a height: ");
            double height = double.Parse(Console.ReadLine());
            if (height < 0)
            {
                throw new ArgumentException("Height can't be a negative number.");
            }
            this.height = height;
        }

        // виведення даних
        public new void Output()
        {
            Console.WriteLine(this.ToString());
        }

        // знаходження повної площі поверхні циліндра
        public new double CalculateArea()
        {
            return 2 * base.CalculateArea() + 2 * Math.PI * radius * height;
        }

        // порівняння з іншим циліндром за об'ємом
        public int Compare(TCylinder cylinder1, TCylinder cylinder2)
        {
            double volume1 = cylinder1.CalculateVolume();
            double volume2 = cylinder2.CalculateVolume();

            if (volume1 > volume2)
            {
                return 1;
            }

            if (volume1 < volume2)
            {
                return -1;
            }

            return 0;
        }

        // знаходження об’єму циліндра
        public double CalculateVolume()
        {
            return base.CalculateArea() * height;
        }

        // перевантаження методів
        public static TCylinder operator +(TCylinder cylinder1, TCylinder cylinder2)
        {
            return new TCylinder(cylinder1.radius + cylinder2.radius, cylinder1.height + cylinder2.height);
        }

        public static TCylinder operator -(TCylinder cylinder1, TCylinder cylinder2)
        {
            return new TCylinder(Math.Abs(cylinder1.radius - cylinder2.radius), Math.Abs(cylinder1.height - cylinder2.height));

        }

        public static TCylinder operator *(TCylinder cylinder, double num)
        {
            return new TCylinder(cylinder.radius * num, cylinder.height * num);
        }

        public static TCylinder operator *(double num, TCylinder cylinder)
        {
            return new TCylinder(num * cylinder.radius, num * cylinder.height);
        }
    }
}
