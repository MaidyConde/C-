using System;
using System.Threading.Tasks;

namespace punto1
{
    public class Program
    {
        static async Task Main(string[] args)
        {

            Console.WriteLine("Por favor, ingrese el nombre :");
            string nombre = Console.ReadLine();

            Console.WriteLine("Por favor, ingrese la edad de la persona:");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor, ingrese el telefono:");
            int telefono = int.Parse(Console.ReadLine());


            Console.WriteLine("Por favor, ingrese la dirección de la persona:");
            string direccion = Console.ReadLine();

            
            Console.WriteLine("Por favor, ingrese el número de días trabajados:");
            int diasTrabajados = int.Parse(Console.ReadLine());

            Console.WriteLine("Trayendo datos, por favor espere...");
            Empleado empleado = await CrearEmpleadoAsync(nombre, edad,telefono,direccion, diasTrabajados);

            empleado.Mostrar();

            Console.ReadKey();
        }

        static async Task<Empleado> CrearEmpleadoAsync(string nombre, int edad,int telefono, string direccion, int diasTrabajados)
        {
            await Task.Delay(5000);
            return new Empleado(nombre, edad, telefono,direccion, diasTrabajados);
        }
    }
}