namespace OptimizitionTest
{
    static class BasicMath<T>
    {
        public static T Add(T firstValue, T secondValue)
        {
            dynamic first = firstValue;
            dynamic second = secondValue;
            return first + second;
        }

        public static T Subtract(T firstValue, T secondValue)
        {
            dynamic first = firstValue;
            dynamic second = secondValue;
            return first - second;
        }

        public static T Increment(T value)
        {
            dynamic increment = value;
            return increment++;
        }

        public static T Multiply(T firstValue, T secondValue)
        {
            dynamic first = firstValue;
            dynamic second = secondValue;
            return first * second;
        }

        public static T Divide(T firstValue, T secondValue)
        {
            dynamic first = firstValue;
            dynamic second = secondValue;
            return first / second;
        }
    }
}
