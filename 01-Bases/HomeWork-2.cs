partial class Program
{
    //Metodo para calcular los años que el usuario ha vivido
    static void DaysOfLife()
    {
        DateTime birthDate = new DateTime(1987, 07,11);
        TimeSpan difference = DateTime.Now - birthDate;
        Console.WriteLine($"Has vivido {difference.Days} días");
    }

    
// 🏆 Ejercicio:
// Pedir al usuario su fecha de nacimiento y calcular cuántos días faltan para su próximo cumpleaños.
// Consideraciones:
// - La fecha de nacimiento ingresada debe ser interpretada correctamente, 
//   asegurando que las comparaciones de fechas no sean afectadas por las horas.
// - Investigar acerca de `CultureInfo.InvariantCulture` para que no afecte la configuración regional del sistema.
// - Se debe manejar el caso en que el cumpleaños ya haya pasado en el año actual, 
//   sumando un año para calcular la fecha del próximo (opcional).

    static void DaysUnilNextBirthDay()
    {
        Console.Write("Ingrese su fecha de nacimiento en formato (dd/mm/aaaa): ");
        string InputBirthDate= Console.ReadLine()!;
        try
        {
            DateTime birthDate = DateTime.ParseExact(InputBirthDate, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            DateTime nextBirthday = new DateTime(DateTime.Now.Year, birthDate.Month, birthDate.Day);
            
            if (nextBirthday < DateTime.Now)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }
            TimeSpan daysLeft = nextBirthday - DateTime.Now;
            Console.WriteLine($"Faltan {daysLeft.Days} días para su próximo cumpleaños.");
        }
        catch (FormatException)
        {
            Console.WriteLine("El formato de la fecha es incorrecto. Por favor, use el formato (dd/mm/aaaa).");
        }

    }
}