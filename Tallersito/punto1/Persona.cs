using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    public class Persona
    {
        public string nombre { get; set; }
        public int edad { get; set; }

        public int telefono { get; set; }
        public string direccion { get; set; }

        public Persona(string nombre, int edad, int telefono, string direccion,int DiasTrabajados)
        {
            nombre = nombre;
            edad = edad;
            telefono = telefono;
            direccion = direccion;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine($"Nombre:{nombre}");
            Console.WriteLine($"Edad:{edad}");
            Console.WriteLine($"Direccion:{direccion}");
            Console.WriteLine($"Telefono:{telefono}");

        }
    }
}
