using System;
using System.Threading;

public class Tarea
{
    public string Nombre { get; set; }
    public int Duracion { get; set; } 

    public Tarea(string nombre, int duracion)
    {
        this.Nombre = nombre;
        this.Duracion = duracion;
    }

    public void Ejecutar()
    {
        Console.WriteLine($"-> [{DateTime.Now:HH:mm:ss}] INICIANDO tarea: '{Nombre}' (durará {Duracion} segundos)");
        Thread.Sleep(Duracion * 1000);
        Console.WriteLine($"<- [{DateTime.Now:HH:mm:ss}] FINALIZADA tarea: '{Nombre}'");
    }
}