using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol
{
    internal class Club
    {
        public static List<Equipo> ListaEquipos { get; private set; } = new List<Equipo>();

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
    }
}
