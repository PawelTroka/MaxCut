using System;

namespace MaxCut
{
    public static class Utility
    {
        private static Random _random = new Random(149063626);

        public static int Seed
        {
            set { _random = new Random(value); }
        }

        public static int Random(int min, int max)
        {
            return _random.Next(min, max + 1);
        }

        public static double Random(double min, double max)
        {
            return min + _random.NextDouble()*Math.Abs(max - min);
        }

        public static int Random()
        {
            return _random.Next();
        }
    }
}