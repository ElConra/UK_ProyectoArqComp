using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArqComp
{
    public class Sincrono
    {

        public Sincrono(string palabra)
        {

            Stopwatch sincrono = new Stopwatch();
            Console.WriteLine("Iniciando proceso sincrono....");
            Console.WriteLine("Contador iniciado: " + sincrono.Elapsed);
            sincrono.Start();
            //Iniciando las subcadenas
            for (int i = 0; i < palabra.Length; i++)
            {
                for (int j = 1; j <= palabra.Length - i; j++)
                {
                    palabra.Substring(i, j);
                }
            }

            sincrono.Stop();
            Console.WriteLine("Tiempo total transcurrido: " + sincrono.Elapsed);
            Console.WriteLine("Proceso sincrono terminado.....");

        }
    }
}
