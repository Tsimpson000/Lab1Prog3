using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Dumbbells
    {
        //Fields
        string _name;
        int _weight;
        int _maxReps;
        int _score;

        //Properties
        public string Name { get => _name; set => _name = value; }
        public int Weight { get => _weight; set => _weight = value; }
        public int MaxReps { get => _maxReps; set => _maxReps = value; }
        public int Score { get => _score; set => _score = value; }
    }
}
