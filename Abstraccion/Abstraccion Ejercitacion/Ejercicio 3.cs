/******************************************************************************

Crea una clase abstracta Figura con un método abstracto calcular_area(). 
Luego, implementa dos clases concretas, Circulo y Rectangulo, que calculen el 
área según su propia lógica.

*******************************************************************************/

using System;

abstract class Figura
{
    public abstract double calcular_area();
}

class Circulo : Figura
{
    double radio;

    public Circulo(double r)
    {
        radio = r;
    }

    public override double calcular_area()
    {
        return Math.PI * radio * radio;
    }
}

class Rectangulo : Figura
{
    double baseRect;
    double altura;

    public Rectangulo(double b, double h)
    {
        baseRect = b;
        altura = h;
    }

    public override double calcular_area()
    {
        return baseRect * altura;
    }
}

class Program
{
    static void Main()
    {
        Figura circulo = new Circulo(5);
        Figura rectangulo = new Rectangulo(6, 7); //six seven

        Console.WriteLine(circulo.calcular_area());
        Console.WriteLine(rectangulo.calcular_area());
    }
}