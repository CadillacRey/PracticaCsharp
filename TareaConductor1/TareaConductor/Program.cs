using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaConductor
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Creo Auto
            //Creo los conductores

            Auto auto1 = new Auto("Ferrari", "Gallardo", "AA123CB");
            Auto auto2 = new Auto("Lamborgini", "Diablo", "AA123DE");


            Conductor conductor1 = new Conductor("Emanuel", "Reynoso",  auto1);
            Conductor conductor2 = new Conductor("Sergio", "Gomez", auto2);


            //Creo Multas 

            Multa multa1 = new Multa("Semaforo en rojo", 50000); 
            Multa multa2 = new Multa("Exceso de velocidad", 100000);
            Multa multa3 = new Multa("Alcoholemia", 1000000);
            Multa multa4 = new Multa("Contramano", 30000);


            conductor1.Multas.Add(multa1);//0
            conductor1.Multas.Add(multa4);//1
            conductor1.Multas.Add(multa1);//2

            conductor2.Multas.Add(multa3);//0
            conductor2.Multas.Add(multa4);//1
            conductor2.Multas.Add(multa2);//2

            Console.WriteLine($"El Conductor {conductor1.Nombre} {conductor1.Apellido} tiene una multa por:\n" +
                $"{conductor1.Multas[0].Descripcion} {conductor1.Multas[0].Monto} {conductor1.Multas[1].Descripcion} {conductor1.Multas[1].Monto}");

            Console.WriteLine($"El Conductor {conductor2.Nombre} {conductor2.Apellido} tiene una multa por:\n" +
                $"{conductor2.Multas[0].Descripcion} {conductor2.Multas[1].Monto}" );


        }
    }
}
