using System;

public class Circulo
{
    // Campo privado
    private double radio;

    // Constructor
    public Circulo(double radio)
    {
        if (radio > 0)
        {
            this.radio = radio;
        }
    }

    // Get
    public double GetRadio()
    {
        return radio;
    }

    public double GetDiametro()
    {
        return radio * 2;
    }

    // Set
    public void SetRadio(double radio)
    {
        if (radio > 0)
        {
            this.radio = radio;
        }
    }

    // Métodos de cálculo
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    public double CalcularCircunferencia()
    {
        return 2 * Math.PI * radio;
    }
}