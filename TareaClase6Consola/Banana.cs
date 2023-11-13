using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaClase6Consola
{
    public class Banana
    {
        //Crear la clase "Banana" con las PROPIEDADES "Marca", "Precio", "Peso" y "Procedencia".
        public string Marca { get; set; }
        public int Precio {  get; set; }
        public double Peso { get; set; } 
        public string Procedencia { get; set; }

        public void Comprar2()
        {
            Console.WriteLine($"\n" +
                $"Bananas\n" +
                $"Marca:{Marca}\n" +
                $"Valor:${Precio}.- \n" +
                $"Peso:{Peso}Kg.\n" +
                $"Origen:{Procedencia}");
        }

    }
}
