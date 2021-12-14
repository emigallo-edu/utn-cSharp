using System;
using Clase2.Services;

namespace Clase2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TableService service = new TableService();
            service.GetDistincsTableColor();
        }
    }
}