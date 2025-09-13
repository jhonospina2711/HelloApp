partial class Program
{
    static void Generics()
    {
        string[] names = { "Juan", "Luis", "Diana" };
        int[] numbers = { 1, 2, 3, 25 };
        //Impresión de funciones sin el uso de genericos
        //WriteLine($"El tamaño del areglo númerico es: {GetIntArrayLength(numbers)}");
        //WriteLine($"El tamaño del areglo nombres es: {GetStringArrayLength(names)}");
        //Impresión de funciones con el uso de genericos
        WriteLine($"El tamaño del areglo númerico es: {GetArrayLength(numbers)}");
        WriteLine($"El tamaño del areglo nombres es: {GetArrayLength(names)}");

        //Instanciación de la clase genérica

        Box<int> numberBox = new Box<int> { Content = 50 };
        Box<string> stringBox = new Box<string> { Content = "Ahora soy Texto" };
        numberBox.Show();
        stringBox.Show();

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

    class Box<T>
    {
        public T? Content { get; set; }
        public void Show()
        {
            WriteLine($"El contenido de la caja es: {Content}");
        }
    }
}