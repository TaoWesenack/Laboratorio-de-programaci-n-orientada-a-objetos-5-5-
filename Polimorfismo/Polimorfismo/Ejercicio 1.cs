using System;
using System.Collections.Generic;

class Figura
{
    public virtual double Area()
    {
        return 0;
    }
}

class Circulo : Figura
{
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public override double Area()
    {
        return Math.PI * Math.Pow(radio, 2);
    }
}

class Rectangulo : Figura
{
    private double ancho;
    private double alto;

    public Rectangulo(double ancho, double alto)
    {
        this.ancho = ancho;
        this.alto = alto;
    }

    public override double Area()
    {
        return ancho * alto;
    }
}

class Program
{
    static void Main()
    {
        List<Figura> figuras = new List<Figura>()
        {
            new Circulo(5),
            new Rectangulo(4, 6),
            new Circulo(3),
            new Rectangulo(10, 2)
        };

        foreach (Figura figura in figuras)
        {
            Console.WriteLine("Área: " + figura.Area().ToString("F2"));
        }
    }
}