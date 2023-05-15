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