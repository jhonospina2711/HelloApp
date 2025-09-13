partial class Program
{
    static void Loops()
    {
        //While: Se usa hasta que se tiene la certeza de cuantas iteraciones se van a realizar
        int counter = 1;
        while (counter <= 5)
        {
            WriteLine($"Iteranción: {counter}");
            counter++;
        }

        //Do While: Se usa cuando no se tiene la certeza de cuantas iteraciones se van a realizar
        int number = 0;
        do
        {
            WriteLine($"Número: {number}");
            number++;

        } while (number < 3);

    }

}