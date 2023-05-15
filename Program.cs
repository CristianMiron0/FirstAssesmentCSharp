using static System.Console;

class Program
{
    public static void Main()
    {
        while (true)
        {
            Clear();
            Write("Ingrese el nombre del deporte: (Fútbol/Baloncesto/Béisbol)");
            string? nombre = ReadLine()?.Trim();

            Write("Ingrese el número de jugadores: ");
            int jugadores;  
            while (!int.TryParse(ReadLine(), out jugadores) || jugadores <= 0)
            {
                WriteLine("Ingrese un número de jugadores válido.");
            }

            Deportes deporte;

            switch (nombre!.ToLower())
            {
                case "fútbol":
                    Write("Ingrese la posición del arquero: ");
                    string? posicionPortero = ReadLine()?.Trim();
                    deporte = new Futbol(nombre, jugadores, posicionPortero!);
                    break;

                case "baloncesto":
                    Write("Ingrese la altura del aro: ");
                    double alturaAro;
                    while (!double.TryParse(ReadLine(), out alturaAro) || alturaAro <= 0)
                    {
                        WriteLine("Ingrese una altura de aro válida.");
                    }
                    deporte = new Baloncesto(nombre, jugadores, alturaAro);
                    break;

                case "béisbol":
                    Write("Ingrese la descripción de la entrada extra: ");
                    string? entradaExtra = ReadLine()?.Trim();
                    deporte = new Beisbol(nombre, jugadores, entradaExtra!);
                    break;

                default:
                    WriteLine("El deporte ingresado no es válido.");
                    continue;
            }

            WriteLine(deporte.Descripcion());
            Write("Entre cualquier tecla para continuar...");
            ReadKey(true);
        }
    }
}

