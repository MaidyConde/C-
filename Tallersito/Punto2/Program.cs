using System;
using System.Threading.Tasks;

namespace punto1
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Por favor, ingrese el nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Por favor, ingrese la edad de la persona:");
            int edad;
            while (!int.TryParse(Console.ReadLine(), out edad))
            {
                Console.WriteLine("Por favor ingrese un número válido para la edad:");
            }

            Console.WriteLine("Por favor, ingrese el teléfono:");
            int telefono;
            while (!int.TryParse(Console.ReadLine(), out telefono))
            {
                Console.WriteLine("Por favor ingrese un número válido para el teléfono:");
            }

            Console.WriteLine("Por favor, ingrese la dirección de la persona:");
            string direccion = Console.ReadLine();

            Console.WriteLine("Por favor, ingrese el número de días trabajados:");
            int diasTrabajados;
            while (!int.TryParse(Console.ReadLine(), out diasTrabajados))
            {
                Console.WriteLine("Por favor ingrese un número válido para los días trabajados:");
            }

            Console.WriteLine("Trayendo datos, por favor espere...");
            Empleado empleado = await CrearEmpleadoAsync(nombre, edad, telefono, direccion, diasTrabajados);

            empleado.Mostrar();

            Console.ReadKey();
        }

        static async Task<Empleado> CrearEmpleadoAsync(string nombre, int edad, int telefono, string direccion, int diasTrabajados)
        {
            await Task.Delay(5000);
            return new Empleado(nombre, edad, telefono, direccion, diasTrabajados);
        }
    }

    public class Empleado
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public int DiasTrabajados { get; set; }

        public Empleado(string nombre, int edad, int telefono, string direccion, int diasTrabajados)
        {
            Nombre = nombre;
            Edad = edad;
            Telefono = telefono;
            Direccion = direccion;
            DiasTrabajados = diasTrabajados;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Teléfono: {Telefono}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine($"Días Trabajados: {DiasTrabajados}");
        }
    }
}
