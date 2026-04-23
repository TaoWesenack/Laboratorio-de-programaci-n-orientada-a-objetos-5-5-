using System;

class Empleado
{
    public string Nombre { get; set; }
    public string Departamento { get; set; }

    private int salario;
    public int Salario
    {
        get { return salario; }
        set
        {
            if (value > 0)
                salario = value;
        }
    }

    // Constructor
    public Empleado(string nombre, int salario, string departamento)
    {
        Nombre = nombre;
        Salario = salario;
        Departamento = departamento;
    }

    // Método para aumentar salario
    public void AumentarSalario(double porcentaje)
    {
        if (porcentaje > 0)
        {
            Salario += (int)(Salario * porcentaje / 100);
        }
    }

    // Método para mostrar info
    public void MostrarInfo()
    {
        Console.WriteLine($"El nombre del empleado es {Nombre}");
        Console.WriteLine($"El salario del empleado es {Salario}");
        Console.WriteLine($"El departamento del empleado es {Departamento}");
    }
}

public class Programa
{
    static void Main()
    {
        Empleado empleado1 = new Empleado("Tao", 6700, "Tecnologia");

        empleado1.MostrarInfo();

        empleado1.AumentarSalario(10);
        Console.WriteLine("\nDespués del aumento:\n");

        empleado1.MostrarInfo();
    }
}