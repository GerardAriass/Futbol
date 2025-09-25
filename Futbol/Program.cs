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
                        CrearEquipo();
                        break;
                    case 2:
                        ListarEquipos();
                        break;
                    case 3:
                        AltaJugador();
                        break;
                    case 4:
                        ListarJugadoresPorEquipo();
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

        static void CrearEquipo()
        {
            string nombre;
            Console.Write("Dime el nombre del equipo: ");
            nombre = Console.ReadLine();

            Equipo nuevoEquipo = new Equipo(nombre);

            Club.AgregarEquipo(nuevoEquipo);
        }

        static void ListarEquipos()
        {
            Console.Clear();
            Club.ListarEquipos();
            Console.WriteLine("\nPresiona una tecla para continuar...");
            Console.ReadKey();
        }

        static void AltaJugador()
        {
            Console.Clear();

            if (Club.ListaEquipos.Count == 0)
            {
                Console.WriteLine("Primero debes crear un equipo antes de dar de alta jugadores.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("====== ALTA DE JUGADOR ======");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            int edad;
            while (true)
            {
                Console.Write("Edad: ");
                if (int.TryParse(Console.ReadLine(), out edad) && edad > 0)
                    break;
                Console.WriteLine("Edad no válida. Intenta nuevamente.");
            }

            Console.Write("Posición: ");
            string posicion = Console.ReadLine();

            Console.WriteLine("\nSelecciona el equipo al que pertenece:");
            Club.ListarEquipos();
            int opcionEquipo;
            while (true)
            {
                Console.Write("Opción: ");
                if (int.TryParse(Console.ReadLine(), out opcionEquipo) &&
                    opcionEquipo >= 1 &&
                    opcionEquipo <= Club.ListaEquipos.Count)
                    break;

                Console.WriteLine("Opción inválida. Intenta nuevamente.");
            }

            Equipo equipoSeleccionado = Club.ListaEquipos[opcionEquipo - 1];

            Jugador nuevoJugador = new Jugador(nombre, edad, posicion);
            equipoSeleccionado.AgregarJugador(nuevoJugador);

            Console.WriteLine("\nJugador dado de alta con éxito.");
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadKey();
        }

        static void ListarJugadoresPorEquipo()
        {
            Console.Clear();

            if (Club.ListaEquipos.Count == 0)
            {
                Console.WriteLine("No hay equipos registrados.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Selecciona el equipo para ver sus jugadores:");

            for (int i = 0; i < Club.ListaEquipos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Club.ListaEquipos[i].Nombre}");
            }

            int opcion;
            while (true)
            {
                Console.Write("Opción: ");
                if (int.TryParse(Console.ReadLine(), out opcion) &&
                    opcion >= 1 && opcion <= Club.ListaEquipos.Count)
                {
                    break;
                }
                Console.WriteLine("Opción inválida. Intenta de nuevo.");
            }

            Equipo equipoSeleccionado = Club.ListaEquipos[opcion - 1];

            equipoSeleccionado.ListarJugadores();

            Console.WriteLine("\nPresiona una tecla para continuar...");
            Console.ReadKey();
        }

    }
}

