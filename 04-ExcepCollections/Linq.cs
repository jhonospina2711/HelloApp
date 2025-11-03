partial class Program
{
    static void Linq()
    {
        List<int> numbers = [1, 2, 3, 4, 5, 6];
        List<int> evenNumbers = [];

        // Sin usar LINQ
        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
        }

        //Sintaxis de consulta
        var evenNumbersQuery = from num in numbers
                               where num % 2 == 0
                               select num;
        // Sintaxis de metodo
        var evenNumbersMethod = numbers.Where(n => n % 2 == 0);

        // foreach (var number in evenNumbersMethod)
        // {
        //     WriteLine(number);
        // }

        //Consultas simples //

        List<MarvelCharacter> characters = new List<MarvelCharacter>
        {
          new MarvelCharacter { Name = "Peter Parker", Alias = "Spider-Man", Team = "Avengers" },
          new MarvelCharacter { Name = "Tony Stark", Alias = "Iron Man", Team = "Avengers" },
          new MarvelCharacter { Name = "Steve Rogers", Alias = "Captain America", Team = "Avengers" },
          new MarvelCharacter { Name = "Natasha Romanoff", Alias = "Black Widow", Team = "Avengers" },
          new MarvelCharacter { Name = "T'Challa", Alias = "Black Panther", Team = "Wakanda" },
          new MarvelCharacter { Name = "Stephen Strange", Alias = "Doctor Strange", Team = "Defenders" }
         };

        //WriteLine("Personajes que pertenecen a los avengers:");
        // Consulta con sintaxis de consulta
        var avengersQuery = from c in characters
                            where c.Team == "Avengers"
                            select $"{c.Alias} {c.Name}";

        // Consulta con sintaxis de metodo
        var avangersMethod = characters.Where(c => c.Team == "Avengers");
        
        //Recorriendo los datos de la consulta tipo metodo
        foreach (var character in avangersMethod)
        {
            //WriteLine($"{character.Alias} {character.Name}");
        }

        // Consulta con sintaxs tipo consulta: devuelve los nombres de la lista characters en mayusculas
        var uppercaseNamesQuery = from c in characters
                                  select c.Name?.ToUpper();

        // Consulta con sintaxs tipo metodo: devuelve los nombres de la lista characters en mayusculas
        var uppercaseNamesMethod = characters.Select(c => c.Name?.ToUpper());
        
        
        //WriteLine("Nombres en mayusculas:");
        foreach (var name in uppercaseNamesMethod)
        {
            //WriteLine(name);
        }
        var sortedQuery = from c in characters
                          orderby c.Name 
                          select c.Name;

        var sortedMethod = characters.OrderByDescending(c => c.Name);
        // WriteLine("Ordenar los nombres de manera descendente:");
        // foreach (var character in sortedMethod)
        // {
        //     WriteLine(character.Name);
        // }

        var firstThreeQuery = (from c in characters select c).Take(3);
        var fristThreeMethod = characters.Take(3);
        WriteLine("Obteniendo los primeros 3 personajes:");
        foreach (var character in fristThreeMethod)
        {
            WriteLine(character.Name);
        }
    }


}

class MarvelCharacter
{
    public string? Name { get; set; }
    public string? Alias { get; set; }
    public string? Team { get; set; }
}

