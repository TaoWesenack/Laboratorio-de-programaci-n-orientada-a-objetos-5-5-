using System;

public class Rectangulo
{
    // Campos privados
    private double longitud;
    private double anchura;

    // Constructor
    public Rectangulo(double longitud, double anchura)
    {
        this.longitud = longitud;
        this.anchura = anchura;
    }

    // Get
    public double GetLongitud()
    {
        return longitud;
    }

    public double GetAnchura()
    {
        return anchura;
    }

    // Set
    public void SetLongitud(double longitud)
    {
        if (longitud > 0)
        {
            this.longitud = longitud;
        }
    }

    public void SetAnchura(double anchura)
    {
        if (anchura > 0)
        {
            this.anchura = anchura;
        }
    }

    // Métodos de cálculo
    public double CalcularArea()
    {
        return longitud * anchura;
    }

    public double CalcularPerimetro()
    {
        return 2 * (longitud + anchura);
    }
}