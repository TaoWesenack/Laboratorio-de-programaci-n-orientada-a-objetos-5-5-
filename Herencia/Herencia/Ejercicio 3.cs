using System;

class Animal
{
    protected string raza;
    protected int años;
    protected string peso;

    public Animal(string raza, int años, string peso)
    {
        this.raza = raza;
        this.años = años;
        this.peso = peso;
    }

    public void MostrarDetalles()
    {
        Console.WriteLine("Raza: " + raza);
        Console.WriteLine("Edad: " + años + " años");
        Console.WriteLine("Peso: " + peso);
    }

    public virtual void EmitirSonido()
    {
        Console.WriteLine("El animal emite un sonido.");
    }
}

class Perro : Animal
{
    public Perro(string raza, int años, string peso)
        : base(raza, años, peso)
    {
    }

    public override void EmitirSonido()
    {
        Console.WriteLine("El perro ladra: Guau Guau!");
    }
}

class Gato : Animal
{
    public Gato(string raza, int años, string peso)
        : base(raza, años, peso)
    {
    }

    public override void EmitirSonido()
    {
        Console.WriteLine("El gato maúlla: Miau!");
    }
}

class Program
{
    static void Main()
    {
        Perro perro = new Perro("Labrador", 5, "40 kg");
        perro.MostrarDetalles();
        perro.EmitirSonido();

        Console.WriteLine();

        Gato gato = new Gato("Siamés", 3, "5 kg");
        gato.MostrarDetalles();
        gato.EmitirSonido();
    }
}