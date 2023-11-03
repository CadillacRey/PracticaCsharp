using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telemetria
{
    public class EscritorLogPantalla : ITelemetria
    {
        public void InformarAcceso(DateTime tiempo)
        {
            Pantalla pantalla = new Pantalla(); 
            Console.WriteLine(tiempo.Millisecond);
            
        }

    }
}
