public class Moto : Vehiculo
{
    public Moto(string marca, string modelo, string patente) : base(marca, modelo, patente)
    {}
    public override int Acelerar(int velocidad)
    {
        Console.WriteLine("La moto está acelerando...");
        Console.WriteLine("La velocidad ahora es " + (velocidad + 30) + " km/h");
        return velocidad + 30;
    }
    public override int Frenar(int velocidad)
    {
        Console.WriteLine("La moto está frenando...");
        Console.WriteLine("La velocidad ahora es " + (velocidad - 30) + " km/h");
        return velocidad - 30;
    }
}