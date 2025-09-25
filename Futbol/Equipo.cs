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
            if (ListaEquipos.Count == 0)
            {
                Console.WriteLine("No hay equipos registrados.");
                return;
            }

            Console.WriteLine("\nEquipos registrados:");
            foreach (var equipo in ListaEquipos)
            {
                Console.WriteLine($"- {equipo.Nombre}");
            }
        }
    }
}
