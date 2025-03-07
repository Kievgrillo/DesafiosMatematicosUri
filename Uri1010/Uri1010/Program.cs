using System;
using System.Globalization;

namespace Uri1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int CodigoPeca1, CodigoPeca2, NumeroPeca1, NumeroPeca2;
            Double ValorPeca1, ValorPeca2, ValorPago;

            string[] valores = Console.ReadLine().Split(' ');
            CodigoPeca1 = int.Parse(valores[0]);
            NumeroPeca1 = int.Parse(valores[1]);
            ValorPeca1 = Double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            CodigoPeca2 = int.Parse(valores[0]);
            NumeroPeca2 = int.Parse(valores[1]);
            ValorPeca2 = Double.Parse(valores[2], CultureInfo.InvariantCulture);

            ValorPago = NumeroPeca1 * ValorPeca1 + NumeroPeca2 * ValorPeca2;

            Console.WriteLine("VALOR A PAGAR: R$ " + ValorPago.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
