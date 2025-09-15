using System.Globalization;

partial class Program
{
    static void ConvertionToDateTime()
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("col-CO");
        //CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

        int friends = int.Parse("101");
        double cost = 25.50;
        DateTime birthday = DateTime.Parse("2 March 2025");
        WriteLine($"Tengo {friends} amigos para invitar a mi fiesta");
        WriteLine($"La celebración de mi cumpleaños sera el {birthday}");
        WriteLine($"Fecha en formato largo {birthday:D}");
        WriteLine($"El costo de la entrada sera: {cost:C}");
    }
}