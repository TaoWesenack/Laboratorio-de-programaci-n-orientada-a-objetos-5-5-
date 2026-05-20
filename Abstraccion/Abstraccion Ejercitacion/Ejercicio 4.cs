/******************************************************************************

Define una clase abstracta Notificacion con un método abstracto enviar(). 
Crea dos clases concretas, Email y SMS, que implementen el método enviar() de 
manera diferente.

*******************************************************************************/

using System;

abstract class Notificacion
{
    public abstract string enviar();
}

class Email : Notificacion
{
    public override string enviar()
    {
        return "Se envio el mensaje por Email";
    }
}

class SMS : Notificacion
{
    public override string enviar()
    {
        return "Se envio el mensaje por SMS";
    }
    
}

class Program
{
    static void Main()
    {
        Notificacion Email = new Email();
        Notificacion SMS = new SMS();

        Console.WriteLine(Email.enviar());
        Console.WriteLine(SMS.enviar());
    }
}