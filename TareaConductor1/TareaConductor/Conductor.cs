using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TareaConductor
{
    public class Conductor
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Auto AutoAsignado { get; set; }

        public List<Multa> Multas { get; set; } 



        public Conductor (string nombre, string apellido, Auto autoAsignado)
        {
            Nombre = nombre;

            Apellido = apellido;

            AutoAsignado = autoAsignado;

            Multas = new List<Multa> ();

            

            
        }
    }
}
