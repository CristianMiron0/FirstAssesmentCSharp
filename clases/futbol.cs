public class Futbol : Deportes
{
    public string posicionPortero;

    public Futbol(string nombre, int jugadores, string posicionPortero)
        : base(nombre, jugadores)
    {
        this.posicionPortero = posicionPortero ?? throw new ArgumentNullException(nameof(posicionPortero));
    }

    public override string Descripcion()
    {
        return $"El {nombre} es un deporte de equipo con {jugadores} jugadores, donde el arquero se coloca en la posición {posicionPortero}.";
    }
}