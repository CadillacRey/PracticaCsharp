using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TareaClase5_1Consola
{
    public class Program
    {

        static void Main()
        {
            Console.WriteLine("Ingrese un año entre 1978 y el actual para conocer el equipo ganador del Mundial de fútbol:");

            while (true)
            {
                Console.Write("Año: ");
                if (int.TryParse(Console.ReadLine(), out int year))
                {
                    if (year < 1978 || year > DateTime.Now.Year)
                    {
                        Console.WriteLine("Ingrese un año válido entre 1978 y el actual.");
                    }
                    else
                    {
                        string equipoGanador = ObtenerEquipoGanadorMundial(year);
                        if (equipoGanador != null)
                        {
                            Console.WriteLine($"En el año {year}, el equipo ganador del Mundial de fútbol fue: {equipoGanador}");
                        }
                        else
                        {
                            Console.WriteLine($"No se disputó un Mundial de fútbol en el año {year}.");
                        }
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese un año válido.");
                }
            }
        }

        static string ObtenerEquipoGanadorMundial(int year)
        {
            // Puedes agregar lógica para obtener el equipo ganador del Mundial de fútbol para cada año.
            // Aquí se muestra un ejemplo simple con algunos años específicos.
            switch (year)
            {
                case 1978:
                    return "Argentina";
                case 1982:
                    return "Italia";
                case 1986:
                    return "Argentina";
                // Agrega más casos según sea necesario para años adicionales.
                default:
                    return null; // Retornar null si no hay información para ese año.
            }
        }
    }




}



