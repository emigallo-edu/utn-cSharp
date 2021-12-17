using System;
using System.Collections.Generic;
using Clase2.Models;
using Clase2.Services;

namespace Clase2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ChairService service = new ChairService();
            //List<Chair> result = service.GetChairsInStockByColor("blue");

            var result = service.GetChairsAmountByColor();
        }
    }
}