using System;
using System.Diagnostics.Tracing;
using System.Globalization;

namespace Uri1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, meses, anos, dias, resto;

            X = int.Parse(Console.ReadLine());

            anos = X / 365;
            resto = X % 365;
            meses = resto / 30;
            dias = resto % 30;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}