using NumAlCubo.clases;

namespace NumAlCubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un numero");
            ElevacionCubo Elevar = new ElevacionCubo();
            double num = 0, elevacion;

            Console.WriteLine("Numero: ");
            num = double.Parse(Console.ReadLine());

            Elevar.num = num;

            elevacion = Elevar.CalcularCubo();

            Console.WriteLine($"Numero ingresado:{num}");
            Console.WriteLine($"Numero elevado al cubo: {elevacion}");
        }
    }
}
