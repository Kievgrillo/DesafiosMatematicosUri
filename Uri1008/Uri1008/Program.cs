using System;
using System.Globalization;

namespace Uri1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumeroFuncionario, NumeroHoraTrabalha;
            Double ValorHora, SalarioFuncionario;

            NumeroFuncionario = int.Parse(Console.ReadLine());
            NumeroHoraTrabalha = int.Parse(Console.ReadLine());
            ValorHora = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            SalarioFuncionario = NumeroHoraTrabalha * ValorHora;

            Console.WriteLine("NUMBER = " + NumeroFuncionario);
            Console.WriteLine("SALARY = U$ " + SalarioFuncionario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

