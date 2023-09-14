using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingClase2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("###################################\n" +
                              "#      * TESTING AUTOMATION *     #\n" +
                              "###################################");

            //int primerNumero = int.Parse(Console.ReadLine()); //asi se parsea
            Console.WriteLine("Ingresa un numero"); //Aca pido 2 nums por entrada y los sumo a la función
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Suma(num1, num2));
            Suma(23, 56);
            Console.WriteLine(Suma(num1, num2));
            BuenoAdios();
            

            Console.ReadKey();

        }

        public static void BuenoAdios()//Metodo de Saludar
        {
            Console.WriteLine("Bueno nos vemo' en Disney");
        }

        public static int Suma(int num1, int num2)
        {
            int sumaTotal= num1 + num2;
            return sumaTotal;

        }

        

        
    }
}
