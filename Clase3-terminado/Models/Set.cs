using System.Collections.Generic;
using Clase3.Utils;

namespace Clase3.Models
{
    public class Set
    {
        private int _maxChairs;

        public Set()
        {

        }

        public Set(Table table, List<Chair> chairs)
        {
            Table t = table.Copy();
            chairs.Copy();

            this.Table = table;
            this.Chairs = chairs;
        }

        public Table Table { get; set; }
        public List<Chair> Chairs { get; set; }

        // TODO - Escribir método para agregar una silla

        // TODO - Escribir método para agregar varias sillas

        // TODO - Escribir método para agregar una mesa. Al hacerlo, cambiarle el color a HEX
        public void AddAndChangeColor(Table table)
        {
            Table newTable = table.Copy() as Table;

            if (table.Color == "Red")
            {
                newTable.Color = "#FF0000";
            }

            this.Table = newTable;
        }

        /// <summary>
        /// TODO - Codificar para que agregue la silla en la lista de sillas
        /// </summary>
        /// <param name="chairs"></param>
        /// <param name="chair"></param>
        public void AddChairByRef(List<Chair> chairs, Chair chair)
        {
        }

        public void AddChairByCopy(List<Chair> chairs, Chair chair)
        {
        }
    }
}