public class Beisbol : Deportes
{
    public double entradaExtra;

    public Beisbol(string nombre, int jugadores, double entradaExtra)
        : base(nombre, jugadores)
    {
        this.entradaExtra = entradaExtra;
    }

    public override string Descripcion()
    {
        return $"El {nombre} es un deporte de equipo con {jugadores} jugadores, donde en caso de empate se puede jugar una entrada extra, conocida como {entradaExtra}.";
    }
}