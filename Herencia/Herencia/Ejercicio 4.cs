using System;

class Vehiculo
{
    protected string marca;
    protected string modelo;
    protected int año;

    public Vehiculo(string marca, string modelo, int año)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.año = año;
    }

    public virtual void CalcularCombustible()
    {
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Año: " + año);
    }
}

class Automovil : Vehiculo
{
    public Automovil(string marca, string modelo, int año)
        : base(marca, modelo, año)
    {
    }

    public override void CalcularCombustible()
    {
        Console.WriteLine("El automóvil consume 8 litros cada 100 km.");
    }
}

class Motocicleta : Vehiculo
{
    public Motocicleta(string marca, string modelo, int año)
        : base(marca, modelo, año)
    {
    }

    public override void CalcularCombustible()
    {
        Console.WriteLine("La motocicleta consume 4 litros cada 100 km.");
    }
}

class Program
{
    static void Main()
    {
        Automovil auto = new Automovil("Ford", "Focus", 2020);
        auto.CalcularCombustible();

        Console.WriteLine();

        Motocicleta moto = new Motocicleta("Honda", "CBR", 2022);
        moto.CalcularCombustible();
    }
}