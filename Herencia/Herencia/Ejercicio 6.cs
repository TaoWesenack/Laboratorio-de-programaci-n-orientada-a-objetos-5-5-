using System;

class Persona
{
    protected string nombre;
    protected int edad;

    public Persona(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
    }
}

class Estudiante : Persona
{
    public Estudiante(string nombre, int edad)
        : base(nombre, edad)
    {
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("Estudiante: " + nombre);
    }
}

class Profesor : Persona
{
    public Profesor(string nombre, int edad)
        : base(nombre, edad)
    {
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("Profesor: " + nombre);
    }
}