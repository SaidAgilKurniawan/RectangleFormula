using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleFormula.Models
{
    public class Rectangle
    {
        public double Panjang { get; set; }
        public double Lebar { get; set; }

        public double CalculateArea()
        {
            return Panjang * Lebar;
        }
    }
}
