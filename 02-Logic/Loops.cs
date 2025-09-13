partial class Program
{
    static void Loops()
    {
        //While: Se usa hasta que se tiene la certeza de cuantas iteraciones se van a realizar
        int counter = 1;
        while (counter <= 5)
        {
            //WriteLine($"Iteranción: {counter}");
            counter++;
        }

        //Do While: Se usa cuando no se tiene la certeza de cuantas iteraciones se van a realizar
        int number = 0;
        do
        {
            //WriteLine($"Número: {number}");
            number++;

        } while (number < 3);

        //For: Se usa cuando se tiene la certeza de cuantas iteraciones se van a realizar
        for (int i = 0; i <= 5; i++)
        {
            WriteLine($"Iteración: {i}");
        }
        for (int i = 10; i >= 0; i -= 2)
        {
            WriteLine(i);
        }
        //For Each: Se usa para recorrer colecciones
        //Array
        string[] fruits = { "Manzana", "Pera", "Piña" };
        foreach (var fruit in fruits)
        {
            WriteLine(fruit);
        }

        //List
        List<string> names = ["Pedro", "Luis", "Nancy"];
        foreach (var name in names) {
            WriteLine(name);
        }

    }

}