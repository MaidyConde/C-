﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class Pajaro : IVolar
    {
        public void Volar()
        {
            Console.WriteLine("El pajaro voló");
        }

    }
}
