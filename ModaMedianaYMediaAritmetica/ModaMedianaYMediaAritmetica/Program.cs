using System;

namespace ModaMedianaYMediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arregloModa = new int[] { 19, 8, 29, 35, 19, 28, 15,19 };

            int[] listadoArregloModa = new int[arregloModa.Length];

            Array.Sort(arregloModa);

   

            for (int i = 0; i < arregloModa.Length; i++)
            {
                int contadorModa = 0;

                for (int j = 0; j < arregloModa.Length; j++)
                {
                    if (arregloModa[i] == arregloModa[j])
                    {
                        contadorModa++;
                        if (numero(arregloModa[i]))
                        {
                            listadoArregloModa[i] = arregloModa[i];
                        }
                    }
                }
                if (listadoArregloModa[i] != 0)
                {
                    Console.WriteLine(listadoArregloModa[i] + " Aparece: " + contadorModa);
                }
            }
            bool numero(int num)
            {
                for (int i = 0; i < listadoArregloModa.Length; i++)
                {
                    if (listadoArregloModa[i] == num)
                    {
                        return false;
                    }
                }
                return true;
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}
