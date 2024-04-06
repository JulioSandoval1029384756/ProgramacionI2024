using System;

public interface INotificable
{
    void Notificar(string mensaje);
}

public class NotificacionEmail : INotificable
{
    private string direccionCorreo;

    public NotificacionEmail(string correo)
    {
        direccionCorreo = correo;
    }

    public void Notificar(string mensaje)
    {
        Console.WriteLine($"Enviando notificación por correo electrónico a {direccionCorreo}: {mensaje}");
    }
}

public class NotificacionWhatsap : INotificable
{
    private string numeroTelefono;

    public NotificacionWhatsap(string telefono)
    {
        numeroTelefono = telefono;
    }

    public void Notificar(string mensaje)
    {
        Console.WriteLine($"Enviando notificación por WhatsApp al número {numeroTelefono}: {mensaje}");
    }
}

public class NotificacionSMS : INotificable
{
    private string numeroTelefono;

    public NotificacionSMS(string telefono)
    {
        numeroTelefono = telefono;
    }

    public void Notificar(string mensaje)
    {
        Console.WriteLine($"Enviando notificación por SMS al número {numeroTelefono}: {mensaje}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        INotificable emailNotificacion = new NotificacionEmail("homer@gmail.com");
        INotificable whatsappNotificacion = new NotificacionWhatsap("1029384756");
        INotificable smsNotificacion = new NotificacionSMS("56295383");

        emailNotificacion.Notificar("Mensaje de prueba.");
        whatsappNotificacion.Notificar("Mensaje de prueba.");
        smsNotificacion.Notificar("Mensaje de prueba.");
    }
}
    