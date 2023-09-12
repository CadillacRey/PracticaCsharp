using System;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



namespace SupuestaIA
{
    class ProgramaDeBroma
    {
        static void AltaSocio()  //Metodo de validacion de Socio 
        {
            //...Ingresar y validar datos anteriores
            Console.WriteLine("Ingrese su cuenta de correo:");
            string login = Console.ReadLine();
            //...Ingresar y validar datos siguientes

            if (Regex.IsMatch(login, @"reynosoemanuel04@gmail.com", RegexOptions.IgnoreCase))

            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("BIENVENIDO");
                Console.WriteLine("      INGRESO AUTORIZADO");
                Console.WriteLine("      IPADRESS:198.200.0.0");
                Console.WriteLine("      COUNTRY:ARGENTINA");
                Console.WriteLine("  LANGUAGE PACKAGE:SPANISH LATAM");
            }



            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("      INGRESO NO AUTORIZADO");
                Console.WriteLine("      IPADRESS:198.200.0.0");
                Console.WriteLine("      COUNTRY:ARGENTINA");
                Console.WriteLine("  LANGUAGE PACKAGE:SPANISH LATAM");
            }

        }
        static void Main(string[] args)
        {




            //Console.WriteLine(DateTime.Now.DayOfWeek);
            //int diaDeSemana =  (int) DateTime.Now.DayOfWeek;

            int sleepTime = 3000;
            int loadingTime = 500;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("************************");
            Console.WriteLine("****** MAIN SYSTEM *****");
            Console.WriteLine("************************");

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("      Login:");
            //aca quiero validar un login...
            {
                AltaSocio();
            }

            for (int i = 0; i < 5; i++)
            {
                Task.Delay(loadingTime).Wait();
                Console.Write("#");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Soy una IA, diseñada para contestar cualquier pregunta...");
            Task.Delay(sleepTime).Wait();
            Console.WriteLine(" ");
            Console.WriteLine("Si quieres saber algún secreto del mundo, pídemelo ahora,");
            Task.Delay(sleepTime).Wait();
            Console.WriteLine("Bloquearé tu sesion, después de la misma...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            Task.Delay(sleepTime).Wait();
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Voy a consultar en mi base de datos...");
            Task.Delay(sleepTime).Wait();
            Console.WriteLine(" ");
            Console.Write("Cargando Base de Datos ");

            for (int i = 0; i < 10; i++)
            {
                Task.Delay(loadingTime).Wait();
                Console.Write("#");

            }
            Console.WriteLine(" ");

            Console.WriteLine("Emanuel Reynoso, de la banda Anima loqui...");
            Task.Delay(sleepTime).Wait();
            Console.WriteLine("La tiene muy parada ese muchacho.");
            Task.Delay(sleepTime).Wait();
            Console.WriteLine(" ");

            Console.WriteLine("Disconnect System.");
            Console.WriteLine(" ");
            Console.WriteLine("Tracing Complete... ");

            for (int i = 0; i < 10; i++)
            {
                Task.Delay(loadingTime).Wait();
                Console.Write("#");

            }
            Console.WriteLine("");

            Console.ReadKey();


        }


    }

}



