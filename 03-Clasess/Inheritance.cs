partial class Program
{
    public static void Inheritance()
    {
        // Crear instancia de la clase derivada HogwartsStudent.
        // Usamos la clase base <<<Character>>> como referencia, pero el objeto es del tipo <<<HogwartsStudent>>>.
        HogwartsStudent student = new HogwartsStudent() { Name = "Harry Potter", House = "Gryffindor" };

        // Crear instancia de la clase derivada <<<HogwartsProfessor>>>.
        // Usamos la clase base <<<Character>>> como referencia, pero el objeto es del tipo <<<HogwartsProfessor>>>.
        HogwartsProfessor professor = new HogwartsProfessor() { Name = "Severus Snape", Subject = "Potions" };

        // Llamamos al método <<<Greet, sobrescrito en <<<HogwartsStudent>>>.
        student.Greet();
        // Llamamos al método <<<ShowHouse>>>, exclusivo de <<<HogwartsStudent>>>.
        student.ShowHouse();        

        // Llamamos al método <<<Greet, sobrescrito en <<<HogwartsProfessor>>>.
        // Gracias al polimorfismo, se ejecuta la versión específica de la clase HogwartsProfessor.
        professor.Greet();

        // Llamamos al método MySubject, exclusivo de HogwartsProfessor.
        professor.MySubject();

    }

    // Clase base
    class Character
    {
        public string? Name { get; set; }
        public virtual void Greet()
        {
            WriteLine($"Hola soy {Name}");
        }
    }

    //Hereda de la clase base <<<Character>>>
    class HogwartsStudent : Character
    {
        public string? House { get; set; }

        //Sobrescribimos el metodo Greet
        public override void Greet()
        {
            WriteLine($"Hola, soy {Name} y soy estudiante");
        }


        public void ShowHouse()
        {
            WriteLine($"Pertenezco a la casa {House} en Hogwarts.");
        }

    }

    //Hereda de Character
    class HogwartsProfessor : Character
    {
        public string? Subject { get; set; }

        //Sobrescribimos el metodo Greet
        public override void Greet()
        {
            WriteLine($"Hola, soy {Name} y soy profesor");
        }

        public void MySubject()
        {
            WriteLine($"Enseño {Subject} en Hogwarts.");
        }

    }

}