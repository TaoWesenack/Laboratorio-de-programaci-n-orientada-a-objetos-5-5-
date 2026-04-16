using System;

public class Estudiante
{
    // Campos privados
    private string nombre;
    private int edad;
    private string carrera;

    // Constructor
    public Estudiante(string nombre, int edad, string carrera)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.carrera = carrera;
    }

    // Get
    public string GetNombre()
    {
        return nombre;
    }

    public int GetEdad()
    {
        return edad;
    }

    public string GetCarrera()
    {
        return carrera;
    }

    // Set
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

    public void SetCarrera(string carrera)
    {
        this.carrera = carrera;
    }

    // Método para calcular la nota media
    public double CalcularNotaMedia(double[] notas)
    {
        if (notas == null || notas.Length == 0)
        {
            return 0;
        }

        double suma = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];
        }

        return suma / notas.Length;
    }
}