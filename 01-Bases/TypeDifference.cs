partial class Program
{
    static void TypeDifference()
    {
        int x = 5;
        int y = x;
        y = 15;
        WriteLine($"x:{x}, y:{y}");

        // Los tipos de referencia son variables que almacenan una referencia a un objeto en memoria
        Person person1 = new Person { Name = "Carlos" };
        WriteLine($"Primera Impresion de Persona1: {person1.Name}");
        Person person2 = person1;
        WriteLine($"Primera Impresion de Persona2: {person2.Name}");
        person2.Name = "Alicia";
        WriteLine($"Segunda Impresion de Persona1: {person1.Name}");
        WriteLine($"Segunda Impresion de Persona2: {person2.Name}");
    }
}


class Person
{
    public string? Name { get; set; }
}