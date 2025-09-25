using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Futbol
{
    internal static class Fichero
    {
        private static readonly string rutaArchivo = "datos.json";

        public static void GuardarDatos()
        {
            var opciones = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(Club.ListaEquipos, opciones);
            File.WriteAllText("datos.json", json);
        }

        public static void CargarDatos()
        {
            if (!File.Exists(rutaArchivo))
                return;

            string json = File.ReadAllText(rutaArchivo);

            var equipos = JsonSerializer.Deserialize<List<Equipo>>(json);

            if (equipos != null)
            {
                Club.ListaEquipos.Clear();
                Club.ListaEquipos.AddRange(equipos);
            }
        }
    }
}

