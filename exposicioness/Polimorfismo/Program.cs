//Polimorfismo
using System;


public abstract class Animal
{
    public string Nombre { get; set; }

    public Animal(string nombre)
    {
        Nombre = nombre;
    }

    // Método abstracto para clases derivadas
    public abstract void HacerSonido();
}

public class Perro : Animal
{
    public Perro(string nombre) : base(nombre) { }

    public override void HacerSonido()
    {
        Console.WriteLine("¡Guau!");
    }
}

public class Gato : Animal
{
    public Gato(string nombre) : base(nombre) { }

    public override void HacerSonido()
    {
        Console.WriteLine("¡Miau!");
    }
}


class Programa
{
    static void Main(string[] args)
    {
        // Array de tipo Animal que contiene diferentes tipos de animales
        // array es una coleccion de elementos del mismo tipo
        Animal[] animales = new Animal[]
        {
            new Perro("Sacha"),
            new Gato("Pelusa"),
            new Perro("Toby"),
            new Gato("Manchas")
        };

        // aca interatua con el array para llamar hacersonido
        foreach (Animal animal in animales)
        {
            Console.Write($"{animal.Nombre} dice: ");
            animal.HacerSonido();
        }
    }
}
