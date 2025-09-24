partial class Program
{
    static void AbstracClassExamples()
    {
        HomeAppliance myWasher = new WashingMachine { Brand = "Samsung" };
        HomeAppliance myMicrowave = new Microwave { Brand = "DG" };

        // Llamamos al método <<<ShowBrand>>> usando una referencia de tipo <<<HomeAppliance>>>.
        // Se ejecuta la implementación heredada de la clase base.
        myWasher.ShowBrand();

        // Llamamos al método <<<TurnOn>>> usando una referencia de tipo <<<HomeAppliance>>>.
        // Gracias al polimorfismo, se ejecuta la versión específica de <<<WashingMachine>>>.
        myWasher.TurnOn();

        // Llamamos al método <<<ShowBrand>>> usando una referencia de tipo <<<HomeAppliance>>>.
        // Se ejecuta la implementación heredada de la clase base.
        myMicrowave.ShowBrand();

        // Llamamos al método <<<TurnOn>>> usando una referencia de tipo <<<HomeAppliance>>>.
        // Gracias al polimorfismo, se ejecuta la versión específica de <<<Microwave>>>.
        myMicrowave.TurnOn();

    }
}

// Clase abstracta: no se puede instanciar directamente, solo se puede heredar.
abstract class HomeAppliance
{
    public string? Brand { get; set; }

    // Método abstracto: las subclases deben proporcionar su propia implementación.
    public abstract void TurnOn();

    // Método concreto: todas las subclases heredan esta implementación.
    public void ShowBrand()
    {
        WriteLine($"La marca del electrodoméstico es: {Brand}");
    }

}
// Clase derivada que implementa el método principal abstracto.
class WashingMachine : HomeAppliance
{

    // Implementación específica del método abstracto <<<TurnOn>>>.
    public override void TurnOn()
    {
        WriteLine("🌀 La lavadora a inicializado el ciclo de lavado 🌀");
    }
}
// Otra clase derivada que implementa el método principal abstracto <<<HomeAppliance>>>.
class Microwave : HomeAppliance
{
    // Implementación específica del método abstracto <<<TurnOn>>>.
    public override void TurnOn()
    {
        WriteLine("🔥El microondas esta calentando la comida.");
    }
}