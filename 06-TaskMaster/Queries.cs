using BetterConsoleTables;
namespace TaskMaster
{
  public class Queries(List<Task> _tasks)
  {
    private List<Task> Tasks = _tasks;

    public void ListTasks()
    {
      ForegroundColor = ConsoleColor.DarkBlue;
      WriteLine("------Lista de Tareas------");
      // foreach (var task in Tasks)
      // {
      //   WriteLine("\n{0,-8} {1,-35} {2,-15}", "Id", "Descripción", "Completado");
      //   WriteLine(new string('-', 58));
      //   WriteLine("\n{0,-8} {1,-35} {2,-15}", task.Id, task.Description, task.Completed);
      // }

      Table table = new Table("Id", "Descripción", "Estado");
      foreach (var task in Tasks)
      {
        table.AddRow(task.Id, task.Description, task.Completed ? "Completada" : "");
      }

      table.Config = TableConfiguration.Unicode();

      Write(table.ToString());
      ReadKey();
    }

    public List<Task> AddTask()
    {
      try
      {
        ResetColor();
        Clear();
        WriteLine("Ingrese la descripción de la nueva tarea:");
        var description = ReadLine();
        Task newTask = new Task(Utils.GenerateId(), description!);
        Tasks.Add(newTask);
        ForegroundColor = ConsoleColor.Green;
        WriteLine("¡Tarea agregada con éxito!");
        ResetColor();
        return Tasks;
      }
      catch (Exception ex)
      {
        ForegroundColor = ConsoleColor.Red;
        WriteLine($"Ocurrió un error al agregar la tarea: {ex.Message}");
        return Tasks;
      }

    }

    public List<Task> MarkAsCompleted()
    {
      try
      {
        ResetColor();
        Clear();
        WriteLine("Marcar tarea como completada:");
        Write("Ingrese el ID de la tarea a marcar como completada: ");
        var id = ReadLine();
        Task task = Tasks.Find(t => t.Id == id)!;
        //Valida que la tarea exista
        if (task == null)
        {
          ForegroundColor = ConsoleColor.Red;
          WriteLine("No se encontró una tarea con ese ID.");
          ResetColor();
          return Tasks;

        }
        //Marca la tarea como completada
        task.Completed = true;
        //Hora de modificación
        task.ModifiedAt = DateTime.Now;
        ForegroundColor = ConsoleColor.Green;
        WriteLine("¡Tarea marcada como completada con éxito!");
        ResetColor();
        return Tasks;
      }
      catch (Exception ex)
      {
        ForegroundColor = ConsoleColor.Red;
        WriteLine($"Ocurrió un error al agregar la tarea: {ex.Message}");
        return Tasks;
      }

    }
    public List<Task> EditTask()
    {
      try
      {
        ResetColor();
        Clear();
        WriteLine("------Editar tarea------");
        Write("Ingrese el ID de la tarea a editar: ");
        var id = ReadLine();
        Task task = Tasks.Find(t => t.Id == id)!;
        //Valida que la tarea exista
        if (task == null)
        {
          ForegroundColor = ConsoleColor.Red;
          WriteLine("No se encontró una tarea con el ID proporcionado.");
          ResetColor();
          return Tasks;

        }
        Write("Ingrese la nueva descripción de la tarea: ");

        var description = ReadLine();
        task.Description = description;
        //Hora de modificación
        task.ModifiedAt = DateTime.Now;
        ForegroundColor = ConsoleColor.Green;
        WriteLine("¡Tarea modificada con éxito!");
        ResetColor();
        return Tasks;
      }
      catch (Exception ex)
      {
        ForegroundColor = ConsoleColor.Red;
        WriteLine($"Ocurrió un error al agregar la tarea: {ex.Message}");
        return Tasks;
      }

    }

    public List<Task> RemoveTask()
    {
      try
      {
        ResetColor();
        Clear();
        WriteLine("------Eliminar Tarea------");
        Write("Ingrese el ID de la tarea a Eliminar: ");
        var id = ReadLine();
        Task task = Tasks.Find(t => t.Id == id)!;
        //Valida que la tarea exista
        if (task == null)
        {
          ForegroundColor = ConsoleColor.Red;
          WriteLine("No se encontró una tarea con el ID proporcionado.");
          ResetColor();
          return Tasks;

        }
        Tasks.Remove(task);
        //Hora de Eliminación
        task.ModifiedAt = DateTime.Now;
        ForegroundColor = ConsoleColor.Red;
        WriteLine("¡Tarea eliminada con éxito!");
        ResetColor();
        return Tasks;
      }
      catch (Exception ex)
      {
        ForegroundColor = ConsoleColor.Red;
        WriteLine($"Ocurrió un error al Eliminar la tarea: {ex.Message}");
        return Tasks;
      }

    }

  }
}