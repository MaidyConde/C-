using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class Pato: IVolar,INadar
    {
        public void Volar()
        {
            Console.WriteLine("El pato está volando");
        }

        public void Nadar() 
        {
            Console.WriteLine("El pato está nadando");
        }
    }
}
