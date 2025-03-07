using System;
using System.Globalization;

namespace Uri1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int Distancia;
            Double Combustivel, ConsumoMedio;

            Distancia = int.Parse(Console.ReadLine());
            Combustivel = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ConsumoMedio = Distancia/Combustivel;

            Console.WriteLine(ConsumoMedio.ToString("F3", CultureInfo.InvariantCulture ) + " km/l");

        }
    }
}
