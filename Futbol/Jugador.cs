using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol
{
    internal class Jugador
    {
        private string _nombre;
        private int _edad;
        private string _posicion;

        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Posicion { get; set; }

        public Jugador()
        {
            this.Nombre = _nombre;
            this.Edad = _edad;
            this.Posicion = _posicion;
        }


    }
}
