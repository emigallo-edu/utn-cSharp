using System.Collections.Generic;
using System.Linq;
using Clase3.Models;

namespace Clase3.Services
{
    public class SetService
    {
        public SetService()
        {
        }

        /// <summary>
        /// TODO - Combinar todas las mesas y tablas. El criterio es que deben ser del mismo material y color
        /// </summary>
        /// <returns></returns>
        public List<Set> GetSetsInStock(List<Table> tables, List<Chair> chairs)
        {
            List<Set> rett = new List<Set>();

            foreach(Table table in tables)
            {
                List<Chair> chairsRelated = chairs
                    .Where(item => item.Color == table.Color && item.Material == table.Material).ToList();

                if (chairsRelated.Any())
                {
                    rett.Add(new Set(table, chairsRelated));
                }
            }

            return rett;
        }
    }
}