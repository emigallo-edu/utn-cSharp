using System;
using Business.Interfaces;
using Newtonsoft.Json;

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

        public static T Copy<T>(this T table) where T : ICopy
        {
            string serializado = JsonConvert.SerializeObject(table);
            return JsonConvert.DeserializeObject<T>(serializado);
        }
    }
}