using Compras.clases;

namespace Compras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Facturacion");
            factura fact = new factura();
            string producto = null;
            double precio = 0, monto;
            int cantidad = 0;

            Console.WriteLine("Producto: ");
            producto = Console.ReadLine();
            Console.WriteLine("Precio: ");
            precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad: ");
            cantidad = int.Parse(Console.ReadLine());

            fact.producto = producto;
            fact.precio = precio;
            fact.cantidad = cantidad;

            monto = fact.calcularMonto();

            Console.WriteLine($"Nombre del producto: {producto}");
            Console.WriteLine($"Costo: {precio}");
            Console.WriteLine($"Cantidad: {cantidad}");
            Console.WriteLine($"Monto Total: {monto}");
        }
    }
}