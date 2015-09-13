////Refactor the following code to apply variable usage and naming best practices:
//public void PrintStatistics(double[] arr, int count)
//{
//    double max, tmp;
//    for (int i = 0; i < count; i++)
//    {
//        if (arr[i] > max)
//        {
//            max = arr[i];
//        }
//    }
//    PrintMax(max);
//    tmp = 0;
//    max = 0;
//    for (int i = 0; i < count; i++)
//    {
//        if (arr[i] < max)
//        {
//            max = arr[i];
//        }
//    }
//    PrintMin(max);

//    tmp = 0;
//    for (int i = 0; i < count; i++)
//    {
//        tmp += arr[i];
//    }
//    PrintAvg(tmp/count);
//}

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
