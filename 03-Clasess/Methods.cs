partial class Program
{
    static void Methods()
    {
        //Creamos una instancia del objeto Car
        Car car = new Car();
        car.Model = "Yaris";
        car.Year = 2022;
        WriteLine(car.ShowInfo());
        car.ShowMessage();
        car.ShowMessage("Cambiando de modelo");
        //Cambiamos el modelo del auto
        car.ChangeModel("Patrol");
        WriteLine(car.ShowInfo());


        Car.GeneralInfo();
    }
    class Car
    {
        //Se define la propiedad Model como nullable
        public string? Model { get; set; }
        //Se define la propiedad Year como nullable
        public int? Year { get; set; }

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