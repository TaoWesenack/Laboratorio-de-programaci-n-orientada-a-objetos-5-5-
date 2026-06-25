using System;

class Figura
{
    protected string nombre;
    protected string color;

    public Figura(string nombre, string color)
    {
        this.nombre = nombre;
        this.color = color;
    }

    public virtual void ImprimirDetalles()
    {
        Console.WriteLine("Figura: " + nombre);
        Console.WriteLine("Color: " + color);
    }
}

class Circulo : Figura
{
    private double radio;

    public Circulo(string color, double radio) : base("Círculo", color)
    {
        this.radio = radio;
    }

    public double CalcularArea()
    {
        return Math.PI * Math.Pow(radio, 2);
    }

    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }

    public override void ImprimirDetalles()
    {
        base.ImprimirDetalles();

        Console.WriteLine("Radio: " + radio);
        Console.WriteLine("Área: " + CalcularArea().ToString("F2"));
        Console.WriteLine("Perímetro: " + CalcularPerimetro().ToString("F2"));
    }
}

class Rectangulo : Figura
{
    private double baseRect;
    private double altura;

    public Rectangulo(string color, double baseRect, double altura)
        : base("Rectángulo", color)
    {
        this.baseRect = baseRect;
        this.altura = altura;
    }

    public double CalcularArea()
    {
        return baseRect * altura;
    }

    public double CalcularPerimetro()
    {
        return 2 * (baseRect + altura);
    }

    public override void ImprimirDetalles()
    {
        base.ImprimirDetalles();

        Console.WriteLine("Base: " + baseRect);
        Console.WriteLine("Altura: " + altura);
        Console.WriteLine("Área: " + CalcularArea().ToString("F2"));
        Console.WriteLine("Perímetro: " + CalcularPerimetro().ToString("F2"));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circulo c = new Circulo("Rojo", 5);
        c.ImprimirDetalles();

        Console.WriteLine();

        Rectangulo r = new Rectangulo("Azul", 4, 7);
        r.ImprimirDetalles();
    }
}