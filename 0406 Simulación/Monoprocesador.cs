using System;
using System.Collections.Generic;

namespace _0406_Simulación
{
    public class Monoprocesador
    {
        private List<Tarea> cola_tareas;

        public Monoprocesador()
        {
            cola_tareas = new List<Tarea>();
        }

        public void AgregarTarea(Tarea tarea)
        {
            cola_tareas.Add(tarea);
            Console.WriteLine($"Tarea '{tarea.Nombre}' agregada a la cola.");
        }
        public void EjecutarTareas()
        {
            Console.WriteLine("Iniciando ejecución de todas las tareas...");

            if (cola_tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas en la cola para ejecutar.");
                return;
            }

            foreach (var tarea in cola_tareas)
            {
                tarea.Ejecutar();
            }

            cola_tareas.Clear();

            Console.WriteLine("¡Todas las tareas han sido completadas!");
        }
    }
}
