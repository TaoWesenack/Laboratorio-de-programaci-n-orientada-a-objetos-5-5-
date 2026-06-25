using System;
using System.Collections.Generic;

class Empleado
{
    public virtual double calcularSalario()
    {
        return 0;
    }
}

class EmpleadoPorHora : Empleado
{
    private int horas;
    private double pagoHora;

    public EmpleadoPorHora(int horas, double pagoHora)
    {
        this.horas = horas;
        this.pagoHora = pagoHora;
    }

    public override double calcularSalario()
    {
        return horas * pagoHora;
    }
}

class EmpleadoFijo : Empleado
{
    private double salarioMensual;

    public EmpleadoFijo(double salarioMensual)
    {
        this.salarioMensual = salarioMensual;
    }

    public override double calcularSalario()
    {
        return salarioMensual;
    }
}

class Program
{
    static void Main()
    {
        List<Empleado> empleados = new List<Empleado>()
        {
            new EmpleadoPorHora(40, 10),
            new EmpleadoFijo(2000),
            new EmpleadoPorHora(30, 12)
        };

        double total = 0;

        foreach (Empleado empleado in empleados)
        {
            total += empleado.calcularSalario();
        }

        Console.WriteLine("Salario total: $" + total);
    }
}