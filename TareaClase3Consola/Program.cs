using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaClase3Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tarea 3 Reynoso. Junte todos los ejercicios en funciones. 
            Console.Beep();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("###################################\n" +
                              "#        TESTING AUTOMATION       #\n" +
                              "###################################");
            Console.WriteLine("\n");
            Console.WriteLine("Elegí el ejercicio que quieras ver");

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("Seleccionando números del (1-6), podes ver los ejercicios o presioná '0' para salir:");
                int opcion = Convert.ToInt32(Console.ReadLine()); //Use Convert.ToInt32 en vez de Parse

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("Nos vemos!, apreta una tecla para salir!");
                        Console.ReadKey();
                        salir = true;
                        break;
                    case 1:
                        Ejercicio1();
                        break;
                    case 2:
                        Ejercicio2();
                        break;
                    case 3:
                        Ejercicio3();
                        break;
                    case 4:
                        Ejercicio4();
                        break;
                    case 5:
                        Ejercicio5();
                        break;
                    case 6:
                        Ejercicio6();
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Ingresá un número del 1 al 6 o 0 para salir.");
                        break;

                }

            }


        }

        static void Ejercicio1()
        {
            Console.WriteLine("Ejercicio 1 - Agregar producto al stock");
            Console.WriteLine("Ingresá el nombre del producto:");

            string nombreProducto = Console.ReadLine();

            Console.WriteLine("Ingresá el precio del producto en enteros:");
            decimal precioProducto = Convert.ToDecimal(Console.ReadLine()); //Voy a usar Convert.ToDecimal en vez de Parse

            Console.WriteLine("Ingresá la cantidad de productos en enteros:");
            int cantidadProductos = Convert.ToInt32(Console.ReadLine()); //Voy a usar Convert.ToInt32 en vez de Parse

            Console.WriteLine("Producto ingresado:");
            Console.WriteLine("Nombre: " + nombreProducto);
            Console.WriteLine("Precio: $" + precioProducto.ToString("0.00"));
            Console.WriteLine("Cantidad: " + cantidadProductos);
        }

        static void Ejercicio2()
        {
            Console.WriteLine("Ejercicio 2 - Cotización de dólares a pesos");

            decimal cotizacionDolar = 720;
            Console.WriteLine("Ingresá la cantidad de dólares a cotizar:");
            decimal cantidadDolares = Convert.ToDecimal(Console.ReadLine());

            decimal cotizacionEnPesos = cotizacionDolar * cantidadDolares;

            Console.WriteLine("Cotización en pesos: $" + cotizacionEnPesos.ToString("0.00"));
        }

        static void Ejercicio3()
        {
            Console.WriteLine("Ejercicio 3 - Cálculo del precio total de compra de cerveza");

            string producto = "Cerveza Pilsen Gold";
            decimal precioUnitario = 500;

            Console.WriteLine("Producto deseado: " + producto);
            Console.WriteLine("Precio unitario: $" + precioUnitario.ToString("0.00"));

            Console.WriteLine("Ingresá la cantidad de unidades a comprar:");
            int cantidadUnidades = Convert.ToInt32(Console.ReadLine());

            decimal precioTotal = precioUnitario * cantidadUnidades;

            Console.WriteLine("Precio total de la compra: $" + precioTotal.ToString("0.00"));
        }

        static void Ejercicio4()
        {
            Console.WriteLine("Ejercicio 4 - Cálculo del vuelto al realizar un pago");

            Console.WriteLine("Ingresá el precio total de la compra:");
            decimal precioTotal = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingresá la cantidad que desea abonar:");
            decimal cantidadAbonar = Convert.ToDecimal(Console.ReadLine());

            decimal vuelto = cantidadAbonar - precioTotal;

            Console.WriteLine("Vuelto a obtener: $" + vuelto.ToString("0.00"));
        }

        static void Ejercicio5()
        {
            Console.WriteLine("Ejercicio 5 - Cálculo del costo total con envío a domicilio");

            decimal costoEnvio = 2000;
            Console.WriteLine("Ingresá el precio de la compra:");
            decimal precioCompra = Convert.ToDecimal(Console.ReadLine());

            decimal costoTotal = costoEnvio + precioCompra;

            Console.WriteLine("Costo total (incluyendo envío): $" + costoTotal.ToString("0.00"));
        }

        static void Ejercicio6()
        {
            Console.WriteLine("Ejercicio 6 - Operaciones con 3 valores");

            Console.WriteLine("Ingresá el primer valor:");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresá el segundo valor:");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresá el tercer valor:");
            double valor3 = Convert.ToDouble(Console.ReadLine());

            double suma = valor1 + valor2 + valor3;
            double resta = valor1 - valor3;
            double multiplicacion = valor1 * valor2;
            double division = valor1 / valor2;
            double resto = valor2 % valor3;

            Console.WriteLine("Suma de los 3 valores: " + suma);
            Console.WriteLine("Resta del primer y tercer número: " + resta);
            Console.WriteLine("Multiplicación del primer y segundo número: " + multiplicacion);
            Console.WriteLine("División del primer y segundo número: " + division);
            Console.WriteLine("Resto de la división entre el segundo y tercer número: " + resto);
        }
    }
}
