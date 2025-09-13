partial class Program
{
    static void Generics()
    {
        string[] names = { "Juan", "Luis", "Diana" };
        int[] numbers = { 1, 2, 3, 25 };
        //Impresión de funciones sin el uso de genericos
        //Console.WriteLine($"El tamaño del areglo númerico es: {GetIntArrayLength(numbers)}");
        //Console.WriteLine($"El tamaño del areglo nombres es: {GetStringArrayLength(names)}");
        //Impresión de funciones con el uso de genericos
        Console.WriteLine($"El tamaño del areglo númerico es: {GetArrayLength(numbers)}");
        Console.WriteLine($"El tamaño del areglo nombres es: {GetArrayLength(names)}");

    }

    //Metodos sin el uso de genericos
    static int GetIntArrayLength(int[] array)
    {
        return array.Length;
    }
    static int GetStringArrayLength(string[] array)
    {
        return array.Length;
    }

    //Metodo Genérico

    static int GetArrayLength<T>(T[] array)
    {
        return array.Length;
    }
}