using System;
using System.Collections.Generic;
using Clase3.Models;
using Clase3.Services;

namespace Clase3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chair unaSilla = new Chair(1, "red", Material.Materials.Wood, true);
            //Chair otraSilla = unaSilla;
            //otraSilla.Code = 2;
            //Console.WriteLine(unaSilla.Code);

            //string unString = "valor original";
            //string otroString = unString;
            //otroString = "nuevo valor";
            //Console.WriteLine(otroString);
            //Console.WriteLine(unString);

            Set set = new Set();
            Table table = new Table(1, "Red", Material.Materials.Wood, 10, 20);
            set.AddAndChangeColor(table);
            Console.Write(table.Color);

        }
    }
}