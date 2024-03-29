﻿using System;
using static Clase3.Models.Material;

namespace Clase3.Models
{
    public class Chair : ICloneable
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

        public object Clone()
        {
            return new Chair(this.Code, this.Color.ToUpper(), this.Material, this.HasBackRest);
        }
    }
}