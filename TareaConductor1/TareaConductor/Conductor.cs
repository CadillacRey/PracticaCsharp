// Importación de bibliotecas necesarias
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TareaConductor
{
    // Definición de la clase Conductor
    public class Conductor
    {
        // Propiedades de la clase Conductor
        public string Nombre { get; set; }         // Propiedad para almacenar el nombre del conductor
        public string Apellido { get; set; }       // Propiedad para almacenar el apellido del conductor
        public Auto AutoAsignado { get; set; }     // Propiedad para almacenar un objeto de la clase Auto asignado al conductor
        public List<Multa> Multas { get; set; }    // Propiedad para almacenar una lista de objetos de la clase Multa asociadas al conductor

        // Constructor de la clase Conductor
        public Conductor(string nombre, string apellido, Auto autoAsignado)
        {
            // Inicializa las propiedades con los valores proporcionados
            Nombre = nombre;
            Apellido = apellido;
            AutoAsignado = autoAsignado;

            // Inicializa la lista de multas como una lista vacía
            Multas = new List<Multa>();
        }
    }
}
