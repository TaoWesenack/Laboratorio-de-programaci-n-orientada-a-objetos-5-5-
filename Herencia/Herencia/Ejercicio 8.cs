using System;

class Transporte
{
    protected int capacidad;
    protected int velocidadMaxima;

    public Transporte(int capacidad, int velocidadMaxima)
    {
        this.capacidad = capacidad;
        this.velocidadMaxima = velocidadMaxima;
    }

    public virtual void CalcularTiempo(double distancia)
    {
        Console.WriteLine("Tiempo de viaje.");
    }
}

class Avion : Transporte
{
    public Avion(int capacidad, int velocidadMaxima)
        : base(capacidad, velocidadMaxima)
    {
    }

    public override void CalcularTiempo(double distancia)
    {
        Console.WriteLine("Tiempo: " + distancia / velocidadMaxima + " horas");
    }
}

class Barco : Transporte
{
    public Barco(int capacidad, int velocidadMaxima)
        : base(capacidad, velocidadMaxima)
    {
    }

    public override void CalcularTiempo(double distancia)
    {
        Console.WriteLine("Tiempo: " + distancia / velocidadMaxima + " horas");
    }
}