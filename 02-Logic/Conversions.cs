partial class Program
{
    static void Conversions()
    {
        int number = 42;
        double decimalNumber = number;
        WriteLine(decimalNumber);

        double explicitDecimalNumber = 45.5;
        int integerNumber = (int)explicitDecimalNumber;
        WriteLine(integerNumber);

        //Para hacer casteos tenemos convert o Parse
        string text = "123";
        int parsedNumber = int.Parse(text);
        WriteLine(parsedNumber);

        //convert
        double anotherDecimalNumber = 50.8;
        int convertedNumber = Convert.ToInt32(anotherDecimalNumber);
        WriteLine(convertedNumber); //Redondear
        int castedNumber = (int)anotherDecimalNumber;
        WriteLine(castedNumber); //Trucar
    }
}