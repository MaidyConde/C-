using System;
using System.Threading.Tasks;

namespace EjemploAsincronico
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Iniciando la lectura de datos...");

            string resultado = await LeerDatos();

            Console.WriteLine($"Datos leídos: {resultado}");
        }

        static async Task<string> LeerDatos()
        {
         
            await Task.Delay(3000);

            return "Datos simulados";
        }
    }
}

