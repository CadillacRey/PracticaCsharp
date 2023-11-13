using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaClase6Consola
{
    public class Cerveza
    {
        //Crear la clase "Cerveza" con las PROPIEDADES "Marca", "precio", "peso" y "procedencia".
        public string Marca { get; set; }
        public int Precio { get; set; }
        public double Peso { get; set; }
        public string Procedencia { get; set; }

        public void Comprar3()
        {
            Console.WriteLine($"\n" +
                $"Cerveza\n" +
                $"Marca:{Marca}\n" +
                $"Valor:${Precio}.- \n" +
                $"Peso:{Peso}Lts.\n" +
                $"Origen:{Procedencia}");
        }

    }
}
