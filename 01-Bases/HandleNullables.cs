partial class Program
{
    static void HandleNullables()
    {
        // No nulificable
        string firstName = "Carlos";

        // Nulificable
        string? lastName = null;

        WriteLine($"Nombre: {firstName}");
        if (lastName != null)
        {
            WriteLine($"Apellido: {lastName}");
        }
        else
        {
            WriteLine($"Apellido: No disponible");
        }

        // Operador de coalescencia nula ??
        WriteLine($"Apellido: {lastName ?? "Apellido no especificado!"} ");

        //Operador de acceso nulo seguro ?.
        string? text = null;
        WriteLine(text?.Length);
        WriteLine("Sigue Ejecutando");

    }
}