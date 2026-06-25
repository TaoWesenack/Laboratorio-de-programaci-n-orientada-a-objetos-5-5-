using System;

class Empleado
{
    protected string nombre;
    protected int salario;
    protected string cargo;

    public Empleado(string nombre, int salario, string cargo)
    {
        this.nombre = nombre;
        this.salario = salario;
        this.cargo = cargo;
    }

    public virtual void calcularAumento()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Salario: " + salario);
        Console.WriteLine("Cargo: " + cargo);
    }
}

class Gerente : Empleado
{
    public Gerente(string nombre, int salario)
        : base(nombre, salario, "Gerente")
    {
    }

    public override void calcularAumento()
    {
        salario += 20000;

        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Nuevo salario: " + salario);
        Console.WriteLine("Cargo: " + cargo);
    }
}

class EmpleadoTemporal : Empleado
{
    public EmpleadoTemporal(string nombre, int salario)
        : base(nombre, salario, "Empleado temporal")
    {
    }

    public override void calcularAumento()
    {
        salario += 5000;

        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Nuevo salario: " + salario);
        Console.WriteLine("Cargo: " + cargo);
    }
}

class Program
{
    static void Main()
    {
        Gerente g = new Gerente("Tao", 5000);
        g.calcularAumento();

        Console.WriteLine();

        EmpleadoTemporal et = new EmpleadoTemporal("Agustin", 5000);
        et.calcularAumento();
    }
}