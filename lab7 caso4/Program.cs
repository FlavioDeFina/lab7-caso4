using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_caso4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero de lineas: ");
            int lineas = int.Parse(Console.ReadLine());

            for (int i = 0; i < lineas; i++) 
            {
                Console.Write("Ingresa un numero: ");
                int num = int.Parse(Console.ReadLine());

                for (int j =0; j < num; j++) 
                {
                    for (int k = 0; k < num*2; k++) 
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
