using System;

public class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }

    private int añoPublicacion;
    public int AñoPublicacion
    {
        get { return añoPublicacion; }
        set
        {
            if (value >= 0)
                añoPublicacion = value;
        }
    }

    // Constructor
    public Libro(string titulo, string autor, int añoPublicacion)
    {
        Titulo = titulo;
        Autor = autor;
        AñoPublicacion = añoPublicacion;
    }

    // Método descripción
    public string Descripcion()
    {
        return $"Título: {Titulo}, Autor: {Autor}, Año de Publicación: {AñoPublicacion}";
    }

    // Método clásico
    public bool EsClasico()
    {
        int añoActual = DateTime.Now.Year;
        return (añoActual - AñoPublicacion) > 50;
    }
}

public class Programa
{
    static void Main()
    {
        Libro libro1 = new Libro("Romeo y Julieta", "William Shakespeare", 1597);

        Console.WriteLine(libro1.Descripcion());

        if (libro1.EsClasico())
        {
            Console.WriteLine("El libro es un clásico.");
        }
        else
        {
            Console.WriteLine("El libro no es un clásico.");
        }
    }
}