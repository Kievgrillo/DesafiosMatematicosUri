using System;
using System.Globalization;

namespace Uri1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            Double SalarioFixo, TotalVendas, SalarioFinal;

            Nome = Console.ReadLine();
            SalarioFixo = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            TotalVendas = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            SalarioFinal = SalarioFixo + (TotalVendas * 0.15);

            Console.WriteLine("TOTAL = R$ " + SalarioFinal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
