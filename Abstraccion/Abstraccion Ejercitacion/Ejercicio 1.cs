using System;

abstract class Vehiculo
{
    public abstract string Mover();

    public abstract string Detener();
}

class Auto : Vehiculo
{
    public override string Mover()
    {
        return "El Auto está en movimiento.";
    }

    public override string Detener()
    {
        return "El Auto se ha detenido.";
    }
}

class Bicicleta : Vehiculo
{
    public override string Mover()
    {
        return "La bicicleta está en movimiento.";
    }

    public override string Detener()
    {
        return "La bicicleta se ha detenido.";
    }
}

class Program
{
    static void Main()
    {
        Vehiculo Auto = new Auto();
        Vehiculo bici = new Bicicleta();

        Console.WriteLine(Auto.Mover());
        Console.WriteLine(Auto.Detener());

        Console.WriteLine(bici.Mover());
        Console.WriteLine(bici.Detener());
    }
}