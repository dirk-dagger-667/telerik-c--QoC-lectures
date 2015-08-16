namespace RefactorConditionalStatements
{
    class ConditionalStatements
    {
        private const int MAX_X = 100;
        private const int MIN_X = 10;
        private const int MAX_Y = 10;
        private const int MIN_Y = 5;

        static void Main()
        {
            Potato potato;
            //... 
            if (potato != null)
            {
                if (potato.HasBeenPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
            }

            int x = 12;
            int y = 7;
            bool shouldVisitCell = true;
                
            if (!(IsOutsideOfRange(x, MAX_X, MIN_X)) && IsOutsideOfRange(y, MAX_Y, MIN_Y) && shouldVisitCell)
            {
                VisitCell();
            }
        }

        private static bool IsOutsideOfRange(int value, int maxValue, int minValue)
        {
            return maxValue >= value && minValue <= value;
        }
    }
}
