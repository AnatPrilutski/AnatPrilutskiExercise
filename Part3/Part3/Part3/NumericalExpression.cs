using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    public class NumericalExpression
    {
        private long Number { get; set; }
        private static string[] UnitsInWords = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        private static string[] TeensInWords = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        private static string[] TensInWords = { "", "", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        public NumericalExpression(long number)
        {
            if (number > 999999999999 || number < -999999999999)
            {
                throw new IndexOutOfRangeException("Please enter a number up to -+999,999,999,999");
            }

            this.Number = number;
        }
        public override string ToString()
        {
            if (this.Number == 0)
            {
                return "Zero";
            }

            return PrintIfNegative() + GetBillions() + GetMillions() + GetThousands() + GetHundreds(this.Number) + GetTeensOrTens(this.Number);
        }
        public string PrintIfNegative()
        {
            if (this.Number < 0)
            {
                return "Minus ";
            }

            return "";
        }
        public string GetUnits(long number)
        {
            return UnitsInWords[Math.Abs(number) % 10] + " "; 
        }
        public string GetTeensOrTens(long number)
        {
            number = Math.Abs(number);
            if ((number % 100) < 20 && (number % 100) > 10)
            {
                return TeensInWords[number % 10];
            }

            return TensInWords[(number % 100) / 10] + " " + GetUnits(number);
        }
        public string GetHundreds(long number)
        {
            number = Math.Abs(number);
            long numberOfHundreds = number / 100;
            if (numberOfHundreds == 0) 
            {
                return "";
            }

            return GetUnits(numberOfHundreds) + " Hundred ";
        }
        public string GetThousands()
        {
            long number = Math.Abs(this.Number);
            long numberOfThousands = number / 1000;
            if (numberOfThousands == 0)
            {
                return "";
            }

            string thousands = GetHundreds(numberOfThousands) + GetTeensOrTens(numberOfThousands);
            return thousands + " Thousand ";
        }
        public string GetMillions()
        {
            long number = Math.Abs(this.Number);
            long numberOfMillions = number / 1000000;
            if (numberOfMillions == 0)
            {
                return "";
            }

            string millions = GetHundreds(numberOfMillions) + GetTeensOrTens(numberOfMillions);
            return millions + " Million ";
        }
        public string GetBillions()
        {
            long number = Math.Abs(this.Number);
            long numberOfBillions = number / 1000000000;
            if (numberOfBillions == 0)
            {
                return "";
            }

            string billion = GetHundreds(numberOfBillions) + GetTeensOrTens(numberOfBillions);
            return billion + " Billion "; 
        }
        public long GetValue()
        {
            return this.Number;
        }
        public static long SumLetters(long number)
        { 
            long sum = 0;
            for (long i = 0; i < Math.Abs(number); i++)
            {
                sum = sum + (new NumericalExpression(i).ToString().Trim()).Length;
            }

            return sum;
        }
        // The OOP concept is overloading - allows a class to have multiple methods with the same name but different parameters. 
        public static long SumLetters(NumericalExpression number)
        {
            long sum = 0;
            for (long i = 0; i < Math.Abs(number.GetValue()); i++)
            {
                sum = sum + (new NumericalExpression(i).ToString().Trim()).Length;
            }

            return sum;
        }
    }
}
