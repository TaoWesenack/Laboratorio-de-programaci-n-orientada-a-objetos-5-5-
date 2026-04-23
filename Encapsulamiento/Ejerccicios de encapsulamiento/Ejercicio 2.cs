using System;

public class Persona 
{
    private string nombre;
    private string sexo;
    private int edad;

    public string Nombre{get;set;}

    public string Sexo{get;set;}

    public int Edad
    {
        get { return edad; }
        set
        {
            if (value >= 0)
                edad = value;
        }
    }

    // Constructor
    public Persona(string nombre, int edad, string sexo)
    {
        Nombre = nombre;
        Edad = edad;
        Sexo = sexo;
    }

    //Mostrar información
    public void MostrarInformacion()
    {
        Console.WriteLine($"El nombre de la persona es {Nombre}");
        Console.WriteLine($"La edad de la persona es {Edad}");
        Console.WriteLine($"El sexo de la persona es {Sexo}");
    }

    //Cambiar edad
    public void CambiarEdad(int nuevaEdad)
    {
        Edad = nuevaEdad;
    }
}

public class Programa
{
    static void Main()
    {
        Console.WriteLine("Ingresa el nombre de la persona");
        string nombre = Console.ReadLine() ?? "";

        Console.WriteLine("Ingresa la edad de la persona");
        int edad = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresa el sexo de la persona");
        string sexo = Console.ReadLine() ?? "";

        Persona persona1 = new Persona(nombre, edad, sexo);

        Console.WriteLine("\nInformación de la persona");
        persona1.MostrarInformacion();

        Console.WriteLine("\nIngresa la nueva edad de la persona");
        int nuevaEdad = int.Parse(Console.ReadLine());
        persona1.CambiarEdad(nuevaEdad);

        Console.WriteLine("\nInformación actualizada de la persona");
        persona1.MostrarInformacion();
    }
}