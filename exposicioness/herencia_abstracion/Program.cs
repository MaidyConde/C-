// Abstracion y Herencia

using System;

// Clase abstracta Animal
public abstract class Animal
{
    // Propiedad Nombre
    public string Nombre { get; set; }

    // Constructor 
    public Animal(string nombre)
    {
        Nombre = nombre;
    }

    // describe al animal
    public void Describir()
    {
        Console.WriteLine($"Soy un {this.GetType().Name} y me llamo {Nombre}.");
    }

    // Método abstracto
    public abstract void HacerSonido();
}
//perro hereda de animal
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
    // Constructor que llama al constructor de la clase base
    public Gato(string nombre) : base(nombre) { }

    // Implementación del método abstracto HacerSonido
    public override void HacerSonido()
    {
        Console.WriteLine("¡Miau!");
    }
    class Programa
    {
        static void Main(string[] args)
        {
            // Creación de una instancia de Perro
            Animal perro = new Perro("Sacha");

            // Creación de una instancia de Gato
            Animal gato = new Gato("Pelusa");

            // método Describir y HacerSonido
            perro.Describir();
            perro.HacerSonido();


            gato.Describir();
            gato.HacerSonido();
        }
    }
}