using System;

class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.Write("Ingrese el nombre del deporte: (Fútbol/Baloncesto/Béisbol)");
            string nombre = Console.ReadLine()?.Trim();

            Console.Write("Ingrese el número de jugadores: ");
            int jugadores;  
            while (!int.TryParse(Console.ReadLine(), out jugadores) || jugadores <= 0)
            {
                Console.WriteLine("Ingrese un número de jugadores válido.");
            }

            Deportes deporte;

            switch (nombre.ToLowerInvariant())
            {
                case "fútbol":
                    Console.Write("Ingrese la posición del arquero: ");
                    string posicionPortero = Console.ReadLine()?.Trim();
                    deporte = new Futbol(nombre, jugadores, posicionPortero);
                    break;

                case "baloncesto":
                    Console.Write("Ingrese la altura del aro: ");
                    double alturaAro;
                    while (!double.TryParse(Console.ReadLine(), out alturaAro) || alturaAro <= 0)
                    {
                        Console.WriteLine("Ingrese una altura de aro válida.");
                    }
                    deporte = new Baloncesto(nombre, jugadores, alturaAro);
                    break;

                case "béisbol":
                    Console.Write("Ingrese la descripción de la entrada extra: ");
                    double entradaExtra;
                    while (!double.TryParse(Console.ReadLine(), out entradaExtra))
                    {
                        Console.WriteLine("Ingrese una descripción válida para la entrada extra.");
                    }
                    deporte = new Beisbol(nombre, jugadores, entradaExtra);
                    break;

                default:
                    Console.WriteLine("El deporte ingresado no es válido.");
                    continue;
            }

            Console.WriteLine(deporte.Descripcion());
            Console.Write("Entre cualquier tecla para continuar...");
            Console.ReadKey(true);
        }
    }
}

