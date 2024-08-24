using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCirculo.clases
{
    internal class Area
    {
    public double radio { get; set; }
    public double calcularAreaCirc()
    {
    return Math.PI * radio * radio;
    }
    public Area() { }
    }
}

