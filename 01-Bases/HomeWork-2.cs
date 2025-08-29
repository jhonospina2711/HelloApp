partial class Program
{
    static void DaysOfLife()
    {
        DateTime birthDate = new DateTime(1983, 3, 2);
        TimeSpan difference = DateTime.Now - birthDate;
        Console.WriteLine($"Has vivido {difference.Days} días");
    }

    static void DaysUnilNextBirthDay()
    {
        Console.Write("Ingrese su fecha de nacimiento en formato (dd/mm/aaaa): ");
        string fechaNacimiento = Console.ReadLine();
        DateTime birthDate;
    }
}