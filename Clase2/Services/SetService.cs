﻿using System.Collections.Generic;
using Clase2.Models;

namespace Clase2.Services
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

            return rett;
        }
    }
}