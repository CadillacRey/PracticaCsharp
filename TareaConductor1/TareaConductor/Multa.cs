using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaConductor
{
    public class Multa
    {
        public string Descripcion { get; set; }
        public int Monto { get; set; }


        public Multa(string descripcion, int monto)
        {
            Descripcion = descripcion;
            Monto = monto;
        }


    }

}
