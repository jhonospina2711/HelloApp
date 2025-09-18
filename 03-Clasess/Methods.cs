partial class Program
{
    static void Methods()
    {
        //Creamos una instancia del objeto Car
        Car car = new Car();
        car.Model = "Yaris";
        car.Year = 2022;
        WriteLine(car.ShowInfo());
        // car.ShowMessage();
        // car.ShowMessage("Cambiando de modelo");
        // //Cambiamos el modelo del auto
        // car.ChangeModel("Patrol");
        // WriteLine(car.ShowInfo());

        // Car.GeneralInfo();

        //Instanciamos un objetos a traves de un constructor
        Car sportsCar = new Car("Ferrari", 2020);
        WriteLine(sportsCar.ShowInfo());

        //Otra forma de instanciar un objeto usando la sintaxis simplifcada
        Car collectionCar = new() { Model = "Cadillac", Year = 1960 };
        WriteLine(collectionCar.ShowInfo());

        //Lista de objetos
        List<Car> cars = new()
        {
            new Car(){Model="Duster", Year=2021},
            new Car(){Model="StepWay", Year=2019},
            new Car(){Model="Capture", Year=2000},
        };
        //recorremos la lista
        WriteLine("Listado de autómoviles:");
        foreach (var item in cars)
        {
            WriteLine(item.ShowInfo());
        }
    }
    class Car
    {
        //Se define la propiedad Model como nullable
        public string? Model { get; set; }
        //Se define la propiedad Year como nullable
        public int? Year { get; set; }

        public Car(string model, int year)
        {
            Model = model;
            Year = year;
        }

        //Se crea un constructor sin parametros
        public Car() { }

        //Este metodo es para cambiar una propiedad del objeto
        public void ChangeModel(string newModel)
        {
            Model = newModel;
        }

        //Este metodo devulve una cadena con la informacion del objeto
        public string ShowInfo()
        {
            return $"Automóvil: {Model}, Año {Year}";
        }

        //Sobrecarga de métodos
        public void ShowMessage() => WriteLine("Este es un autómovil");
        public void ShowMessage(string message) => WriteLine(message);

        //Definición de un método estático
        public static void GeneralInfo() {
            WriteLine("El autómovil es uno de los transportes mas utilizados");  
        } 
    }
}