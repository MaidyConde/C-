﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class Elefante: IAnimal
    {
        public void Comer()
        {
            Console.WriteLine("El elefante está comiendo");

        }
    }
}
