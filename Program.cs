using System;
using System.Diagnostics;
using System.Threading;

namespace OdenamientoBusqueda_G2_2024_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] A = { 5, 7, 1, 3, 12, 20, 8 };
            int[] A = { 1, 3, 5 , 7,8 , 12, 20 };
            int X = 50;
           // int i = Busqueda.Lineal(A, X);
            int i = Busqueda.Binaria(A,0,A.Length,X);
            if( i != -1 )
            {
                Console.WriteLine("El valor {0} está en la posición : {1}", X, i);

            }
            else
            {
                Console.WriteLine("Número no encontrado");
            }



            //Stopwatch stopwatch = new Stopwatch();

            //  int[] A = Ordenamiento.Generar(10);

            // Console.WriteLine("******* Matriz Original *******");
            //  Ordenamiento.Imprime(A);
            // Midiendo tiempo de ejecución
            //stopwatch.Start();
            //Ordenamiento.Burbuja(A);
            //stopwatch.Stop();
            // Console.WriteLine(" \n ********Matriz Ordenada*******");
            // Ordenamiento.Imprime(A);

            //Console.WriteLine("Tiempo de ejecución del ordenamiento {0} [ms] ",stopwatch.ElapsedMilliseconds);

            Console.ReadLine();



        }
    }
}
