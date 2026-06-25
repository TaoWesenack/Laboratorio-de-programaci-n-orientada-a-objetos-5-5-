using System;

class Pago
{
    protected double monto;
    protected string fecha;

    public Pago(double monto, string fecha)
    {
        this.monto = monto;
        this.fecha = fecha;
    }

    public virtual void ProcesarPago()
    {
        Console.WriteLine("Monto: $" + monto);
        Console.WriteLine("Fecha: " + fecha);
    }
}

class PagoTarjeta : Pago
{
    public PagoTarjeta(double monto, string fecha)
        : base(monto, fecha)
    {
    }

    public override void ProcesarPago()
    {
        Console.WriteLine("Pago procesado con tarjeta.");
    }
}

class PagoPayPal : Pago
{
    public PagoPayPal(double monto, string fecha)
        : base(monto, fecha)
    {
    }

    public override void ProcesarPago()
    {
        Console.WriteLine("Pago procesado con PayPal.");
    }
}