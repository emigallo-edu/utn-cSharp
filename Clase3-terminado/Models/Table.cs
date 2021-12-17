using System;
using static Clase3.Models.Material;
using Newtonsoft.Json;

namespace Clase3.Models
{
    public class Table : ICloneable
    {
        public Table(int code, string color, Materials material, int width, int length)
        {
            this.Code = code;
            this.Color = color;
            this.Material = material;
            this.Width = width;
            this.Length = length;
        }

        public int Code { get; set; }
        public Materials Material { get; init; }
        public string Color { get; set; }
        public int Width { get; init; }
        public int Length { get; init; }
        public double Price { get; set; }
        public Umbrella Umbrella { get; set; }

        public object Clone()
        {
            string serializado = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject(serializado);
        }
    }
}