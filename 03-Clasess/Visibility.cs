partial class Program
{
    static void Visibility()
    {
        //Crear una instancia de la clase Jedi
        Jedi jedi = new Jedi();
        //Acceder al campo publico
        jedi.PowerLevel = 5000;
        //Acceder al campo protegido a traves de una clase derivada
        jedi.LightsaberColor = "Azul";
        //Acceder al metodo publico
        // jedi.UseForce();

        // WriteLine(jedi.PublicField);
        // WriteLine(jedi.PrivateField);
        // WriteLine(jedi.ProtectField);

        // jedi.RevealSecret();

        Sith sith = new Sith();
        sith.PowerLevel = 7000;
        sith.LightsaberColor = "Red";
        sith.UseForce();
        // sith.ShowProtected();

    }
}

interface IForceUser
{
    int PowerLevel { get; set; }
    string? LightsaberColor { get; set; }

    void UseForce();
}

class Jedi : IForceUser
{
    //Todos van a tener acceso desde cualquier parte del programa
    public string PublicField = "Soy un Jedi y mi poder es conocido";

    //Solamente van a tener acceso los que estan dentro de la clase
    private string PrivateField = "Mis pensamientos mas profundos son privados";

    //Es accesibole dentro de esta clase y en las clases derivadas.
    protected string ProtectField = "El lado oscuro no debe conocer mis secretos";
    //Solo es accesible dentro del mismo ensamblado
    public int PowerLevel { get; set; }
    public string? LightsaberColor { get; set; }

    public void UseForce()
    {
        WriteLine($"Soy un Jedi con un sable de luz {LightsaberColor} y un nivel de poder de: {PowerLevel} ");
    }

    private void Meditate()
    {
        WriteLine("Estoy en profunda meditación con la fuerza");
    }

    protected void Train()
    {
        WriteLine("Estoy entrenando para convertirme en el mejor Jedi");
    }

    public void RevealSecret()
    {
        WriteLine(ProtectField);
        WriteLine(PrivateField);
        Meditate();
    }

}

// Se puede tener herencia con interfaces
// La clase Sith hereda de Jedi que es otra clase y de IForceUser que es una interfaz
// Solo se puede heredar de una clase, pero se pueden implementar multiples interfaces
// Una interfaz no contiene implementación de la solución, solo la firma del contrato
// Una clase puede implementar multiples interfaces
class Sith : Jedi, IForceUser
{
    public new void UseForce()
    {
        WriteLine($"Soy un sith con un sable de luz {LightsaberColor} y un nivel de poder de: {PowerLevel} ");
    }
    public void ShowProtected()
    {
        WriteLine(ProtectField);
        Train();
    }
}

