using System;

public class Coche
{
    // Campos privados
    private string marca;
    private string modelo;
    private int anioFabricacion;

    // Constructor
    public Coche(string marca, string modelo, int anioFabricacion)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.anioFabricacion = anioFabricacion;
    }

    // Get
    public string GetMarca()
    {
        return marca;
    }

    public string GetModelo()
    {
        return modelo;
    }

    public int GetAnioFabricacion()
    {
        return anioFabricacion;
    }

    // Set
    public void SetMarca(string marca)
    {
        this.marca = marca;
    }

    public void SetModelo(string modelo)
    {
        this.modelo = modelo;
    }

    public void SetAnioFabricacion(int anioFabricacion)
    {
        if (anioFabricacion > 0)
        {
            this.anioFabricacion = anioFabricacion;
        }
    }

    // Método para calcular los años desde su fabricación
    public int ObtenerAntiguedad()
    {
        int anioActual = DateTime.Now.Year;
        return anioActual - anioFabricacion;
    }
}