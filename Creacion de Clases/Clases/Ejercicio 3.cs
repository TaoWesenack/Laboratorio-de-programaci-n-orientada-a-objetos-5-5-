using System;

public class Producto
{
    // Campos privados
    private string nombre;
    private double precio;
    private int stock;

    // Constructor
    public Producto(string nombre, double precio, int stock)
    {
        this.nombre = nombre;
        this.precio = precio;
        this.stock = stock;
    }

    // Get
    public string GetNombre()
    {
        return nombre;
    }

    public double GetPrecio()
    {
        return precio;
    }

    public int GetStock()
    {
        return stock;
    }

    // Set
    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public void SetPrecio(double precio)
    {
        if (precio >= 0)
        {
            this.precio = precio;
        }
    }

    public void SetStock(int stock)
    {
        if (stock >= 0)
        {
            this.stock = stock;
        }
    }

    // Métodos para modificar el stock
    public void AumentarStock(int cantidad)
    {
        if (cantidad > 0)
        {
            stock += cantidad;
        }
    }

    public void DisminuirStock(int cantidad)
    {
        if (cantidad > 0 && cantidad <= stock)
        {
            stock -= cantidad;
        }
    }
}