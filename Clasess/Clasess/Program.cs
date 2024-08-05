// See https://aka.ms/new-console-template for more information
public class Circulo
{
    public double Radio { get; set; }

    public double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }
}

public class Program
{
    static void Main()
    {
        Circulo miCirculo = new Circulo();

        miCirculo.Radio = 5;

        double area = miCirculo.CalcularArea();

        Console.WriteLine("El area del circulo con radio " + miCirculo.Radio + " es: " + area);
    }
}

