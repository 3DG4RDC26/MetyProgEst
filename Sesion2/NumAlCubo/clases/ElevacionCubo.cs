using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumAlCubo.clases
{
    internal class ElevacionCubo
    {
        public double num { get; set; }
        public double CalcularCubo()
        {
            return Math.Pow(num, 3);
        }
        public ElevacionCubo() { }
    }
}
