using DependencyInversion;

public class Programa
{
    public static void Main()
    {
        IAnimal leon = new Leon();
        Cuidador cuidador = new Cuidador(leon);
        cuidador.AlimentarAnimal(); 

        IAnimal elefante = new Elefante();
        cuidador = new Cuidador(elefante);
        cuidador.AlimentarAnimal(); 
    }
}
