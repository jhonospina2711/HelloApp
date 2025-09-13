partial class Program
{
    static void IventoryManager()
    {
        string[] products = ["Monitor", "Mouse", "Teclado"];
        int[] stock = [10, 25, 5];
        double[] prices = [250.50, 20.50, 45.00];

        WriteLine("1. Comprar Producto \n2. Salir");
        WriteLine("\nIngrese una opción:");
        int seleccionUsuario = int.Parse(Console.ReadLine()!);
        if (seleccionUsuario == 1)
        {
            WriteLine("Inventario de Productos");
            WriteLine("---------------------");
            for (int i = 0; i < products.Length; i++)
            {
                WriteLine($"Producto: {products[i]}, Stock: {stock[i]}, Precio: {prices[i]:C2}");
            }
            int contador = 0;
            WriteLine("\nIngrese el producto que desea comprar: ");
            string? searchProduct = Console.ReadLine();

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Equals(searchProduct, StringComparison.OrdinalIgnoreCase))
                {
                    WriteLine("\nIngrese la cantidad de producto que desea comprar: ");
                    int? quantity = int.Parse(Console.ReadLine()!);
                    if (quantity <= stock[i])
                    {
                        contador++;
                        double? total = quantity * prices[i];
                        WriteLine($"Compra Exitosa!. Total a pagar por {quantity} {products[i]} es: {total:C2}");
                        WriteLine($"Stock restante para el producto {products[i]} es: {stock[i] - quantity}");

                    }
                    else
                    {
                        WriteLine($"No hay suficiente stock de {products[i]}. Stock disponible: {stock[i]}");
                    }
                }

            }
            if (contador == 0)
            {
                WriteLine($"Producto {searchProduct} no encontrado.");
            }

        }
        else if (seleccionUsuario == 2)
        {
            WriteLine("Gracias por su visita...");
            return;
        }
        else
        {
            WriteLine("Opción no válida.");
        }
    }
}