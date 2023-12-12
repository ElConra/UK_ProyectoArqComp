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

            //Explicando el proyecto
            Console.WriteLine("Obteniendo todas las subcadenas de una palabra");
            Console.WriteLine("Esto se hara de manera síncrona o en paralelo");
            Console.WriteLine("El tiempo que se mostrara es en milisegundos");
            Console.Write("Escribe tu palabra: ");
            palabra = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();
            new Sincrono(palabra);
            Console.WriteLine();
            Console.WriteLine();
            new Paralelo(palabra);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Lo que hizo el programa fue lo siguiente:");
            for (int i = 0; i < palabra.Length; i++)
            {
                for (int j = 1; j <= palabra.Length - i; j++)
                {
                    Console.WriteLine(palabra.Substring(i, j));
                }
            }



            Console.ReadKey();


        }



    }

}


