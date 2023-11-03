using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telemetria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                EscritorLogPantalla escritor = new EscritorLogPantalla();
                EscritorLogAArchivo escritorArchivo = new EscritorLogAArchivo();
                Console.WriteLine("Ingrese los datos");
                var lectura= Console.ReadLine();
                escritor.InformarAcceso(DateTime.Now);
            }
        }
    }
}
