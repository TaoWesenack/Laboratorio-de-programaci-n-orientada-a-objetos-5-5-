using System;
using System.Collections.Generic;

class Animal
{
    public virtual void hacerSonido()
    {
        Console.WriteLine("El animal hace un sonido.");
    }
}

class Perro : Animal
{
    public override void hacerSonido()
    {
        Console.WriteLine("Guau");
    }
}

class Gato : Animal
{
    public override void hacerSonido()
    {
        Console.WriteLine("Miau");
    }
}

class Program
{
    static void Main()
    {
        List<Animal> animales = new List<Animal>()
        {
            new Perro(),
            new Gato(),
            new Perro()
        };

        foreach (Animal animal in animales)
        {
            animal.hacerSonido();
        }
    }
}