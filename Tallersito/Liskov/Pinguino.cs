using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    public class Pinguino : Ave
    {
        public override void Caminar()
        {
            Console.WriteLine("El pinguino camina");
        }
    }
}
