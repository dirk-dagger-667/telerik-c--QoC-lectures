//Write a program to compare the performance of add, subtract, increment, multiply, divide for int, long, float, double and decimal values.
//Write a program to compare the performance of square root, natural logarithm, sinus for float, double and decimal values.
//* Write a program to compare the performance of insertion sort, selection sort, quicksort for int, double and string values. Check also the following cases: random values, sorted values, values sorted in reversed order.

namespace OptimizitionTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    static class AdvancedMath<T>
    {
        public static T SqRt(T value)
        {
            return default(T);
        }

        public static T Ln(T value)
        {
            if (IsPositive(value))
            {
                T threshold = (dynamic)1e-5;
                T baseOFLogarithm = value - (dynamic)1;
                int den = 1;
                int sign = 1;
                T term = baseOFLogarithm;
                T prev = default(T);
                T result = term;

                while (Absolute(prev - (dynamic)result) > threshold)
                {
                    den++;
                    sign *= -1;
                    term *= (dynamic)baseOFLogarithm;
                    prev = result;
                    result += (dynamic)sign * term / den;
                }

                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("the value cannot be negative when calculating natural logarithm");
            }
        }

        public static T Power(T baseValue, T power)
        {
            return default(T);
        }

        private static T Absolute(T value)
        {
            if((dynamic)value >= 0)
            {
                return value;
            }
            else
            {
                return (dynamic)value * (-1);
            }
        }

        private static bool IsPositive(T value)
        {
            return (dynamic)value >= default(T);
        }
    }
}
