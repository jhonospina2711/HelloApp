partial class Program
{
    static void IventoryManager()
    {
        string[] products = ["Monitor", "Mouse", "Teclado"];
        int[] stock = [10, 25, 5];
        double[] prices = [250.50, 20.50, 45.00];

        Console.WriteLine("1. Comprar Producto \n2. Salir");
        Console.WriteLine("\nIngrese una opción:");
        int seleccionUsuario = int.Parse(Console.ReadLine()!);
        if (seleccionUsuario == 1)
        {
            Console.WriteLine("Inventario de Productos");
            Console.WriteLine("---------------------");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Producto: {products[i]}, Stock: {stock[i]}, Precio: {prices[i]:C2}");
            }
            int contador = 0;
            Console.WriteLine("\nIngrese el producto que desea comprar: ");
            string? searchProduct = Console.ReadLine();

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Equals(searchProduct, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nIngrese la cantidad de producto que desea comprar: ");
                    int? quantity = int.Parse(Console.ReadLine()!);
                    if (quantity <= stock[i])
                    {
                        contador++;
                        double? total = quantity * prices[i];
                        Console.WriteLine($"Compra Exitosa!. Total a pagar por {quantity} {products[i]} es: {total:C2}");
                        Console.WriteLine($"Stock restante para el producto {products[i]} es: {stock[i] - quantity}");

                    }
                    else
                    {
                        Console.WriteLine($"No hay suficiente stock de {products[i]}. Stock disponible: {stock[i]}");
                    }
                }

            }
            if (contador == 0)
            {
                Console.WriteLine($"Producto {searchProduct} no encontrado.");
            }

        }
        else if (seleccionUsuario == 2)
        {
            Console.WriteLine("Gracias por su visita...");
            return;
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }
    }
}