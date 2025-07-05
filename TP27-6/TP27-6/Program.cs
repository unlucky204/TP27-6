using System;
using System.Collections.Generic;
using System.Linq;

namespace TP27_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double VecesRepetidas = 0;
            Console.WriteLine("ingrese las repes");
            int Rep = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el tamaño del grupo");
            int Cant = int.Parse(Console.ReadLine());
            List<int> lista; 
            for (int r = 0; r <= Rep; r++)
            {
                lista = new List<int>();
                bool repetido = false;
                for (int j = 0; j < Cant; j++)
                {
                    lista.Add(ObtenerNumRandom());
                }
                for (int j = 0; j < Cant; j++)
                {
                    for (int k = 0; k < Cant; k++)
                    {
                        if (lista.ElementAt(j) == lista.ElementAt(k) && j != k && repetido != true)
                        {
                                VecesRepetidas++;
                                repetido = true;
                        }
                    }
                }
            }
            Console.WriteLine($@"Veces repetidas:{VecesRepetidas}/repeticiones:{Rep} = {VecesRepetidas/Rep}. En un grupo de {Cant} personas");

        }
        static int ObtenerNumRandom()
        {
            Random random = new Random();
            int NumeroRandom = random.Next(1, 365);
            return NumeroRandom;
        }
    }
}
