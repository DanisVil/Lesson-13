using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyGuide
{
    [DeveloperInfo("Danis"), DeveloperInfo("Abob abobovich")]
    class RationalNumber
    {
        public int numerator, denominator;
        public RationalNumber(int numerator, int denominator)
        {
            if (!denominator.Equals(0))
            {
                int temp = gcd(numerator, denominator);
                if (numerator >= 0 && denominator < 0)
                {
                    numerator *= -1;
                    denominator *= -1;
                }
                this.denominator = denominator / temp;
                this.numerator = numerator/ temp;
            }
            else
            {
                throw new DivideByZeroException();
            }
        }
        public static bool operator ==(RationalNumber first, RationalNumber second)
        {
            if (first.numerator == second.numerator && first.denominator == second.denominator)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(RationalNumber first, RationalNumber second)
        {
            return !(first == second);
        }
        public override bool Equals(object obj)
        {
            RationalNumber number = obj as RationalNumber;
            if (number is null)
            {
                return false;
            }
            if (numerator.Equals(number.numerator) && denominator.Equals(number.denominator))
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return ((float)numerator / denominator).GetHashCode();
        }
        public static RationalNumber operator +(RationalNumber first, RationalNumber second)
        {
            int newDenominator = lcm(first.denominator, second.denominator);
            int newNumerator = newDenominator / first.denominator * first.numerator + 
                newDenominator / second.denominator * second.numerator;
            int a = gcd(newNumerator, newDenominator);
            newDenominator /= a;
            newNumerator /= a;
            return new RationalNumber(newNumerator, newDenominator);
        }
        public static RationalNumber operator -(RationalNumber first, RationalNumber second)
        {
            int newDenominator = lcm(first.denominator, second.denominator);
            int newNumerator = newDenominator / first.denominator * first.numerator -
                newDenominator / second.denominator * second.numerator;
            int a = gcd(newNumerator, newDenominator);
            newDenominator /= a;
            newNumerator /= a;
            return new RationalNumber(newNumerator, newDenominator);
        }
        public static RationalNumber operator ++(RationalNumber number)
        {
            return new RationalNumber(number.numerator + number.denominator, number.denominator);
        }
        public static RationalNumber operator --(RationalNumber number)
        {
            return new RationalNumber(number.numerator - number.denominator, number.denominator);
        }
        public static RationalNumber operator *(RationalNumber first, RationalNumber second)
        {
            return new RationalNumber(first.numerator * second.numerator, first.denominator * second.denominator);
        }
        public static RationalNumber operator /(RationalNumber first, RationalNumber second)
        {
            return new RationalNumber(first.numerator * second.denominator, first.denominator * second.numerator);
        }
        public static RationalNumber operator %(RationalNumber first, RationalNumber second)
        {
            RationalNumber quotient = first / second;
            return new RationalNumber(quotient.numerator % quotient.denominator, quotient.denominator);
        }
        public static bool operator >(RationalNumber first, RationalNumber second)
        {
            RationalNumber difference = first - second;
            if (difference.numerator > 0)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(RationalNumber first, RationalNumber second)
        {
            RationalNumber difference = first - second;
            if (difference.numerator < 0)
            {
                return true;
            }
            return false;
        }
        public static bool operator >=(RationalNumber first, RationalNumber second)
        {
            RationalNumber difference = first - second;
            if (difference.numerator >= 0)
            {
                return true;
            }
            return false;
        }
        public static bool operator <=(RationalNumber first, RationalNumber second)
        {
            RationalNumber difference = first - second;
            if (difference.numerator <= 0)
            {
                return true;
            }
            return false;
        }
        public static explicit operator float(RationalNumber number)
        {
            return (float)number.numerator / number.denominator;
        }
        public static explicit operator int(RationalNumber number)
        {
            return number.numerator / number.denominator;
        }
        public static int gcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static int lcm(int a, int b)
        {
            return (a / gcd(a, b)) * b;
        }
        public void Rationalize()
        {

        }
        public override string ToString()
        {
            if (denominator.Equals(1) && numerator.Equals(0))
            {
                return numerator.ToString();
            }
            return $"{numerator}/{denominator}";
        }
    }
}
