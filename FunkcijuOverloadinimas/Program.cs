using System;

namespace FunkcijuOverloadinimas // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kr1 = 5;
            int kr2 = 20;
            int plotas1 = StaciakampioPlotas(kr1, kr2);
            Console.WriteLine(plotas1);


            Console.WriteLine(StaciakampioPlotas(5.76, 3.47));

        }

        /// <summary>
        /// Funkcija apskaičiuoja stačiakampio plotą.
        /// </summary>
        /// <param name="a">Pirmos kraštinės ilgis</param>
        /// <param name="b">Antros kraštinės ilgis</param>
        /// <returns>Funkcija grąžina sveiką (int) skaičių - stačiakampio plotą.</returns>
        static int StaciakampioPlotas(int a, int b)
        {
            int plotas = a * b;
            return plotas;
        }



        /// <summary>
        /// Overloadinta stačiakampio ploto apskaičiavimo funkcija
        /// </summary>
        /// <param name="a">Pirmos kraštinės ilgis</param>
        /// <param name="b">Antros kraštinės ilgis</param>
        /// <returns>Funkcija grąžina realųjų (double) skaičių - stačiakampio plotą. </returns>
        static double StaciakampioPlotas(double a, double b)
        {
            double plotas = a * b;
            return plotas;
        }
    }
}