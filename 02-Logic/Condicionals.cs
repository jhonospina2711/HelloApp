partial class Program
{
    static void Conditionals()
    {
        int age = 19;
        if (age >= 18)
        {
            WriteLine("Eres Mayor de edad");
        }
        else
        {
            WriteLine("Eres Menor de edad");
        }
        //if ternario
        string message = age >= 18 ? "Eres Mayor de edad" : "Eres menor de edad";
        WriteLine(message);

        //Multiples condiciones

        int temperature = 30;
        if (temperature > 35)
        {
            WriteLine("Hace mucho calor");
        }
        else if (temperature >= 20)
        {
            WriteLine("La tempratura es agradable");
        }
        else
        {
            WriteLine("Hace frio");
        }

        //Switch

        int day = 3;
        switch (day)
        {
            case 1:
                WriteLine("Lunes");
                break;
            case 2:
                WriteLine("Martes");
                break;
            case 3:
                WriteLine("Miercoles");
                break;
            default:
                WriteLine("Dia no valido");
                break;
        }

        //Switch expresion
        string dayMessage = day switch
        {
            1 => "Lunes",
            2 => "Martes",
            3 => "Miercoles",
            _ => "Dia no valido"
        };

        WriteLine(dayMessage);

    }
}