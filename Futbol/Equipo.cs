using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol
{
    internal class Equipo
    {
     
        
        public List<Jugador> Jugadores { get; set; } = new List<Jugador>();

        public Equipo() { }

        public string Nombre { get; set; }

        public Equipo(string nombre)
        {
            this.Nombre = nombre;
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

        public static void CrearEquipo()
        {
            string nombre;
            Console.Write("Dime el nombre del equipo: ");
            nombre = Console.ReadLine();

            Equipo nuevoEquipo = new Equipo(nombre);

            Club.AgregarEquipo(nuevoEquipo);
        }
    }
}
