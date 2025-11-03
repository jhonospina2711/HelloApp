partial class Program
{
    static void DirectoryExample()
    {
        var directoryPath = "./05-Files/";


        if (!Directory.Exists($"{directoryPath}/DirectorioEjemplo/OtherDirectory"))
        {
            Directory.CreateDirectory($"{directoryPath}/DirectorioEjemplo/OtherDirectory");
            WriteLine("El directorio fue creado");
        }
        else
        {
            WriteLine("El directorio ya existe");
        }
       
        //Eliminar un directorio.
        if (Directory.Exists($"{directoryPath}/DirectorioEjemplo/OtherDirectory"))
        {
            Directory.Delete($"{directoryPath}/DirectorioEjemplo/OtherDirectory");
            WriteLine("El directorio fue eliminado");
        }
        else
        {
            WriteLine("El directoro no existe");
        }
        
        Directory.Delete($"{directoryPath}/DirectorioEjemplo", recursive: true);
    }
}