using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    public class Loro : Ave,IVolar
    {
        public void Volar()
        {
            Console.WriteLine("El loro esta volando");
        }
        public override void Caminar()
        {
            Console.WriteLine("El loro esta caminando");
        }
    }
}
