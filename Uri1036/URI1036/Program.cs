using System;

using System.Globalization;
using System.Text.RegularExpressions;

namespace Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Delta, A,B,C, r1, r2;

            String[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Delta = Math.Pow(B, 2.0) - 4 * A * C;

            if (A == 0 || Delta < 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            } 
            else
            {
                r1 = (-B + Math.Sqrt(Delta)) / (2.0 * A);
                r2 = (-B - Math.Sqrt(Delta)) / (2.0 * A);
                Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}