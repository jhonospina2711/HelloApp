// 3. Manejar excepciones en caso de errores al procesar los datos.

partial class Program
{
    static void SalesAnalysis()
    {
        try
        {
            List<Sale> sales =
            [
                new Sale("Laptop", "Electrónica", 1500),
            new Sale("Teléfono", "Electrónica", 900),
            new Sale("Silla", "Muebles", 1200),
            new Sale("Escritorio", "Muebles", 800),
            new Sale("Tablet", "Electrónica", 1300),
            new Sale("Lámpara", "Iluminación", 400)
            ];

            //Filtrar y mostrar las ventas con monto superior a 1000.
            WriteLine("Ventas con monto mayor a 1000:");

            var highValueSales = from sale in sales
                                 where sale.Amount > 1000
                                 select sale;

            foreach (var sale in highValueSales)
            {
                WriteLine($"Producto: {sale.Product}, Categoría: {sale.Category}, Monto: {sale.Amount:C}");
            }



            //Agrupar las ventas por categoría y calcular el total de ventas por categoría.
            var salesByCategory = from sale in sales
                                  group sale by sale.Category into categoryGroup
                                  select new
                                  {
                                      Category = categoryGroup.Key,
                                      TotalAmount = categoryGroup.Sum(s => s.Amount)
                                  };
            //Method syntax alternative
            var salesByCategoryMethod = sales.GroupBy(s => s.Category).
            Select(g => new
            {
                Category = g.Key,
                TotalAmount = g.Sum(s => s.Amount)
            });
            WriteLine("\nTotal ventas por categoría:");
            foreach (var category in salesByCategory)
            {
                WriteLine($"Categoría: {category.Category}, Total Ventas: {category.TotalAmount:C}");
            }

        }
        catch (Exception ex)
        {
            WriteLine($"Ocurrió un error al analizar las ventas: {ex.Message}");
        }
    }
}

class Sale
{
    public string? Product { get; set; }
    public string? Category { get; set; }
    public double Amount { get; set; }

    public Sale(string product, string category, double amount)
    {
        Product = product;
        Category = category;
        Amount = amount;
    }
}