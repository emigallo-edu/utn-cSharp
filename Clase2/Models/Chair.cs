using System;
using static Clase2.Models.Material;

namespace Clase2.Models
{
    public class Chair
    {
        public Chair(int code, string color, Materials material, Boolean hasBackRest)
        {
            this.Code = code;
            this.Color = color;
            this.Material = material;
            this.HasBackRest = hasBackRest;
        }

        public int Code { get; set; }
        public string Color { get; init; }
        public Materials Material { get; init; }
        public Boolean HasBackRest { get; init; }
    }
}