using System;

// Interfaz IVolar: Define el comportamiento de volar.
public interface IVolar
{
    void Volar();
}

// Interfaz INadar: Define el comportamiento de nadar.
public interface INadar
{
    void Nadar();
}

// Clase Pajaro: Implementa solo la interfaz IVolar.
// Segregación de Interfaces: La clase Pajaro solo depende de la interfaz IVolar.
public class Pajaro : IVolar
{
    public void Volar()
    {
        Console.WriteLine("El pájaro está volando.");
    }
}

// Clase Pato: Implementa ambas interfaces, IVolar y INadar.
// Segregación de Interfaces: La clase Pato implementa ambas interfaces porque puede volar y nadar.
public class Pato : IVolar, INadar
{
    public void Volar()
    {
        Console.WriteLine("El pato está volando.");
    }

    public void Nadar()
    {
        Console.WriteLine("El pato está nadando.");
    }
}

// Clase Program: Punto de entrada de la aplicación.
public class Program
{
    public static void Main(string[] args)
    {
        // Creación de un pájaro que solo puede volar.
        IVolar pajaro = new Pajaro();
        pajaro.Volar();

        // Creación de un pato que puede volar y nadar.
        Pato pato = new Pato();
        pato.Volar();
        pato.Nadar();
    }
}
