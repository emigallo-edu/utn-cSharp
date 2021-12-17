using System.Collections.Generic;

namespace Clase3.Models
{
    public class Set
    {
        private int _maxChairs;

        public Set(Table table, List<Chair>chairs)
        {
            this.Table = table;
            this.Chairs = chairs;
        }

        public Table Table { get; set; }
        public List<Chair> Chairs { get; set; }

        // TODO - Escribir método para agregar una silla

        // TODO - Escribir método para agregar varias sillas

        // TODO - Escribir método para agregar una mesa. Al hacerlo, cambiarle el color a HEX

        /// <summary>
        /// TODO - Codificar para que agregue la silla en la lista de sillas
        /// </summary>
        /// <param name="chairs"></param>
        /// <param name="chair"></param>
        public void AddChair(in List<Chair> chairs, Chair chair)
        {           
        }
    }
}