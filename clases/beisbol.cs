public class Beisbol : Deportes
{
    public string entradaExtra;

    public Beisbol(string nombre, int jugadores, string entradaExtra)
        : base(nombre, jugadores)
    {
        this.entradaExtra = entradaExtra ?? throw new ArgumentNullException(nameof(entradaExtra));
    }

    public override string Descripcion()
    {
        return $"El {nombre} es un deporte de equipo con {jugadores} jugadores, donde en caso de empate se puede jugar una entrada extra, conocida como {entradaExtra}.";
    }
}
