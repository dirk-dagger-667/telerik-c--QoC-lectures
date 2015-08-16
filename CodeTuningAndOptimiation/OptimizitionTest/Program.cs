namespace OptimizitionTest
{
    using System;
    using System.Diagnostics;

    class Program
    {
        public delegate T MathFunctionTwoArguments<T>(T firstValue, T secondValue);
        public delegate T MathFunctionSingleArgument<T>(T value);

        static void Main()
        {
            double firstInt = 67;
            double secondInt = 30;

            //Console.WriteLine("Int");

            //MeasurePerformance(firstInt, secondInt, new MathFunction<int>(BasicMath<int>.Add));
            //MeasurePerformance(firstInt, secondInt, new MathFunction<double>(BasicMath<double>.Divide));
            //MeasurePerformance(firstInt, secondInt, new MathFunction<float>(BasicMath<float>.Multiply));
            //MeasurePerformance(firstInt, secondInt, new MathFunction<long>(BasicMath<long>.Subtract));

            MeasurePerformance(firstInt, new MathFunctionSingleArgument<double>(AdvancedMath<double>.Ln));
        }

        public static void MeasurePerformanceTwoArguments<T>(T a, T b, MathFunctionTwoArguments<T> myMethod)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            Console.WriteLine(myMethod(a, b));
                
            timer.Stop();
            Console.WriteLine("Elapsed time: {0}", timer.Elapsed);

        }

        public static void MeasurePerformance<T>(T value, MathFunctionSingleArgument<T> myMethod)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            Console.WriteLine(myMethod(value));

            timer.Stop();
            Console.WriteLine("Elapsed time: {0}", timer.Elapsed);
        }
    }
}