/******************************************************************************

Define una clase abstracta Pago con un método abstracto procesar_pago(). Luego, 
crea dos clases concretas, TarjetaCredito y PayPal, que implementen el método 
procesar_pago() de manera diferente.

*******************************************************************************/
using System;

abstract class Pago
{
    public abstract string procesar_pago();
}

class TarjetaCredito : Pago
{
    public override string procesar_pago()
    {
        return "Se proceso el pago con la tarjeta de credito";
    }
}

class Paypal : Pago
{
    public override string procesar_pago()
    {
        return "Se proceso el pago con Paypal";
    }
}

class program
{
    static void Main() 
    {
        Pago TarjetaCredito = new TarjetaCredito();
        Pago Paypal = new Paypal();
        
        Console.WriteLine(TarjetaCredito.procesar_pago());
        Console.WriteLine(Paypal.procesar_pago());
        
    }
}
