using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Futbol
{
    internal class Jugador
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Posicion { get; set; }

        public Jugador() { }
        public Jugador(string nombre, int edad, string posicion)
        {
            Nombre = nombre;
            Edad = edad;
            Posicion = posicion;
        }

        public static void AltaJugador()
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

        public static void ListarJugadoresPorEquipo()
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
