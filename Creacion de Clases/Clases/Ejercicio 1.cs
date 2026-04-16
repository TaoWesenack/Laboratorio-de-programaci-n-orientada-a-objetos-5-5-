using System;

public class Persona
{
    // Campos privados
    private string nombre;
    private int edad;
    private double altura;

    // Constructor
    public Persona(string nombre, int edad, double altura)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.altura = altura;
    }

    // Métodos Get
    public string GetNombre()
    {
        return nombre;
    }

    public int GetEdad()
    {
        return edad;
    }

    public double GetAltura()
    {
        return altura;
    }

    // Métodos Set
    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public void SetEdad(int edad)
    {
        if (edad >= 0)
        {
            this.edad = edad;
        }
    }

    public void SetAltura(double altura)
    {
        if (altura > 0)
        {
            this.altura = altura;
        }
    }
}