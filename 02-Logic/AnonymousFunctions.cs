partial class Program
{
    static void AnonymousFunctions()
    {
        WriteLine(square(5));
        WriteLine(lambdaSquare(10));
        List<int> numbers = [1, 2, 3, 4, 5];
        //Devuelve una lista de los numeros pares
        var evenNumbers = numbers.Where(x => x % 2 == 0);
        foreach (var even in evenNumbers)
        {
            WriteLine(even);
        }

    }
    // Esto es una funcion anonima
    static Func<int, int> square = delegate (int number)
    {
        return number * number;
    };

    //Esto es una funcion lambda
    static Func<int, int> lambdaSquare = x => x * x;


}