using Liskov;

public class Program
{
    public static void Main(string[] args)
    {
        IVolar loroVolador = new Loro();
        loroVolador.Volar();

        ICaminar loroCaminante = new Loro();
        loroCaminante.Caminar();

        ICaminar pinguinoCaminante = new Pinguino();
        pinguinoCaminante.Caminar();
    }
}
