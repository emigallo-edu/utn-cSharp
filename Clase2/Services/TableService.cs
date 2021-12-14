using System.Collections.Generic;
using Clase2.Models;
using static Clase2.Models.Material;

namespace Clase2.Services
{
    public class TableService
    {
        public TableService()
        {
        }

        public List<Table> GetTablesInStock()
        {
            List<Table> rett = new List<Table>();

            rett.Add(new Table(1, "Red", Materials.Plastic, 70, 50));
            rett.Add(new Table(2, "Blue", Materials.Wood, 70, 50));
            rett.Add(new Table(3, "Yellow", Materials.Steel, 70, 50));
            rett.Add(new Table(4, "Yellow", Materials.Plastic, 70, 50));
            rett.Add(new Table(5, "Blue", Materials.Steel, 70, 50));
            rett.Add(new Table(6, "Yellow", Materials.Wood, 70, 50));
            rett.Add(new Table(6, "Yellow", Materials.Plastic, 70, 50));

            return rett;
        }

        /// <summary>
        /// TODO - Devolver todas las mesas según el material deseado
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        public List<Table> GetTablesInStockByMaterial(Materials material)
        {
            List<Table> rett = new List<Table>();

            return rett;
        }

        /// <summary>
        /// TODO - Devolver solamente el campo 'Code' de las mesas
        /// </summary>
        /// <returns></returns>
        public List<string> GetTablesCode()
        {
            List<string> rett = new List<string>();

            return rett;
        }

        /// <summary>
        /// TODO - Devolver todas las mesas según el color deseado
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public List<Table> GetTablesInStockByColor(string color)
        {
            List<Table> rett = new List<Table>();

            return rett;
        }

        /// <summary>
        /// TODO - Agrupar todas las mesas según su material y contar la cantidad.
        /// Devolver en orden descentede según cantidad
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        public Dictionary<Materials, int> GetTablesAmountInStockByMaterial()
        {
            Dictionary<Materials, int> rett = new Dictionary<Materials, int>();

            return rett;
        }

        /// <summary>
        /// TODO - Devolver todos los diferentes colores que hay de mesas en stock
        /// </summary>
        /// <returns></returns>
        public List<string> GetDistincsTableColor()
        {
            List<string> rett = new List<string>();

            return rett;
        }
    }
}