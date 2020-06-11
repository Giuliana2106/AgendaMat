using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrices_2
{
    class Program
    {
        static string[,] agenda = new string[10, 10];
        static void Main(string[] args)
        {
            string usuario = "contacto no encontrado";
            string nuevo = "ingrese nuevo contacto";
            string buscar = "";


            for(int f=0;f<10;f++)
            {
                Console.Write("Ingrese nombre: ");
                agenda[0, f] = Console.ReadLine();

                Console.Write("Ingrese apellido: ");
                agenda[1, f] = Console.ReadLine();

                Console.Write("Ingrese dirección: ");
                agenda[2, f] = Console.ReadLine();

                Console.Write("Ingrese teléfono: ");
                agenda[3, f] = Console.ReadLine();

            }
            Console.WriteLine("----------------------------------------\n");
            for(int f=0;f<10;f++)
            {
                Console.WriteLine(agenda[0, f] + "--" +agenda[1, f] + "--" +agenda[2, f] + "--" +agenda[3, f]);
            }
            Console.WriteLine("-----------------------------------------\n");

            Console.Write("ingrese el nombre del nuevo contacto: ");
            nuevo = Console.ReadLine();
            for(int f=0;f<10;f++)
            {
                if (nuevo==[0,f])
                {
                    usuario = agenda[0, f] + "--" + agenda[1, f] + "--" + agenda[2, f] + "--" + agenda[3, f];
                }
                else
                {
                    Console.Write("Ingrese nombre: ");
                    agenda[0, f] = Console.ReadLine();

                    Console.Write("Ingrese apellido: ");
                    agenda[1, f] = Console.ReadLine();

                    Console.Write("Ingrese dirección: ");
                    agenda[2, f] = Console.ReadLine();

                    Console.Write("Ingrese teléfono: ");
                    agenda[3, f] = Console.ReadLine();
                }
                Console.Write("------------------------------------------\n");
            }

            Console.Write("ingrese el nombre del contacto a buscar: ");
            for(int f=0;f<10;f++)
            {
                if (buscar==[0, f])
                {
                    usuario = agenda[0, f] + "--" + agenda[1, f] + "--" + agenda[2, f] + "--" + agenda[3, f];
                }
            }

            Console.WriteLine(usuario);

            Console.ReadKey();
        }

    }
}
