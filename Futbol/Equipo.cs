using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol
{
    internal class Equipo
    {
        private string _nombre;
        public static List<Equipo> ListaEquipos { get; private set; } = new List<Equipo>();
        public List<Jugador> Jugadores { get; private set; } = new List<Jugador>();

        public string Nombre
        {
            get { return _nombre; }
            private set { _nombre = value; }
        }

        public Equipo(string nombre)
        {
            this._nombre = nombre;
        }


        public static void AgregarEquipo(Equipo equipo)
        {
            ListaEquipos.Add(equipo);
        }

        public static void ListarEquipos()
        {
            int enumeracion = 1;
            if (ListaEquipos.Count == 0)
            {
                Console.WriteLine("No hay equipos registrados.");
                return;
            }

            Console.WriteLine("\nEquipos registrados:");
            foreach (var equipo in ListaEquipos)
            {
                Console.WriteLine($"{enumeracion} {equipo.Nombre}");
                enumeracion++;
            }
        }

        // Añadir jugadores a la lista
        public void AgregarJugador(Jugador jugador)
        {
            Jugadores.Add(jugador);
        }

        // Mostrar los jugadores de la lista
        public void ListarJugadores()
        {
            Console.WriteLine($"\nJugadores del equipo {Nombre}:");

            if (Jugadores.Count == 0)
            {
                Console.WriteLine("No hay jugadores en este equipo.");
                return;
            }

            foreach (var jugador in Jugadores)
            {
                Console.WriteLine($"- {jugador.Nombre} ({jugador.Posicion}, {jugador.Edad} años)");
            }
        }
    }
}
