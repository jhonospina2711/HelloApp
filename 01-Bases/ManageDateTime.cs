
using System.Data;
partial class Program
{
    static void ShowTime()
    {
        //* Obtener la fecha y hora actual
        DateTime now = DateTime.Now;
        //* Obtener solo la fecha
        DateTime today = DateTime.Today;
        //* Resta 7 dias a la fecha actual
        DateTime nowWeekAgo = now.AddDays(-7);
        //* Crear una fecha especifica
        DateTime customDate = new DateTime(2025, 3, 2);
        //* Devuelve un dia de la semana en nombre ejemplo: Lunes, Martes, Miercoles
        DayOfWeek weekDay = now.DayOfWeek;

        Console.WriteLine($"Fecha y hora actual: {now}");
        Console.WriteLine($"Fecha actual: {today}");
        Console.WriteLine($"Hace una semana la fecha {now} era { nowWeekAgo.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Fecha personalizada: {customDate}");
        Console.WriteLine($"Día de la semana {weekDay}");

    }

}