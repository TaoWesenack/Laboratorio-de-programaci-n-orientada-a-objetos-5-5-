using System;

class Instrumento
{
    protected string nombre;
    protected string material;

    public Instrumento(string nombre, string material)
    {
        this.nombre = nombre;
        this.material = material;
    }

    public virtual void Tocar()
    {
        Console.WriteLine("El instrumento produce sonido.");
    }
}

class Guitarra : Instrumento
{
    public Guitarra(string nombre, string material)
        : base(nombre, material)
    {
    }

    public override void Tocar()
    {
        Console.WriteLine("La guitarra toca una nota.");
    }
}

class Piano : Instrumento
{
    public Piano(string nombre, string material)
        : base(nombre, material)
    {
    }

    public override void Tocar()
    {
        Console.WriteLine("El piano toca una nota.");
    }
}