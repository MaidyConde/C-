
/*la clase ya tiene más de una responsabilidad.
class Coche
{
    String marca;

    Coche(String marca) { this.marca = marca; }

    String getMarcaCoche() { return marca; }

    void guardarCocheDB(Coche coche) { ... }
}
*/


using System;

// Clase que representa el coche
public class Coche
{
    public string Marca { get; private set; }

    public Coche(string marca)
    {
        Marca = marca;
    }

    public string ObtenerMarcaCoche()
    {
        return Marca;
    }
}

// Clase encargada de la persistencia en la base de datos
public class CocheDB
{
    public void GuardarCocheDB(Coche coche)
    {
        // guardar el coche en la base de datos
        Console.WriteLine($"Coche {coche.ObtenerMarcaCoche()} guardado en la base de datos.");
    }

    public void EliminarCocheDB(Coche coche)
    {
        //eliminar el coche de la base de datos
        Console.WriteLine($"Coche {coche.ObtenerMarcaCoche()} eliminado de la base de datos.");
    }
}

// Clase de prueba para demostrar el uso
class Program
{
    static void Main(string[] args)
    {
        //instancia de Coche
        Coche coche = new Coche("Toyota");

        // instancia de CocheDB
        CocheDB cocheDB = new CocheDB();

        // Guardar el coche en la base de datos
        cocheDB.GuardarCocheDB(coche);

        // Eliminar el coche de la base de datos
        cocheDB.EliminarCocheDB(coche);
    }
}
