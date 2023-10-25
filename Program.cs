using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10_prob01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear(); // Limpia la pantalla
                Console.WriteLine("================================");
                Console.WriteLine("Productos de mPhone");
                Console.WriteLine("================================");
                Console.WriteLine("1: Ventas de mPhone 3000");
                Console.WriteLine("2: Ventas de mPad 3500");
                Console.WriteLine("3: Ventas de MAPBrook 3800");
                Console.WriteLine("4: Ventas de mWatch 8000");
                Console.WriteLine("5: Salir");
                Console.WriteLine("================================");
                Console.Write("Ingrese una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Seleccionaste Ventas de mPhone 3000");
                            // Aquí puedes agregar la lógica para gestionar las ventas de mPhone 3000
                            break;
                        case 2:
                            Console.WriteLine("Seleccionaste Ventas de mPad 3500");
                            // Agrega la lógica para gestionar las ventas de mPad 3500
                            break;
                        case 3:
                            Console.WriteLine("Seleccionaste Ventas de MAPBrook 3800");
                            // Agrega la lógica para gestionar las ventas de MAPBrook 3800
                            break;
                        case 4:
                            Console.WriteLine("Seleccionaste Ventas de mWatch 8000");
                            // Agrega la lógica para gestionar las ventas de mWatch 8000
                            break;
                        case 5:
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                }

                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 5);
        }
    }


}
    

