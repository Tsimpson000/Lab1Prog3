using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class GuitarPick
    {
        //Fields
        string _brand;
        string _color;
        int _thickness;
        int _packQuantity;
        string _material;

        //Properties
        public string Brand { get => _brand; set => _brand = value; }
        public string Color { get => _color; set => _color = value; }
        public int Thickness { get => _thickness; set => _thickness = value; }
        public int PackQuantity { get => _packQuantity; set => _packQuantity = value; }
        public string Material { get => _material; set => _material = value; }
    }
}
