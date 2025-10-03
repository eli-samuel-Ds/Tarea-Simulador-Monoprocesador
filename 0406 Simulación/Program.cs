using System;

namespace _0406_Simulación
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Monoprocesador miProcesador = new Monoprocesador();
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("--- Simulador de Monoprocesador ---");
                Console.WriteLine("1. Agregar una nueva tarea manual");
                Console.WriteLine("2. Agregar tareas predeterminadas");
                Console.WriteLine("3. Ejecutar todas las tareas en cola");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                string input = Console.ReadLine();
                Console.WriteLine(); 

                switch (input)
                {
                    case "1":
                        try
                        {
                            Console.Write("Ingrese el nombre de la tarea: ");
                            string nombre = Console.ReadLine();

                            Console.Write("Ingrese la duración de la tarea (en segundos): ");
                            int duracion = int.Parse(Console.ReadLine());

                            miProcesador.AgregarTarea(new Tarea(nombre, duracion));
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("❌ Error: La duración debe ser un número entero. Inténtelo de nuevo.");
                        }
                        Console.WriteLine();
                        break;

                    case "2":
                        Console.WriteLine("Agregando tareas predeterminadas...");
                        miProcesador.AgregarTarea(new Tarea("Procesar video corto", 5));
                        miProcesador.AgregarTarea(new Tarea("Compilar código fuente", 3));
                        miProcesador.AgregarTarea(new Tarea("Realizar copia de seguridad de la base de datos", 8));
                        Console.WriteLine();
                        break;

                    case "3":
                        miProcesador.EjecutarTareas();
                        break;

                    case "4":
                        salir = true;
                        Console.WriteLine("Saliendo del simulador. ¡Hasta luego!");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 4.");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
