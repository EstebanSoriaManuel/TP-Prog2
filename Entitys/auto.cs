public class Auto : Vehiculo
{
    public Auto(string marca, string modelo, string patente) : base(marca, modelo, patente)
    {}

    public override int Acelerar(int velocidad)
    {
        Console.WriteLine("El auto está acelerando...");
        Console.WriteLine("La velocidad ahora es " + (velocidad + 25) + " km/h");
        return velocidad + 25;
    }
    public override int Frenar(int velocidad)
    {
        Console.WriteLine("El auto está frenando...");
        Console.WriteLine("La velocidad ahora es " + (velocidad - 15) + " km/h");
        return velocidad - 15;
    }
}