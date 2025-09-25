using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("====== MENÚ PRINCIPAL ======");
                Console.WriteLine("1. Crear Equipo");
                Console.WriteLine("2. Alta jugador");
                Console.WriteLine("3. Listar equipo");
                Console.WriteLine("0. Salir");
                Console.WriteLine("============================");
                Console.Write("Selecciona una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Por favor ingresa un número válido.");
                    Console.ReadKey();
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        CrearEquipo();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intenta de nuevo.");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 0);
        }

        static void CrearEquipo()
        {
            string nombre;
            Console.Write("Dime el nombre del equipo: ");
            nombre = Console.ReadLine();

            Equipo.AgregarEquipo(nombre);
        }
    }
}

