partial class Program
{

    static void LoopControlExamples()
    {
        //Break: Sale del ciclo
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                break;
            }
            //WriteLine(i);
        }

        //Continue: Salta a la siguiente iteración del ciclo
        for (int i = 0; i < 10; i++)
        {
            if (i == 5 || i == 7)
            {
                continue;
            }
            //WriteLine(i);
        }

        //Return: Sale del método
        for (int i = 0; i < 10; i++)
        {
            if (i == 3)
            {
                //return;
            }
            //WriteLine(i);
        }

        //Bucle infinito
        // while (true)
        // {
        //     WriteLine("Esto siempre se ejecutara");
        // }

        for (; ; )
        {
            WriteLine("Esto también siempre se ejecutara");
            break;
        }

    }

}