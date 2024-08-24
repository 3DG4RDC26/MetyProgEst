using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaFinal.clases
{
    internal class Nota
    {
        public double nota1 { get; set; }
        public double nota2 { get; set; }
        public double nota3 { get; set; }

        public double calcularNota()
        {
            return (nota1 + nota2 + nota3) / 3;
        }
        public Nota() { }
    }
}
