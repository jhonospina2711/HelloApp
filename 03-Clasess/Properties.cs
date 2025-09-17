partial class Program
{
    static void Properties()
    {
        //Creamos un objeto de la clase Animal
        Animal animal = new Animal("Bosque");
        //Definimos la espcie 
        animal.Species = "Lobo";
        //Definimos la edad
        animal.Age = -5;
        WriteLine($"Donde vive en el: {animal.Habitat}, que animal es: {animal.Species} de categoria {animal.Category} y tiene {animal.Age} años");

    }

}

class Animal
{
    //Declaramos la propiedad Species con un valor por defecto
    public string Species { get; set; } = "Desconocida";

    //Creamos una propiedad Category de solo lectura con un valor por defecto
    public string Category { get; } = "Vertebrado";

    //Campo privado para la propiedad Age
    private int age;

    //propiedad Age con validacion en el set
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("La edad no puede ser negativa");
            }
            //Asignamos el valor al campo privado
            age = value;
        }
    }

    //Propiedad de solo lectura para Habitat
    public string Habitat { get; }

    //Constructor que recibe el habitat
    public Animal(string habitat)
    {
        Habitat = habitat;
    }
}