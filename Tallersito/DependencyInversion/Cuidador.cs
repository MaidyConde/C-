using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class Cuidador
    {
        private readonly IAnimal _animal;

        public Cuidador(IAnimal animal)
        {
            _animal = animal;
        }

        public void AlimentarAnimal()
        {
            _animal.Comer();
        }
    }
}
