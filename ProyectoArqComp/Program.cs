using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArqComp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string palabra;
            Stopwatch sincrono = new Stopwatch();
            Stopwatch paralelo = new Stopwatch();

            //Explicando el proyecto
            Console.WriteLine("Obteniendo todas las subcadenas de una palabra");
            Console.WriteLine("Esto se hara de manera síncrona o en paralelo");
            Console.WriteLine("El tiempo que se mostrara es en milisegundos");
            Console.Write("Escribe tu palabra: ");
            palabra = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //Empezando sincrono
            Console.WriteLine("Iniciando ejemplo síncrono......");
            Console.WriteLine("Iniciando ejemplo síncrono......");
            Console.WriteLine("Iniciando ejemplo síncrono......");

            sincrono.Start();
            
            
            

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //Empezando paralelo
            Console.WriteLine("Iniciando ejemplo paralelo......");
            Console.WriteLine("Iniciando ejemplo paralelo......");
            Console.WriteLine("Iniciando ejemplo paralelo......");

            paralelo.Start();

            Parallel.For(0, palabra.Length, i =>
            {
                for (int j = 1; j <= palabra.Length - i; j++)
                {
                    Console.WriteLine(palabra.Substring(i, j) + "   Obtenido en:  " + paralelo.Elapsed);
                }
            });
            paralelo.Stop();
            Console.WriteLine("Tiempo total transcurrido: " + paralelo.Elapsed);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Tiempo total en sincrono: " + sincrono.Elapsed);
            Console.WriteLine("Tiempo total en paralelo: " + paralelo.Elapsed);
            Console.ReadKey();


        }



    }

}


