using System;

class Producto
{
    protected string nombre;
    protected double precio;
    protected string fechaVencimiento;

    public Producto(string nombre, double precio, string fechaVencimiento)
    {
        this.nombre = nombre;
        this.precio = precio;
        this.fechaVencimiento = fechaVencimiento;
    }

    public virtual void AplicarDescuento()
    {
        Console.WriteLine("Producto: " + nombre);
        Console.WriteLine("Precio: $" + precio);
    }
}

class ProductoAlimenticio : Producto
{
    public ProductoAlimenticio(string nombre, double precio, string fecha)
        : base(nombre, precio, fecha)
    {
    }

    public override void AplicarDescuento()
    {
        precio -= precio * 0.20;

        Console.WriteLine("Producto: " + nombre);
        Console.WriteLine("Precio con descuento: $" + precio);
    }
}

class ProductoElectronico : Producto
{
    public ProductoElectronico(string nombre, double precio, string fecha)
        : base(nombre, precio, fecha)
    {
    }

    public override void AplicarDescuento()
    {
        precio -= precio * 0.10;

        Console.WriteLine("Producto: " + nombre);
        Console.WriteLine("Precio con descuento: $" + precio);
    }
}