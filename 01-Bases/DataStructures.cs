
partial class Program
{
    static void DataStructures()
    {
        User pedro = new User { Name = "Pedro", Age = 30 };
        pedro.Greet();
        Point punto = new Point { X = 30, Y = 20 };
        Console.WriteLine($"Punto ({punto.X}, {punto.Y})");
        CellPhone nokia = new CellPhone("Nokia 225", 2024);
        Console.WriteLine($"Celular: {nokia.Model}, Año: {nokia.Year}");
    }

    class User
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public void Greet()
        {
            Console.WriteLine($"Hola, Soy el usuario {Name} y tengo una edad de {Age} años");
        }
    }

    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    record CellPhone(string Model, int Year);
}