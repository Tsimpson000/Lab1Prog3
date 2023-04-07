using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Wristwatch
    {
        //Fields
        string _brand;
        int _price;
        string _material;
        string _strapColor;
        string _faceColor;

        //Properties
        public string Brand { get => _brand; set => _brand = value; }
        public int Price { get => _price; set => _price = value; }
        public string Material { get => _material; set => _material = value; }
        public string StrapColor { get => _strapColor; set => _strapColor = value; }
        public string FaceColor { get => _faceColor; set => _faceColor = value; }
    }
}
