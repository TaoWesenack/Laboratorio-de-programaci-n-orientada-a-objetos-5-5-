using System;
using System.Collections.Generic;

class Vehiculo
{
    public virtual void mover()
    {
        Console.WriteLine("El vehículo se mueve.");
    }
}

class Coche : Vehiculo
{
    public override void mover()
    {
        Console.WriteLine("El coche avanza por la carretera.");
    }
}

class Bicicleta : Vehiculo
{
    public override void mover()
    {
        Console.WriteLine("La bicicleta avanza pedaleando.");
    }
}

class Program
{
    static void Main()
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>()
        {
            new Coche(),
            new Bicicleta(),
            new Coche()
        };

        foreach (Vehiculo vehiculo in vehiculos)
        {
            vehiculo.mover();
        }
    }
}