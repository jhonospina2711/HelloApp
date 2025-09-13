partial class Program
{
    static void SalesReport()
    {
        string product = "Laptop";
        int quantitySold = 3;
        double unitPrecio = 750.99;
        double totalAmount = quantitySold * unitPrecio;
        WriteLine($"Product: {product}");
        WriteLine($"Cantidad vendida: {quantitySold}");
        WriteLine($"Total generado: {totalAmount:C}");

    }

    static void SalaryCalculator()
    {

        WriteLine("Calculadora de Salario");

        Console.Write("Ingrese su nombre: ");
        string name = Console.ReadLine() ?? "Trabajador No Identificado";

        //* Obtenemos la cantidad de horas trabajadas
        Console.Write("Ingrese las horas trabajadas: ");
        string horasTrabajadasInput = Console.ReadLine() ?? "0";
        int horasTrabajadas = Convert.ToInt32(horasTrabajadasInput);

        //* Solicitamos ingresar el salario por hora 
        Console.Write("Ingrese el valor de la hora: ");
        string valorHoraTrabajadaInput = Console.ReadLine() ?? "0";
        double valorHoraTrabajada = Convert.ToDouble(valorHoraTrabajadaInput);



        //* Calculamos el salario Total
        double totalSalario = valorHoraTrabajada * horasTrabajadas;

        //* Devolvemos al usuario el resultado
        WriteLine($"El trabajador {name}, obtuvo un salario de: {totalSalario:C} por {horasTrabajadas} horas trabajadas.");
    }
}