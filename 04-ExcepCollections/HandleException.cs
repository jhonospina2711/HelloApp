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

            if (double.TryParse(amount, out double amountValue))
            {
                WriteLine($"El monto ingresado es: {amountValue:C}");
            }
            else
            {
                WriteLine("No se pudo convertir el texto a número.");
            }

            //double amountValue = double.Parse(amount);
            ValidateAge(16);


        }
        catch (DivideByZeroException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine($"Error División por cero: {ex.Message}");
        }
        catch (FormatException) when (amount?.Contains("$") == true)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("No es necesario ingresar el símbolo de $");
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            Console.ResetColor();
            WriteLine("Esto siempre se ejecuta.");
        }

    }

    static void ValidateAge(int age)
    {
        if (age < 18)
        {
            throw new ArgumentException("La edad debe ser mayor o igual a 18.");
        }
        
    }
}