using System;

// ============================================================
// S - PRINCIPIO DE RESPONSABILIDAD ÚNICA (SRP)
// Antes: Vehiculo guardaba datos Y además imprimía por consola.
// Ahora: Vehiculo SOLO guarda los datos del vehículo.
// Calcular el combustible y mostrar información se movieron a
// otras clases (CalculadoraCombustible y ReporteVehiculo).
// ============================================================
abstract class Vehiculo
{
    public string Marca { get; }
    public string Modelo { get; }
    public int Año { get; }

    protected Vehiculo(string marca, string modelo, int año)
    {
        Marca = marca;
        Modelo = modelo;
        Año = año;
    }
}

// ============================================================
// I - PRINCIPIO DE SEGREGACIÓN DE INTERFACES (ISP)
// Antes: TODOS los vehículos heredaban CalcularCombustible(),
// aunque algunos (como una bicicleta) no usan combustible.
// Ahora: el consumo vive en una interfaz pequeña y específica.
// Solo la implementan los vehículos que realmente consumen.
// ============================================================
interface IConsumeCombustible
{
    double LitrosPor100Km { get; }
}

// ============================================================
// L - PRINCIPIO DE SUSTITUCIÓN DE LISKOV (LSP)
// Antes: el método base imprimía marca/modelo/año, pero los
// hijos lo sobrescribían y imprimían otra cosa; usar un hijo
// en lugar del padre cambiaba el comportamiento esperado.
// Ahora: cualquier Vehiculo se puede usar donde se espera un
// Vehiculo (datos), y solo los que implementan
// IConsumeCombustible se usan donde se espera consumo.
// Nadie queda obligado a un método que no tiene sentido para él.
// ============================================================
class Automovil : Vehiculo, IConsumeCombustible
{
    public Automovil(string marca, string modelo, int año)
        : base(marca, modelo, año) { }

    public double LitrosPor100Km => 8;
}

class Motocicleta : Vehiculo, IConsumeCombustible
{
    public Motocicleta(string marca, string modelo, int año)
        : base(marca, modelo, año) { }

    public double LitrosPor100Km => 4;
}

// Ejemplo de LSP + ISP: una bicicleta es un Vehiculo, pero NO
// implementa IConsumeCombustible, así que no se le obliga a
// "calcular combustible".
class Bicicleta : Vehiculo
{
    public Bicicleta(string marca, string modelo, int año)
        : base(marca, modelo, año) { }
}

// ============================================================
// S - RESPONSABILIDAD ÚNICA (SRP)
// Esta clase tiene una sola tarea: calcular el combustible.
// ============================================================
// D - INVERSIÓN DE DEPENDENCIAS (DIP)
// Depende de la abstracción IConsumeCombustible, no de
// Automovil o Motocicleta concretos.
// ============================================================
class CalculadoraCombustible
{
    public double CalcularLitros(IConsumeCombustible vehiculo, double kilometros)
    {
        return vehiculo.LitrosPor100Km * kilometros / 100;
    }
}

// ============================================================
// D - INVERSIÓN DE DEPENDENCIAS (DIP)
// Antes: el código escribía directamente con Console.WriteLine.
// Ahora: se depende de la abstracción ISalida. Hoy escribe en
// consola, pero mañana podría escribir en un archivo o en una
// base de datos sin tocar el resto del código.
// ============================================================
interface ISalida
{
    void EscribirLinea(string texto);
}

class SalidaConsola : ISalida
{
    public void EscribirLinea(string texto)
    {
        Console.WriteLine(texto);
    }
}

// ============================================================
// S - RESPONSABILIDAD ÚNICA (SRP)
// Esta clase solo se encarga de armar y mostrar el reporte.
// ============================================================
// D - INVERSIÓN DE DEPENDENCIAS (DIP)
// Recibe sus dependencias (ISalida y la calculadora) por el
// constructor ("inyección de dependencias") en lugar de crearlas.
// ============================================================
class ReporteVehiculo
{
    private readonly ISalida _salida;
    private readonly CalculadoraCombustible _calculadora;

    public ReporteVehiculo(ISalida salida, CalculadoraCombustible calculadora)
    {
        _salida = salida;
        _calculadora = calculadora;
    }

    public void Mostrar(Vehiculo vehiculo, double kilometros)
    {
        _salida.EscribirLinea("Marca: " + vehiculo.Marca);
        _salida.EscribirLinea("Modelo: " + vehiculo.Modelo);
        _salida.EscribirLinea("Año: " + vehiculo.Año);

        // Solo los vehículos que consumen combustible entran aquí (ISP + LSP)
        if (vehiculo is IConsumeCombustible conCombustible)
        {
            double litros = _calculadora.CalcularLitros(conCombustible, kilometros);
            _salida.EscribirLinea("Consumo en " + kilometros + " km: " + litros + " litros.");
        }
        else
        {
            _salida.EscribirLinea("Este vehículo no usa combustible.");
        }
    }
}

// ============================================================
// O - PRINCIPIO ABIERTO/CERRADO (OCP)
// Para agregar un nuevo vehículo (por ejemplo un Camion) solo
// se crea una clase nueva que herede de Vehiculo e implemente
// IConsumeCombustible. NO hay que modificar Vehiculo,
// CalculadoraCombustible ni ReporteVehiculo: el sistema está
// abierto a extensión y cerrado a modificación.
// ============================================================
class Program
{
    static void Main()
    {
        // Se arma el sistema con abstracciones (DIP)
        ISalida salida = new SalidaConsola();
        var calculadora = new CalculadoraCombustible();
        var reporte = new ReporteVehiculo(salida, calculadora);

        Vehiculo auto = new Automovil("Ford", "Focus", 2020);
        reporte.Mostrar(auto, 100);

        Console.WriteLine();

        Vehiculo moto = new Motocicleta("Honda", "CBR", 2022);
        reporte.Mostrar(moto, 100);

        Console.WriteLine();

        Vehiculo bici = new Bicicleta("Trek", "Marlin", 2021);
        reporte.Mostrar(bici, 100);
    }
}