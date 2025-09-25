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
        private int _cantidad;

        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        public Equipo()
        {
            this.Nombre = _nombre;
            this.Cantidad = _cantidad;
        }
    }
}
