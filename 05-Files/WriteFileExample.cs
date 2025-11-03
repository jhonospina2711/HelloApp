partial class Program
{
    static void WriteFileExample()
    {
        var filePath = "./05-Files/EjemploEscritura.txt";
        var content = "Esto se añadira al final";
        //se adiciona el append para que no sobrescriba el archivo
        var streamWriter = new StreamWriter(filePath, append: true);
        streamWriter.WriteLine(content);
        streamWriter.WriteLine("La hora actual es: " + DateTime.Now.ToString("HH:mm:ss"));
        //Cierra el archivo y libera los recursos
        streamWriter.Dispose();
        WriteLine($"Se ha escrito en el archivo: {filePath}");
        
    }
}