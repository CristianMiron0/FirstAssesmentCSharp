## Escenario de Deportes: Código 04

Usted ha sido contratado para trabajar como `CSharp developer` en la secretaría de deportes de su ciudad.

La actividad central es el control de los diferentes deportes.

Usted iniciará un proyecto que incluirá la elaboración de `site` en Internet para el control de los deportes en su localidad.

Las deportes que iniciarán son Fútbol, Baloncesto y el Béisbol, pero próximamente se añadirán mas deportes, a medida que se vayan incorporando nueva información a la secretaría.

Debe crear el proyecto de iniciación para comenzar a desarrollar en las siguientes jornadas toda la aplicación.

Hoy deberá entregar la validación de funcionalidad, con la jerarquía de clases, y con el funcionamiento de una aplicación de consola; incluyendo toda la información proporcionada en este documento. Y completarlas según las instrucciones recibidas.

```
Deportes: fútbol, baloncesto, béisbol.
```

``` CSharp
public abstract class Deportes
{
    public string nombre;
    public int jugadores;

    public Deportes(string nombre, int jugadores)
    {
        this.nombre = nombre;
        this.jugadores = jugadores;
    }

    public abstract string Descripcion();
}

public class Futbol : Deportes
{
    public string posicionPortero;

    public Futbol(string nombre, int jugadores, string posicionPortero)
        : base(nombre, jugadores)
    {
        this.posicionPortero = posicionPortero;
    }

    public override string Descripcion()
    {
        return $"El {nombre} es un deporte de equipo con {jugadores} jugadores, donde el arquero se coloca en la posición {posicionPortero}.";
    }
}

public class Baloncesto : Deportes
{
    public double altura_aro;

    public Baloncesto(string nombre, int jugadores, double altura_aro)
        : base(nombre, jugadores)
    {
        this.altura_aro = altura_aro;
    }

    public override string Descripcion()
    {
        return $"El {nombre} es un deporte de equipo con {jugadores} jugadores, donde el aro se encuentra a una altura de {altura_aro} metros.";
    }
}

public class Beisbol : Deportes
{
    public string entradaExtra;

    public Beisbol(string nombre, int jugadores, string entradaExtra)
        : base(nombre, jugadores)
    {
        this.entradaExtra = entradaExtra;
    }

    public override string Descripcion()
    {
        return $"El {nombre} es un deporte de equipo con {jugadores} jugadores, donde en caso de empate se puede jugar una entrada extra, conocida como {entradaExtra}.";
    }
}
```

####  Aplicación principal

```Csharp
        Clear();
Write("Ingrese el nombre del deporte: (Fúltbol/Baloncesto/Béisbol)");
string? nombre = ReadLine();

Write("Ingrese el número de jugadores:");
int jugadores = 0;
Int32.TryParse(ReadLine(), out jugadores);

Deportes? deporte = null;

switch (nombre!.ToLower())
{
    case "fútbol":
        Write("Ingrese la posición del arquero:");
        string? posicionPortero = ReadLine();
        deporte = new Futbol(nombre, jugadores, posicionPortero!);
        break;

    case "baloncesto":
        Write("Ingrese la altura del aro:");
        double altura_aro = Convert.ToDouble(ReadLine());
        deporte = new Baloncesto(nombre, jugadores, altura_aro);
        break;

    case "béisbol":
        Write("Ingrese la descripción de la entrada extra:");
        string? entradaExtra = ReadLine();
        deporte = new Beisbol(nombre, jugadores, entradaExtra!);
        break;

    default:
        Write("El deporte ingresado no es válido.");
        return;
}

if (deporte!=null)
    WriteLine(deporte.Descripcion());
Write("Entre cualquier tecla");
ReadKey();
```



