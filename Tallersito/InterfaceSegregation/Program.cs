using InterfaceSegregation;

public class Program
{
    public static void Main(string[] args)
    {
     
        IVolar pajaro = new Pajaro();
        pajaro.Volar();

        Pato pato = new Pato();
        pato.Volar();
        pato.Nadar();
    }
}
