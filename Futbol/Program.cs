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
            Fichero.CargarDatos();

            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("====== MENÚ PRINCIPAL ======");
                Console.WriteLine("1. Crear Equipo");
                Console.WriteLine("2. Listar equipo");
                Console.WriteLine("3. Alta jugador");
                Console.WriteLine("4. Listar jugadores (equipo)");
                Console.WriteLine("0. Salir");
                Console.WriteLine("============================");
                Console.Write("Selecciona una opción: ");

                while (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Por favor ingresa un número válido.");
                    Console.Write("Selecciona una opción: ");
                }

                switch (opcion)
                {
                    case 1:
                        Equipo.CrearEquipo();
                        break;
                    case 2:
                        Club.ListarEquipos();
                        Console.WriteLine("\nPresiona una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Jugador.AltaJugador();
                        break;
                    case 4:
                        Jugador.ListarJugadoresPorEquipo();
                        break;
                    case 0:
                        Fichero.GuardarDatos();
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intenta de nuevo.");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 0);
        }
    }
}

