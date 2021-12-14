using System.Collections.Generic;
using Clase2.Models;
using static Clase2.Models.Material;

namespace Clase2.Services
{
    public class ChairService
    {
        public ChairService()
        {
        }

        public List<Chair> GetChairsInStock()
        {
            List<Chair> rett = new List<Chair>();

            rett.Add(new Chair(1, "Red", Materials.Wood, true));
            rett.Add(new Chair(2, "Blue", Materials.Steel, true));
            rett.Add(new Chair(3, "Blue", Materials.Steel, true));
            rett.Add(new Chair(4, "White", Materials.Plastic, false));
            rett.Add(new Chair(5, "White", Materials.Plastic, false));
            rett.Add(new Chair(6, "White", Materials.Plastic, false));
            rett.Add(new Chair(7, "Green", Materials.Plastic, false));
            rett.Add(new Chair(8, "Red", Materials.Wood, true));
            rett.Add(new Chair(9, "Red", Materials.Wood, true));

            return rett;
        }

        /// <summary>
        /// TODO - Iterar las sillas y devolver las que cumplan con el color deseado
        /// </summary>
        /// <returns></returns>
        public List<Chair> GetChairsInStockByColor(string color)
        {
            List<Chair> rett = new List<Chair>();

            return rett;
        }

        public List<Chair> GetChairsInStockWithColorInSpanish()
        {
            List<Chair> rett = new List<Chair>();

            return rett;
        }

        /// <summary>
        /// TODO - Filtrar las sillas según con el material deseado
        /// </summary>
        /// <returns></returns>
        public List<Chair> GetChairsInStockByMaterial(string color)
        {
            List<Chair> rett = new List<Chair>();

            return rett;
        }

        /// <summary>
        /// TODO - Seleccionar la Property 'Code' de las sillas
        /// </summary>
        /// <returns></returns>
        public List<int> GetChairsCode()
        {
            List<int> rett = new List<int>();

            return rett;
        }

        /// <summary>
        /// TODO - Ordernar las sillas por Code descendientemente
        /// </summary>
        /// <returns></returns>
        public List<Chair> GetChairsOrderedByCodeDesc()
        {
            List<Chair> rett = new List<Chair>();

            return rett;
        }

        public Dictionary<string, int> GetChairsAmountByColor()
        {
            Dictionary<string, int> rett = new Dictionary<string, int>();

            return rett;
        }
    }
}