
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

        WriteLine($"Fecha y hora actual: {now}");
        WriteLine($"Fecha actual: {today}");
        WriteLine($"Hace una semana la fecha {now} era { nowWeekAgo.ToString("dd/MM/yyyy")}");
        WriteLine($"Fecha personalizada: {customDate}");
        WriteLine($"Día de la semana {weekDay}");

    }

}