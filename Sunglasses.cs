using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Sunglasses
    {
        //Fields
        int _tintGradient;
        string _frameType;
        string _frameColor;
        string _lenseShape;
        string _lenseColor;
        string _prescription;
        //Properties
        public int TintGradient { get => _tintGradient; set => _tintGradient = value; }
        public string FrameType { get => _frameType; set => _frameType = value; }
        public string FrameColor { get => _frameColor; set => _frameColor = value; }
        public string LenseShape { get => _lenseShape; set => _lenseShape = value; }
        public string LenseColor { get => _lenseColor; set => _lenseColor = value; }
        public string Prescription { get => _prescription; set => _prescription = value; }
    }
}
