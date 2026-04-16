using System;

public class Auto
{
    private string marca;
    private string modelo;
    private int añosFabricacion;

    public Auto(string marca, string modelo, int añosFabricacion)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.añosFabricacion = añosFabricacion;
    }

    // Metodos para obtener
    public string getMarca()
    {
        return marca;
    }

    public string GetModelo()
    {
        return modelo;
    }

    public int GetañosFabricacion()
    {
        return añosFabricacion;
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

    public void SetañosFabricacion(int añosFabricacion)
    {
        if (añosFabricacion > 0)
        {
            this.añosFabricacion = añosFabricacion;
        }
    }
}