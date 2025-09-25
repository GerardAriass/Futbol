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

        public string Nombre { get; set; }

        public static List<Equipo> ListaEquipos { get; private set; } = new List<Equipo>();

        public Equipo()
        {
            this.Nombre = _nombre;
        }

        public static void AgregarEquipo(Equipo equipo)
        {
            ListaEquipos.Add(equipo);
        }
    }
}
