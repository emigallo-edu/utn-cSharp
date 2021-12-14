using static Clase2.Models.Material;

namespace Clase2.Models
{
    public class Table
    {
        public Table(int code, string color, Materials material, int width, int length )
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
    }
}