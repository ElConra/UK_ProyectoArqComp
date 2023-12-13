using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArqComp
{
    public class Paralelo
    {

        public Paralelo(string palabra)
        {
            Stopwatch paralelo = new Stopwatch();
            Console.WriteLine("Iniciando proceso paralelo....");
            Console.WriteLine("Contador iniciado: " + paralelo.Elapsed);
            paralelo.Start();


            Parallel.For(0, palabra.Length, i =>
                {
                    Parallel.For(1, palabra.Length - i, j =>
                    {
                        palabra.Substring(i, j);
                    });
                });
            paralelo.Stop();
            Console.WriteLine("Tiempo total transcurrido: " + paralelo.Elapsed);
            Console.WriteLine("Terminando proceso paralelo....");

        }
    }
}
