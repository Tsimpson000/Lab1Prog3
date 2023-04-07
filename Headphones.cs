using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Headphones
    {
        //Fields
        int _lowDecibel;
        int _highDecidbel;
        string _type;
        string _color;
        string _padMaterial;

        //Properties
        public int LowDecibel { get => _lowDecibel; set => _lowDecibel = value; }
        public int HighDecidbel { get => _highDecidbel; set => _highDecidbel = value; }
        public string Type { get => _type; set => _type = value; }
        public string Color { get => _color; set => _color = value; }
        public string PadMaterial { get => _padMaterial; set => _padMaterial = value; }
    }
}
