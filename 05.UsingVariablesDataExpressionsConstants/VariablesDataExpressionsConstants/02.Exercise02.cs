namespace VariablesDataExpressionsConstants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Exercise02
    {
        public void PrintStatistics(double[] values, int count)
        {
            double max = 0;

            for (int i = 0; i < count; i++)
            {
                if (values[i] > max)
                {
                    max = values[i];
                }
            }

            Console.WriteLine(max);
            double min = 0;

            for (int i = 0; i < count; i++)
            {
                if (values[i] < min)
                {
                    min = values[i];
                }
            }

            Console.WriteLine(min);
            double tmp = 0;

            for (int i = 0; i < count; i++)
            {
                tmp += values[i];
            }

            Console.WriteLine(tmp / count);
        }
    }
}
