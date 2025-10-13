partial class Program
{
    static string? amount;
    static void HandleException()
    {

        try
        {
            // int number = 10;
            // int result = number / 0;
            Write("Ingrese un monto: ");
            amount = ReadLine();
            if (string.IsNullOrEmpty(amount)) return;

            double amountValue = double.Parse(amount);
            WriteLine($"El monto ingresado es: {amountValue:C}");
        }
        catch (DivideByZeroException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine($"Error División por cero: {ex.Message}");
        }
        catch (FormatException) when (amount?.Contains("$") == true)
        {
            WriteLine("No es necesario ingresar el símbolo de $");
        }
        catch (Exception ex)
        {
            WriteLine($"Error: {ex.Message}");
        }

    }
}