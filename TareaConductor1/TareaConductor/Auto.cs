using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaConductor
{
    public class Auto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public string Patente { get; set; }

        public Auto (string marca, string modelo, string patente)
        {
            Marca = marca;
            Modelo = modelo;
            Patente = patente;

        }
    

    }
}
