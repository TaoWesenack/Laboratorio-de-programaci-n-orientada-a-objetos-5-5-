using System;

public class CuentaBancaria
{
    private string titular;
    private string numeroCuenta;
    private double saldo;

    public string Titular{get;set;}

    public string NumeroCuenta{get;set;}
    
    public double Saldo
    {
        get { return saldo; }
        private set
        {
            if (value >= 0)
                saldo = value;
        }
    }

    // Constructor.
    public CuentaBancaria(string titular, string numeroCuenta, double saldo)
    {
        Titular = titular;
        NumeroCuenta = numeroCuenta;
        Saldo = saldo;
    }

    //para depositar
    public void Depositar(double cantidad)
    {
        if (cantidad > 0)
        {
            Saldo += cantidad;
            Console.WriteLine($"Se han depositado {cantidad}. Saldo actual: {Saldo}");
        }
        else
        {
            Console.WriteLine("La cantidad a depositar debe ser positiva.");
        }
    }

    //para retirar
    public void Retirar(double cantidad)
    {
        if (cantidad > 0)
        {
            if (Saldo >= cantidad)
            {
                Saldo -= cantidad;
                Console.WriteLine($"Se han retirado {cantidad}. Saldo actual: {Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }
        else
        {
            Console.WriteLine("La cantidad debe ser positiva.");
        }
    }

    //información
    public void MostrarInfo()
    {
        Console.WriteLine($"El titular es {Titular}");
        Console.WriteLine($"El número de cuenta es {NumeroCuenta}");
        Console.WriteLine($"El saldo es {Saldo}");
    }
}

public class Programa
{
    static void Main()
    {
        Console.WriteLine("Ingresa el titular de la cuenta bancaria");
        string titular = Console.ReadLine() ?? "";

        Console.WriteLine("Ingresa el número de cuenta bancaria");
        string numeroCuenta = Console.ReadLine() ?? "";

        Console.WriteLine("Ingresa el saldo de la cuenta bancaria");
        double saldo = double.Parse(Console.ReadLine());

        if (saldo < 0)
        {
            Console.WriteLine("El saldo no puede ser negativo. Se establecerá en 0.");
            saldo = 0;
        }

        CuentaBancaria cuenta1 = new CuentaBancaria(titular, numeroCuenta, saldo);

        Console.WriteLine("\nInformación de la cuenta");
        cuenta1.MostrarInfo();

        Console.WriteLine("\nIngresa la cantidad a depositar");
        double cantidadDepositar = double.Parse(Console.ReadLine());
        cuenta1.Depositar(cantidadDepositar);

        Console.WriteLine("\nIngresa la cantidad a retirar");
        double cantidadRetirar = double.Parse(Console.ReadLine());
        cuenta1.Retirar(cantidadRetirar);

        Console.WriteLine("\nInformación actualizada de la cuenta bancaria");
        cuenta1.MostrarInfo();
    }
}