using System;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double[] vect = new double[n];

            for(int i = 0; i < n; i++)
            {
                vect[i] = Convert.ToDouble(Console.ReadLine());
            }

            double sum = 0.0;
            for(int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double media = sum / n;

            Console.WriteLine($"A médias das alturas é igual {media}");
        }
    }
}