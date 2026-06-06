public abstract class Vehiculo
{
    private string marca;
    private string modelo;
    private int patente;

    public string Marca {get {return this.marca ;} set{this.marca = value;}}
    public string Modelo {get {return this.modelo ;} set{this.modelo = value;}}
    public int Patente {get {return this.patente ;} set{this.patente = value;}}

    public Vehiculo(string marca, string modelo, int patente)
    {
        Marca = marca;
        Modelo = modelo;
        Patente = patente;
    }


    public static void MostrarInformacion(Vehiculo vehiculo)
    {
        Console.WriteLine("Marca: " + vehiculo.Marca);
        Console.WriteLine("Modelo: " + vehiculo.Modelo);
        Console.WriteLine("Patente: " + vehiculo.Patente);
    }

    public abstract int Acelerar(int velocidad);

    public abstract int Frenar(int velocidad);

}