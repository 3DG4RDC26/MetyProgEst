using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaizCuadrada.clases
{
    internal class Raiz
    {
        public double num {  get; set; }
        public double calcularRaiz()
        {
            return Math.Sqrt(num);
        }
        public Raiz() { }
    }
}
