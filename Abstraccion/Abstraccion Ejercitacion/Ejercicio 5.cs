/******************************************************************************

Crea una clase abstracta Empleado con un método abstracto calcular_sueldo(). 
Luego, implementa dos clases concretas, EmpleadoPorHora y EmpleadoFijo, que 
calculen el sueldo de manera diferente.

*******************************************************************************/

using System;

abstract class Empleado
{
    public abstract int calcular_sueldo();
}

class EmpleadoPorHora : Empleado
{   
    int sueldo;
    int horas;
    int pagoPorHoras;
    
    public EmpleadoPorHora(int h, int ph)
    {
        horas = h;
        pagoPorHoras = ph;
    }
    
    public override int calcular_sueldo()
    {
        return sueldo = horas * pagoPorHoras;
    }
    
}

class EmpleadoFijo : Empleado
{
    int sueldo;
    
    public EmpleadoFijo(int s)
    {
        sueldo = s;
    }
    
     public override int calcular_sueldo()
    {
        return sueldo;
    }
    
}

class Program
{
    static void Main()
    {
        Empleado EmpleadoPorHora = new  EmpleadoPorHora(5, 1000);
        Empleado EmpleadoFijo = new EmpleadoFijo(8000);

        Console.WriteLine("El sueldo del empleado por hora es de: " + EmpleadoPorHora.calcular_sueldo());
        Console.WriteLine("El sueldo del empleado fijo es " + EmpleadoFijo.calcular_sueldo());
    }
}