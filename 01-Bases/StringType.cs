partial class Program
{
    static void ShowStringType()
    {
        string name = "Juan";
        string message = "Hola " + name;  //Concatenar 
        string interpolatedMessage = $"Hola {name}"; //Interpolar
        Console.WriteLine(message);
        Console.WriteLine(interpolatedMessage);
        Console.WriteLine($"Tu nombre tiene {name.Length} letras.");
        Console.WriteLine($"Tu nombre en mayusculas es {name.ToUpper()}");
        Console.WriteLine($"Tu nombre en minusculas es {name.ToLower()}");
        int number = 13;
        Console.WriteLine(number);
        bool isString = true;
        Console.WriteLine(isString);

    }
}