using System;
using System.Collections.Generic;

// Interfaz IOperacion: Define una operación con un método Ejecutar.
public interface IOperacion
{
    double Ejecutar(double a, double b);
}

// Clase Suma: Implementa la interfaz IOperacion para realizar la suma.
public class Suma : IOperacion
{
    public double Ejecutar(double a, double b)
    {
        return a + b;
    }
}

// Clase Resta: Implementa la interfaz IOperacion para realizar la resta.
public class Resta : IOperacion
{
    public double Ejecutar(double a, double b)
    {
        return a - b;
    }
}

// Clase Calculadora: Usa la interfaz IOperacion para realizar las operaciones.
public class Calculadora
{
    private readonly List<IOperacion> _operaciones;

    public Calculadora()
    {
        _operaciones = new List<IOperacion>();
    }

    public void AgregarOperacion(IOperacion operacion)
    {
        _operaciones.Add(operacion);
    }

    public void RealizarOperaciones(double a, double b)
    {
        foreach (var operacion in _operaciones)
        {
            Console.WriteLine($"Resultado: {operacion.Ejecutar(a, b)}");
        }
    }
}

// Clase Program: Punto de entrada de la aplicación.
public class Program
{
    public static void Main(string[] args)
    {
        // Creación de una calculadora.
        Calculadora calculadora = new Calculadora();

        // Adición de operaciones a la calculadora.
        calculadora.AgregarOperacion(new Suma());
        calculadora.AgregarOperacion(new Resta());

        // Realización de operaciones con los números 5 y 3.
        calculadora.RealizarOperaciones(5, 3);
    }
}

// abierto para la extension para agregar una nueva operación (por ejemplo, multiplicación),
// simplemente creamos una nueva clase que implemente IOperacion, sin necesidad de modificar las clases existentes 
