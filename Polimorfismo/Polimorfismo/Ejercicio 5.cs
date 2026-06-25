using System;
using System.Collections.Generic;

class Pago
{
    public virtual void procesarPago()
    {
        Console.WriteLine("Procesando pago...");
    }
}

class TarjetaCredito : Pago
{
    public override void procesarPago()
    {
        Console.WriteLine("Pago realizado con Tarjeta de Crédito.");
    }
}

class PayPal : Pago
{
    public override void procesarPago()
    {
        Console.WriteLine("Pago realizado con PayPal.");
    }
}

class Program
{
    static void Main()
    {
        List<Pago> pagos = new List<Pago>()
        {
            new TarjetaCredito(),
            new PayPal(),
            new TarjetaCredito()
        };

        foreach (Pago pago in pagos)
        {
            pago.procesarPago();
        }
    }
}