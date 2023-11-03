using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telemetria
{
    public class Pantalla
    {
        public void EscribirEnPantalla(DateTime tiempo)
        {
            Console.WriteLine($"El tiempo en milisengundos: {tiempo}");
        }
    }
}
