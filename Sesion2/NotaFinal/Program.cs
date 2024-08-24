using NotaFinal.clases;

namespace NotaFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular nota final");
            Nota nota = new Nota();
            double nota1 = 0;
            double nota2 = 0;
            double nota3 = 0;
            double notaFinal = 0;

            Console.WriteLine("Nota1: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota2: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota3: ");
            nota3 = double.Parse(Console.ReadLine());

            nota.nota1 = nota1;
            nota.nota2 = nota2;
            nota.nota3 = nota3;

            notaFinal = nota.calcularNota();

            Console.WriteLine($"Nota1: {nota1}");
            Console.WriteLine($"Nota2: {nota2}");
            Console.WriteLine($"Nota3: {nota3}");
            Console.WriteLine($"Nota Final: {notaFinal}");
        }
    }
}
