partial class Program
{
    static void Operators()
    {
        int number = 12;

        bool isEven = number % 2 == 0;

        bool isGreaterThanTen = number > 10;

        if (isEven && isGreaterThanTen)
        {
            Console.WriteLine($"El número {number} es par y mayor que 10.");

        }
        else if (!isEven && isGreaterThanTen)
        {
            Console.WriteLine($"El número {number} es par y mayor que 10.");
        }
        else
        {
            Console.WriteLine($"El número {number} no cumple con las indicaciones.");
        }

        // Operador ternetio (?:)

        int age = 15;
        string category = age > 18 ? "Adulto" : "Menor de edad";
        Console.WriteLine(category);
    }
}