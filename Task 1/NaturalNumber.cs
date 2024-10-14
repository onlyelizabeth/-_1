using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class NaturalNumber
    {
        protected int number;

        public NaturalNumber(int number)
        {
            if (IsNaturalNumber(number))
            {
                this.number = number;            
            }
            else
            {
                throw new ArgumentException("It is not a natural number.");
            }
        }

        public bool IsNaturalNumber(int number)
        {
            return number > 0;
        }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                if (IsNaturalNumber(value))
                {
                    number = value;
                }
                else
                {
                    throw new ArgumentException("It is not a natural number.");
                }
            }
        }

        public int this[int index]
        {
            get
            {
                index--;
                string numberString = number.ToString();
                if (index < 0 || index >= numberString.Length)
                {
                    throw new ArgumentException("Index is out of bounds of the number." );
                }

                return int.Parse(numberString[index].ToString());
            }
        }

        public int ReverseNumber()
        {
            int tempNumber = number;
            int reversedNumber = 0;
            int remainder;

            while (tempNumber != 0)
            {
                remainder = tempNumber % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                tempNumber /= 10;
            }

            return reversedNumber;
        }

        public int CalculateZeros()
        {
            int tempNumber = number;
            int zerosAmount = 0;
            int remainder;

            while (tempNumber != 0)
            {
                remainder = tempNumber % 10;
                if (remainder == 0)
                {
                    zerosAmount++;
                }
                tempNumber /= 10;
            }

            return zerosAmount;
        }

    }
}
