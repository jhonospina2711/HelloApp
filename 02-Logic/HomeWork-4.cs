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
}