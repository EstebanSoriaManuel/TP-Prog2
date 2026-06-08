class Program
{
    static List<Auto> autos = new List<Auto>();
    static List<Moto> motos = new List<Moto>();

    static void Main()
    {

        int opcion = 0;

        do
        {
            Console.WriteLine("Sistema de gestion de vehiculos");
            Console.WriteLine(@"¿Que accion desea realizar?
            1. Registrar vehiculo
            2. Mostrar vehiculos registrados
            0. Salir");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    RegistrarVehiculo();
                    break;
                case 2:
                    MostrarVehiculos();
                    break;
                case 0:
                    Console.WriteLine("Saliendo del sistema...");
                    break;
                default:
                    Console.WriteLine("Opcion no valida. Por favor, seleccione una opcion valida.");
                    break;
            }

        }while (opcion != 0);
        
    }



    static void RegistrarVehiculo()
    {
        Console.WriteLine("¿Que tipo de vehiculo desea registrar? (Auto/Moto)");
        string tipo = Console.ReadLine();

        Console.WriteLine("Ingrese la marca del vehiculo:");
        string marca = Console.ReadLine();

        Console.WriteLine("Ingrese el modelo del vehiculo:");
        string modelo = Console.ReadLine();

        Console.WriteLine("Ingrese la patente del vehiculo:");
        string patente = Console.ReadLine();

        if (tipo.ToLower() == "auto")
        {
            Auto auto = new Auto(marca, modelo, patente);
            autos.Add(auto);
            Console.WriteLine("Auto registrado exitosamente.");
        }
        else if (tipo.ToLower() == "moto")
        {
            Moto moto = new Moto(marca, modelo, patente);
            motos.Add(moto);
            Console.WriteLine("Moto registrada exitosamente.");
        }
        else
        {
            Console.WriteLine("Tipo de vehiculo no valido. Por favor, ingrese 'Auto' o 'Moto'.");
        }
    }


    static void MostrarVehiculos()
    {
        Console.WriteLine("Vehiculos registrados:");
        foreach (Auto auto in autos)
        {
            Console.WriteLine(@"
            ----------------------
            ");

            auto.MostrarInformacion(auto);

            Console.WriteLine("Acelerando el auto...");
            auto.Acelerar(0);

            Console.WriteLine("Frenando el auto...");
            auto.Frenar(25);
        }
        foreach (Moto moto in motos)
        {
            Console.WriteLine(@"
            ----------------------
            ");
            
            moto.MostrarInformacion(moto);

            Console.WriteLine("Acelerando la moto...");
            moto.Acelerar(0);

            Console.WriteLine("Frenando la moto...");
            moto.Frenar(40);
        }
    }
}

