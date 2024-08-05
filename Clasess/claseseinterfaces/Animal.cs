using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseseinterfaces
{
    public class Animal : IAnimal
    {
        // Implementación del método HacerSonido
        public void HacerSonido()
        {
            Console.WriteLine("El animal hace un sonido.");
        }

        // Implementación del método Mover
        public void Mover()
        {
            Console.WriteLine("El animal se está moviendo.");
        }
    }
    public class AnimalProgram
    {
        public static void Main(string[] args)
        {
            // Crear una instancia de Animal
            IAnimal miAnimal = new Animal();

            // Llamar a los métodos definidos en la interfaz
            miAnimal.HacerSonido();
            miAnimal.Mover();
        }
    }

}
