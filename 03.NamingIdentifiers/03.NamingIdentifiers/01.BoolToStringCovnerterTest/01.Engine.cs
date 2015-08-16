namespace _03.NamingIdentifiers
{
    using System;

    class Engine
    {
        public static readonly int MaxCount = 6;

        public static void Main()
        {
            BoolToStringConverter testConverter = new BoolToStringConverter();
            testConverter.BoolToString(true);
        }
    }
}
