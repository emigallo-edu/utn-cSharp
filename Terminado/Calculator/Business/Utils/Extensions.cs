using System;
namespace Business.Utils
{
    public static class Extensions
    {
        public static Boolean IsOdd(this int value)
        {
            return value % 2 != 0;
        }

        public static Boolean IsPair(this int value)
        {
            return value % 2 == 0;
        }
    }
}