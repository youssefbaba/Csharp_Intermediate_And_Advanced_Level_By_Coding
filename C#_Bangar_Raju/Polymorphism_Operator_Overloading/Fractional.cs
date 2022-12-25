
using System.Net.Http.Headers;

namespace Polymorphism_Operator_Overloading
{
    internal class Fractional
    {
        // Fields
        private int _numerator;
        private int _denominator;

        // Constructors
        public Fractional()
        {
        }
        public Fractional(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        // Properties
        public double Value
        {
            get
            {
                return (double)_numerator / _denominator;
            }
        }

        // Methods
        public static Fractional operator +(Fractional fractional1, Fractional fractional2)
        {
            return new Fractional((fractional1._numerator * fractional2._denominator) + (fractional1._denominator * fractional2._numerator), fractional1._denominator * fractional2._denominator);
        }
        public static Fractional operator +(Fractional fractional1, int number)
        {
            return fractional1 + new Fractional(number, 1);
        }
        public static Fractional operator ++(Fractional fractional)
        {
            return fractional + 1;
        }
        public static bool operator >(Fractional fractional1, Fractional fractional2)
        {
            return fractional1.Value > fractional2.Value;
        }
        public static bool operator <(Fractional fractional1, Fractional fractional2)
        {
            return fractional1.Value < fractional2.Value;
        }

        public static bool operator ==(Fractional fractional1, Fractional fractional2)
        {
            return fractional1.Value == fractional2.Value;
        }
        public static bool operator !=(Fractional fractional1, Fractional fractional2)
        {
            return !(fractional1 == fractional2);
        }

        // Implicit Casting from integer to Fractional
        public static implicit operator Fractional(int number)
        {
            return new Fractional(number, 1);
        }
        // Explicit Casting from Fractional to double
        public static explicit operator double(Fractional fractional)
        {
            return fractional.Value;
        }

        public override string ToString()
        {
            return $"{_numerator} / {_denominator}";
        }




    }
}
