using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingClase4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loadingTime = 500;
            Console.Beep();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("###################################\n" +
                              "#      * TESTING AUTOMATION *     #\n" +
                              "###################################");
            
            Task.Delay(loadingTime).Wait();

            //Barra Falsa de Carga ####
            for (int t = 0; t < 10; t++)
            {
                Task.Delay(loadingTime).Wait();
                Console.Write("#");

            }


            //Variables para el For  
            int cantDeVeces = 10;
            int phor = 7;
            int i = 0;
            int resultado;
            
            //Ejemplo de for 
            for (i = 0; i <=cantDeVeces; i++) //no se pone punto y coma aca
            {
                resultado = phor * i;
                Console.WriteLine("Hola");

            }

            Console.ReadKey();

            //Ejemplo de While
            int guail = 0;
            while (guail !=5) //no se pone punto y coma aca
            {
                Console.Clear();
                Console.WriteLine("Ingresa un numero si es 5 se termina el programa");
                guail=int.Parse(Console.ReadLine());


            }

            #region Operadores en comentarios

            /*
             * OPERADORES DE COMPARACIÓN
             * < MENOR 
             * > MAYOR
             * == IGUAL 
             * != DISTINTO
             * <= MENOR IGUAL
             * >= MAYOR IGUAL
             */

            //Console.WriteLine

            #endregion

            //Ejemplo de Switch Case
            Console.WriteLine("Ingresa un numero entero para saber que hace Switch");
            int suitch = int.Parse(Console.ReadLine()); 

            switch (suitch) //Tampoco en el Switch
            {
                case 0: Console.WriteLine("Vamo boquita lpm");
                    break;
                    case 1: Console.WriteLine("Fuck");
                    break;
                    case 2: Console.WriteLine("Fuck you");
                    break;
                    case 3: Console.WriteLine("MotherFucker");
                    break;
                    case 4: Console.WriteLine("Adios perdedor");
                    //salir = true;   //Se puede cambiar la variable 
                    break;

                    default: Console.WriteLine("Nada de poner otro que no sea Boca");
                    break;

            }

            Console.ReadKey();

            #region Operadores Logicos
            //Operadores Logicos
            //&& AND, = Y en Español
            //|| OR = O en Español 
            // ! NOT = No en Español 
            #endregion





        }

    }


}
