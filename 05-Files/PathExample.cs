partial class Program
{
    static void PathExample()
    {
        var filePath = "./05-Files/Ejemplo.txt";
        
        //Obtener el nombre del archivo
        var fileName = Path.GetFileName(filePath);
        WriteLine($"Nombre del archivo: {fileName}");

        //Obtener la extensión del archivo
        var fileExtension = Path.GetExtension(filePath);
        WriteLine($"Extensión del archivo: {fileExtension}");

        //Obtener el directorio del archivo
        var directoryName = Path.GetDirectoryName(filePath);
        WriteLine($"Directorio del archivo: {directoryName}");

        //Combinar rutas
        var combinedPath = Path.Combine("C:", "Users", "Documents", "Ejemplo.txt");
        WriteLine($"Ruta combinada: {combinedPath}");

        //Obtener la ruta completa del archivo
        var fullFilePath = Path.GetFullPath(filePath);
        WriteLine($"Ruta completa del archivo: {fullFilePath}");
    }
}