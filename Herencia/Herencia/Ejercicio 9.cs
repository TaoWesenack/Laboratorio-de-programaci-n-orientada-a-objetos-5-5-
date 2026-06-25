using System;

class Tienda
{
    protected string nombre;
    protected int ventas;

    public Tienda(string nombre, int ventas)
    {
        this.nombre = nombre;
        this.ventas = ventas;
    }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine("Tienda: " + nombre);
        Console.WriteLine("Ventas: " + ventas);
    }
}

class TiendaRopa : Tienda
{
    public TiendaRopa(string nombre, int ventas)
        : base(nombre, ventas)
    {
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("Tienda de ropa: " + nombre);
    }
}

class TiendaElectronica : Tienda
{
    public TiendaElectronica(string nombre, int ventas)
        : base(nombre, ventas)
    {
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("Tienda electrónica: " + nombre);
    }
}