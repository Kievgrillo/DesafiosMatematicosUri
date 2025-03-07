using System;
using System.Globalization;

namespace Uri1017
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Tempo, VelMedia;
            Double Litros;

            Tempo = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            VelMedia = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Litros = (Tempo * VelMedia) / 12;

            Console.WriteLine(Litros.ToString("F3" , CultureInfo.InvariantCulture));
        }
    }
}
