partial class Program
{
    static void PrintMultiplicationTable(int number, int tabletLimit = 10)
    {
        WriteLine($"Tabla de multiplicar del número {number} desde el 1 hasta el {tabletLimit} \n");
        for (int i = 1; i <= tabletLimit; i++)
        {
            WriteLine($"{number} x {i} = {number * i}");
        }


    }

    // 🏆 Ejercicio:
    // Crear un método llamado `PrintFactorialTable` que reciba un número 
    // y muestre el factorial de todos los números desde 1 hasta el número ingresado.
    // Ejemplo: PrintFactorialTable(5);
    // 1! = 1
    // 2! = 2
    // 3! = 6
    // 4! = 24
    // 5! = 120

    static void PrintFactorialTable(int number)
    {
        WriteLine($"Factorial del número {number} desde el 1 hasta el {number} \n");

        for (int i = 1; i <= number; i++)
        {
            WriteLine($"{i}! = {Factorial(i)}");
        }
    }

    static int Factorial(int number)
    {
        int factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}