using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc;
            string palabra;
            Stopwatch tiempo = new Stopwatch();

            Console.WriteLine("Obteniendo todas las subcadenas de una palabra");
            Console.WriteLine("Iniciando ejemplo síncrono......");
            Console.WriteLine("Iniciando ejemplo síncrono......");
            Console.WriteLine("Iniciando ejemplo síncrono......");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Escribe tu palabra: ");
            palabra = Console.ReadLine();


            tiempo.Start();

            for (int i = 0; i < palabra.Length; i++)
            {
                for (int j = 1; j <= palabra.Length - i; j++)
                {
                    Console.WriteLine(palabra.Substring(i, j) + "   Obtenido en:  " + tiempo.Elapsed);
                }
            }
            tiempo.Stop();
            Console.WriteLine("Tiempo total transcurrido: " + tiempo.Elapsed);
            Console.ReadKey();
        }
    }
}
