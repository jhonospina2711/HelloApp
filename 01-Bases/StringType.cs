partial class Program
{
    static void ShowStringType()
    {
        string name = "Juan";
        string message = "Hola " + name;  //Concatenar 
        string interpolatedMessage = $"Hola {name}"; //Interpolar
        WriteLine(message);
        WriteLine(interpolatedMessage);
        WriteLine($"Tu nombre tiene {name.Length} letras.");
        WriteLine($"Tu nombre en mayusculas es {name.ToUpper()}");
        WriteLine($"Tu nombre en minusculas es {name.ToLower()}");
        int number = 13;
        WriteLine(number);
        bool isString = true;
        WriteLine(isString);

    }
}