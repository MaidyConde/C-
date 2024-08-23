
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


public class CocheDB
{
    public void GuardarCocheDB(Coche coche)
    {
        
        Console.WriteLine($"Coche {coche.ObtenerMarcaCoche()} guardado en la base de datos.");
    }

    public void EliminarCocheDB(Coche coche)
    {
        
        Console.WriteLine($"Coche {coche.ObtenerMarcaCoche()} eliminado de la base de datos.");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Coche coche = new Coche("Toyota");
        CocheDB cocheDB = new CocheDB();

        cocheDB.GuardarCocheDB(coche);
        cocheDB.EliminarCocheDB(coche);
    }
}