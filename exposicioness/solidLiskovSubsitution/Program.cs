using System;

// Interfaz IVolar: Define el comportamiento de volar.
public interface IVolar
{
    void Volar();
}

// Interfaz ICaminar: Define el comportamiento de caminar.
public interface ICaminar
{
    void Caminar();
}

// Clase base Ave: Puede implementar ICaminar y opcionalmente IVolar.
public abstract class Ave : ICaminar
{
    public abstract void Caminar();
}

// Clase Loro: Implementa IVolar y ICaminar.
public class Loro : Ave, IVolar
{
    public void Volar()
    {
        Console.WriteLine("El loro está volando.");
    }

    public override void Caminar()
    {
        Console.WriteLine("El loro está caminando.");
    }
}

// Clase Pinguino: Implementa solo ICaminar.
public class Pinguino : Ave
{
    public override void Caminar()
    {
        Console.WriteLine("El pingüino está caminando.");
    }
}

// Clase Program: Punto de entrada de la aplicación.
public class Program
{
    public static void Main(string[] args)
    {
        IVolar loroVolador = new Loro();
        loroVolador.Volar();

        ICaminar loroCaminante = new Loro();
        loroCaminante.Caminar();

        ICaminar pinguinoCaminante = new Pinguino();
        pinguinoCaminante.Caminar();
    }
}

//Sustituibilidad: Ahora, cualquier instancia de Ave puede ser sustituida por Loro o Pinguino en contextos donde solo se necesita caminar, sin causar excepciones.
//Extensibilidad: Podemos agregar nuevas aves que implementen IVolar, ICaminar o ambos sin modificar las clases existentes.
