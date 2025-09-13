
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

        WriteLine($"Primer Elemento {numbersArray[0]}");
        WriteLine($"Primer Elemento {numbersArray[2]}");
        //Tamaño arreglo
        WriteLine($"El numero de elementos es: {numbersArray.Length}");

        //Desde el final del arreglo ^
        //Nota: Para obtener el simbolo ^ se usa alt + 94
        WriteLine($"El ultimo elemento es: {numbersArray[^1]}");
        WriteLine($"Penultimo elemento es: {numbersArray[^2]}");
        //Rangos para obtener subarreglos
        int[] firstThree = numbersArray[..3];
        int[] fromIndexTwo = numbersArray[2..];
        WriteLine($"Los primeros tres {firstThree}");
        foreach(var number in firstThree)
        {
            WriteLine($"Elemento: {number}");
        }
    }
}