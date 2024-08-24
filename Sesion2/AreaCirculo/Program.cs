using AreaCirculo.clases;

namespace AreaCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Ingrese el radio del círculo"); 
        Area A = new Area();
        double radio = 0, area;

        Console.WriteLine("Radio:");
        radio = double.Parse(Console.ReadLine());

        A.radio = radio;

        area = A.calcularAreaCirc();

        Console.WriteLine($"Radio ingresado: {radio}");
        Console.WriteLine($"El área del círculo es: {area}");
        }
    }
}
