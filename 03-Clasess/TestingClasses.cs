partial class Program
{
    static void TestingClasses()
    {
        Vehicle toyota = new Vehicle();
        toyota.Brand = "Toyota";
        toyota.Model = "Corolla";
        toyota.Year = 2020;
        toyota.ShowInfo();

        //Otra forma de inicializar un objeto
        Vehicle honda = new Vehicle { Brand = "Honda", Model = "Civic", Year = 2019 };
        honda.ShowInfo();

        //Se crea un objeto usando el constructor
        Vehicle renault = new Vehicle("Reanault", "Duster", 2022);
        renault.ShowInfo();
    }
}

class Vehicle
{
    //Propiedades
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public int? Year { get; set; }

    //Metodos

    // Metodo constructor

    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public Vehicle(){}

    public void ShowInfo()
    {
        WriteLine($"Este vehículo es un {Brand} {Model} del año {Year}");
    }
}