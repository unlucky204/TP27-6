using System;

namespace TP27_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int i2 = 0;
            int i3 = 0;
            int NumRep = 0;
            double VecesRepetidas = 0;
            bool repetido = false;
            int[] lista = new int[30];
            for (int r = 0; r <= 10000; r++)
            {
                repetido = false;
                for (int j = 0; j < 30; j++)
                {
                    lista[j] = ObtenerNumRandom();
                }
                for (int j = 0; j < 30; j++)
                {
                    for (int k = 0; k < 30; k++)
                    {
                        if (lista[i] == lista[i2] && i != i2)
                        {
                            if (repetido == false)
                            {
                                VecesRepetidas++;
                                repetido = true;
                            }
                            NumRep = lista[i];
                        }
                        if (i2 < 29)
                        {
                            i2++;
                        }
                        else
                            i2 = 0;
                    }
                    if (i < 29)
                    {
                        i++;
                    }
                    else
                        i = 0;
                }
            }
            Console.WriteLine($@"Veces repetidas:{VecesRepetidas}/repeticiones:10000 = {VecesRepetidas/10000}");

        }
        static int ObtenerNumRandom()
        {
            
            Random random = new Random();
            int NumeroRandom = random.Next(1, 365);
            return NumeroRandom;
        }
    }
}
