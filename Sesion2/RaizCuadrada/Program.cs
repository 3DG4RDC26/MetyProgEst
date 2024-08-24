using RaizCuadrada.clases;

namespace RaizCuadrada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un numero");
            Raiz raizc = new Raiz();
            double num = 0, resultRaiz;

            Console.WriteLine("Numero: ");
            num = double.Parse(Console.ReadLine());

            raizc.num = num;

            resultRaiz = raizc.calcularRaiz();

            Console.WriteLine($"Numero ingresado: {num}");
            Console.WriteLine($"Raiz cuadrada del numero ingresado: {resultRaiz}");
        }
    }
}