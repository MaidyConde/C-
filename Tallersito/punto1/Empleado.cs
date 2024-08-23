using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    public class Empleado : Persona, ICalculable
    {
        public int DiasTrabajados { get; set; }
        public int ValorDia { get; set; }
        public int Salario { get; set; }

        public Empleado(string nombre, int edad,int telefono, string direccion, int diasTrabajados)
            : base(nombre, edad,telefono, direccion, diasTrabajados)
        {
            DiasTrabajados = DiasTrabajados;
            ValorDia = 1300000;
            Salario = CalcularSalario();
        }

        public int CalcularSalario()
        {
            return ValorDia / 30 * DiasTrabajados;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Salario: {Salario}");
        }
    }
}