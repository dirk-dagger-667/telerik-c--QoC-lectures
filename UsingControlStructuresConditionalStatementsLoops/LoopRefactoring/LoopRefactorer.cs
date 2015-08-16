namespace LoopRefactoring
{
    using System;

    class LoopRefactorer
    {
        static void Main()
        {
            for (int i = 0; i < 100; )
            {
                Console.WriteLine(array[i]);

                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        Console.WriteLine("Value Found");
                        break;
                    }
                }

                i++;
            }
            // More code here
        }
    }
}
