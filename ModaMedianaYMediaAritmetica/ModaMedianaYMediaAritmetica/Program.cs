using System;

namespace ModaMedianaYMediaAritmetica
{
    class Program
    {
        public static void Moda()
        {
            int[] arregloModa = new int[] { 19, 8, 29, 35, 19, 28, 15, 19 };

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
        
        public static void Mediana()
        {
            int[] arregloMediana = new int[] { 2, 5, 8, 11, 16, 21, 30 };
            int mediana;
            int promedioMediana = arregloMediana.Length / 2;

            Array.Sort(arregloMediana);

            for (int i = 0; i < arregloMediana.Length; i++)
            {
                Console.WriteLine("Los valores son: {0}", arregloMediana[i]);
                Console.WriteLine("");
            }

            if (arregloMediana.Length % 2 == 0)
            {
                mediana = (arregloMediana[promedioMediana - 1] + arregloMediana[promedioMediana]) / 2;

                Console.WriteLine("La Mediana es: {0}", mediana);
            }
            else
            {
                mediana = arregloMediana[promedioMediana];
                Console.WriteLine("La Mediana es: {0}",mediana);
            }

            Console.ReadKey();
            Console.Clear();
        }

        public static void MediaAritmetica()
        {
            int[] arregloMediaAritmetica = new int[] { 2, 5, 5, 6, 8, 8, 9, 11 };

            int cantidadNumeros = arregloMediaAritmetica.Length;

            decimal sumaMediaAritmetica = 0;
            for (int i = 0; i < arregloMediaAritmetica.Length; i++)
            {
                sumaMediaAritmetica += arregloMediaAritmetica[i];
                Console.WriteLine("Encuentre la Media del conjunto: {0}", arregloMediaAritmetica[i]);
            }

            Console.WriteLine("La Sumatoria es: {0}", sumaMediaAritmetica);
            Console.WriteLine("La Cantidad de numeros son: {0}", cantidadNumeros);
            Console.WriteLine("La Media Aritmetica es: {0}", sumaMediaAritmetica / cantidadNumeros);

            Console.ReadKey();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            //Moda();
            //Mediana();
            MediaAritmetica();
        }
    }
}
