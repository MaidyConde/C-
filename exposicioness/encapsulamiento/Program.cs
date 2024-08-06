using System;

public class Coche
{
    // Campos privados
    private string marca;
    private string modelo;
    private int año;

    // Propiedad para marca
    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }

    // Propiedad para modelo
    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    // Propiedad para año
    public int Año
    {
        get { return año; }
        set { año = value; }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Crear una clase de Coche
        Coche miCoche = new Coche();

        // Establecer propiedades
        miCoche.Marca = "Toyota";
        miCoche.Modelo = "Fortuner";
        miCoche.Año = 2020;

        // Mostrar información del coche
        Console.WriteLine($"Marca: {miCoche.Marca}");
        Console.WriteLine($"Modelo: {miCoche.Modelo}");
        Console.WriteLine($"Año: {miCoche.Año}");
    }
}
