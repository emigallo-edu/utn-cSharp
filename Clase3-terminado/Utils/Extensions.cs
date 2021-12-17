using System;
using Clase3.Models;
using Newtonsoft.Json;

namespace Clase3.Utils
{
    public static class Extensions
    {
        public static T Copy<T>(this T table)
        {
            string serializado = JsonConvert.SerializeObject(table);
            return JsonConvert.DeserializeObject<T>(serializado);
        }
    }
}