partial class Program
{
    static void ShowNuericTypes()
    {
        int integerNumber = 42;
        double doubleNumber = 3.1416;
        float floatNumber = 2.718f;
        long longNumber = 123_456_789_012_345_678_9L;
        decimal monetaryNumber = 99.99M;
        WriteLine($"Entero: {integerNumber}");
        WriteLine($"Double: {doubleNumber}");
        WriteLine($"Float: {floatNumber}");
        WriteLine($"Long: {longNumber}");
        WriteLine($"Monetary: {monetaryNumber}");

    }
}