using System;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperatur={4.5, 3.2, 6.7, 6.1, 2.1, 1.6, 2.9};
            double summa= 0;
            foreach (double e in temperatur)
            {
                summa += e;
            }
            double result=(summa/temperatur.Length);
            Console.WriteLine(Math.Round(result,2));
        }
    }
}
