using System;

// Interfaz IEnviadorNotificaciones: Define el comportamiento para enviar notificaciones.
public interface IEnviadorNotificaciones
{
    void Enviar(string mensaje);
}

// Interfaz IEmailNotificador: Define el comportamiento específico para notificaciones por email.
public interface IEmailNotificador : IEnviadorNotificaciones
{
    void EnviarPorEmail(string mensaje);
}

// Interfaz ISMSNotificador: Define el comportamiento específico para notificaciones por SMS.
public interface ISMSNotificador : IEnviadorNotificaciones
{
    void EnviarPorSMS(string mensaje);
}

// Clase EmailNotificador: Implementa IEmailNotificador y proporciona implementación para enviar notificaciones por email.
public class EmailNotificador : IEmailNotificador
{
    public void Enviar(string mensaje)
    {
        EnviarPorEmail(mensaje);
    }

    public void EnviarPorEmail(string mensaje)
    {
        Console.WriteLine($"Enviando email: {mensaje}");
    }
}

// Clase SMSNotificador: Implementa ISMSNotificador y proporciona implementación para enviar notificaciones por SMS.
public class SMSNotificador : ISMSNotificador
{
    public void Enviar(string mensaje)
    {
        EnviarPorSMS(mensaje);
    }

    public void EnviarPorSMS(string mensaje)
    {
        Console.WriteLine($"Enviando SMS: {mensaje}");
    }
}

// Clase Aplicacion: Depende de la interfaz IEnviadorNotificaciones, no de implementaciones concretas.
// Esto permite usar cualquier notificador que implemente IEnviadorNotificaciones.
public class Aplicacion
{
    private readonly IEnviadorNotificaciones _notificador;

    // Constructor que recibe un notificador a través de la interfaz.
    public Aplicacion(IEnviadorNotificaciones notificador)
    {
        _notificador = notificador;
    }

    public void Ejecutar()
    {
        _notificador.Enviar("Notificación importante.");
    }
}

// Clase Program: Punto de entrada de la aplicación.
public class Program
{
    public static void Main(string[] args)
    {
        // Creación de un notificador de email y aplicación.
        IEnviadorNotificaciones notificadorEmail = new EmailNotificador();
        Aplicacion appEmail = new Aplicacion(notificadorEmail);
        appEmail.Ejecutar();

        // Creación de un notificador de SMS y aplicación.
        IEnviadorNotificaciones notificadorSMS = new SMSNotificador();
        Aplicacion appSMS = new Aplicacion(notificadorSMS);
        appSMS.Ejecutar();
    }
}

//Las interfaces IEmailNotificador e ISMSNotificador proporcionan métodos adicionales específicos
//para cada tipo de notificación, mientras que IEnviadorNotificaciones ofrece una interfaz más general.


//Las clases EmailNotificador y SMSNotificador implementan interfaces especializadas pero pueden ser
//usadas a través de IEnviadorNotificaciones en la clase Aplicacion.