using System;

class Producto
{
    public string Nombre { get; set; }

    private int precio;
    public int Precio
    {
        get { return precio; }
        set
        {
            if (value > 0)
                precio = value;
        }
    }

    private int stock;
    public int Stock
    {
        get { return stock; }
        private set
        {
            if (value >= 0)
                stock = value;
        }
    }

    // Constructor
    public Producto(string nombre, int precio, int stock)
    {
        Nombre = nombre;
        Precio = precio;
        Stock = stock;
    }

    // Mostrar info
    public void MostrarInfo()
    {
        Console.WriteLine($"El nombre del producto es {Nombre}");
        Console.WriteLine($"El precio del producto es {Precio}");
        Console.WriteLine($"El stock del producto es {Stock}");
    }

    // Aumentar stock
    public void AumentarProducto(int cantidad)
    {
        if (cantidad > 0)
        {
            Stock += cantidad;
        }
    }

    // Disminuir stock
    public void DisminuirProducto(int cantidad)
    {
        if (cantidad > 0 && Stock >= cantidad)
        {
            Stock -= cantidad;
        }
        else
        {
            Console.WriteLine("No hay suficiente stock o cantidad inválida.");
        }
    }
}

public class Programa
{
    static void Main()
    {
        Producto producto1 = new Producto("lol", 4534, 67);

        producto1.MostrarInfo();

        producto1.AumentarProducto(1);
        producto1.MostrarInfo();

        producto1.DisminuirProducto(10);
        producto1.MostrarInfo();
    }
}