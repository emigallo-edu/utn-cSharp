using System.Collections.Generic;
using Clase3.Models;
using static Clase3.Models.Material;
using System.Linq;

namespace Clase3.Services
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
            List<Chair> list = this.GetChairsInStock();
            List<Chair> result = list.Where(item => item.Color.ToUpper() == color.ToUpper()).ToList();

            //"SELECT * FROM Chairs WHERE Color='RED'"

            return result;
        }

        public List<Chair> GetChairsInStockByColorWithOutLinQ(string color)
        {
            List<Chair> list = this.GetChairsInStock();
            List<Chair> result = new List<Chair>();

            foreach (Chair item in list)
            {
                if (item.Color == color)
                {
                    result.Add(item);
                }
            }

            return result;
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
            List<Chair> list = this.GetChairsInStock();
            List<int> rett = list.Select(item => item.Code).ToList();
            // SELECT Code FROM Chairs

            return rett;
        }

        /// <summary>
        /// TODO - Ordernar las sillas por Code descendientemente
        /// </summary>
        /// <returns></returns>
        public List<Chair> GetChairsOrderedByCodeDesc()
        {
            List<Chair> list = this.GetChairsInStock();
            List<Chair> rett = list.OrderByDescending(item => item.Code).ToList();
            // SELECT * FROM Chairs ORDERBY Code DESC

            return rett;
        }

        public Dictionary<string, int> GetChairsAmountByColor()
        {
            List<Chair> list = this.GetChairsInStock();
            Dictionary<string, int> rett = new Dictionary<string, int>();

            foreach (var item in list.GroupBy(item => item.Color))
            {
                rett.Add(
                    item.Key,
                    item.ToList().Count()
                    );
            }

            return rett;
        }
    }
}