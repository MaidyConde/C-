using OpenClosed;

public class Program
{
    public static void Main(string[] args)
    {
        double num1 = 6;
        double num2 = 4;

        
        Ioperacion suma = new Suma();
        Ioperacion resta = new Resta();
        Ioperacion multiplicacion = new Multiplicacion();

        Console.WriteLine($"Suma: {suma.Ejecutar(num1, num2)}");
        Console.WriteLine($"Resta: {resta.Ejecutar(num1, num2)}");
        Console.WriteLine($"Multiplicación: {multiplicacion.Ejecutar(num1, num2)}");
    }
}
