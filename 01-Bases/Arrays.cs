
partial class Program
{
    static void Arrays()
    {
        int[] numbers = new int[5];
        numbers[0] = 1;
        numbers[1] = 3;

        //Iniciacilización Directa
        int[] numbersArray = [5, 10, 15, 20, 25, 30];
        //Índices

        Console.WriteLine($"Primer Elemento {numbersArray[0]}");
        Console.WriteLine($"Primer Elemento {numbersArray[2]}");
        //Tamaño arreglo
        Console.WriteLine($"El numero de elementos es: {numbersArray.Length}");



    }
}