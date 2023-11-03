// Importación de bibliotecas necesarias
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaConductor
{
    public class Program
    {
        // Método principal del programa
        static void Main(string[] args)
        {
            // Creación de objetos de la clase Auto
            Auto auto1 = new Auto("Ferrari", "Gallardo", "AA123BC");
            Auto auto2 = new Auto("Lamborghini", "Diablo", "AA123DE");

            // Creación de objetos de la clase Conductor
            Conductor conductor1 = new Conductor("Emanuel", "Reynoso", auto1);
            Conductor conductor2 = new Conductor("Sergio", "Gomez", auto2);

            // Creación de objetos de la clase Multa
            Multa multa1 = new Multa("Semaforo en rojo", 50000);
            Multa multa2 = new Multa("Exceso de velocidad", 100000);
            Multa multa3 = new Multa("Alcoholemia", 1000000);
            Multa multa4 = new Multa("Contramano", 30000);

            // Asignación de multas a los conductores
            conductor1.Multas.Add(multa1); // Agrega multa1 a las multas de conductor1
            conductor1.Multas.Add(multa4); // Agrega multa4 a las multas de conductor1
            conductor1.Multas.Add(multa1); // Agrega otra multa1 a las multas de conductor1

            conductor2.Multas.Add(multa3); // Agrega multa3 a las multas de conductor2
            conductor2.Multas.Add(multa4); // Agrega multa4 a las multas de conductor2
            conductor2.Multas.Add(multa2); // Agrega multa2 a las multas de conductor2

            // Muestra información sobre las multas de los conductores
            Console.WriteLine($"El Conductor {conductor1.Nombre} {conductor1.Apellido} tiene multas por:\n" +
                $"{conductor1.Multas[0].Descripcion} ({conductor1.Multas[0].Monto})\n" +
                $"{conductor1.Multas[1].Descripcion} ({conductor1.Multas[1].Monto})");

            Console.WriteLine($"El Conductor {conductor2.Nombre} {conductor2.Apellido} tiene multas por:\n" +
                $"{conductor2.Multas[0].Descripcion} ({conductor2.Multas[0].Monto})\n" +
                $"{conductor2.Multas[2].Descripcion} ({conductor2.Multas[2].Monto})");
        }
    }
}

