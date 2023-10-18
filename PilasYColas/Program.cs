using Practica_Pilas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasYColas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("****************      Practica de pilas      **************");
            Console.WriteLine("***********************************************************");
            PilaLigada pilaNueva = new PilaLigada();
            int n;
            do
            {
                Console.WriteLine("\n1) Agregar \n2) Sacar \n3) Ver Elemento de encima \n4) Imprimir la pila \n5) Buscar \n6) Salir \n\n Tu opcion");
                n = Convert.ToInt16(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("\n Ingresa el elemento:");
                        pilaNueva.Agrega(Console.ReadLine()!);
                        break;
                    case 2:
                        Console.WriteLine("\nEl elemento extraido es: " + pilaNueva.Retira() + "\n");
                        break;
                    case 3:
                        Console.WriteLine("\nEl elemento superio es: " + pilaNueva.Tope() + "\n");
                        break;
                    case 4:
                        pilaNueva.Imprime();
                        break;
                    case 5:
                        object dato;
                        Console.WriteLine("\n Ingresa el dato que deseas buscar: ");
                        dato = Console.ReadLine()!;
                        if (pilaNueva.busqueda(dato)) Console.WriteLine("El elemento esta en la Pila");
                        else Console.WriteLine("El elemento no esta en la pila");
                        break;
                    case 6:
                        break;
                    default: break;
                }

            } while (n != 6);
        }
    }
}
