using System;

namespace Uri1071
{
    class Prgram
    {
        static void Main(string[] args)
        {
            int X, Y, Max, Min, Soma;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            if (X < Y)
            {
                Min = X;
                Max = Y;
            }
            else
            {
                Min = Y;
                Max = X;
            }

            Soma = 0;
            for (int i = Min + 1; i < Max; i++)
            {
                if (i % 2 != 0)
                {
                    Soma = Soma + i;
                }
            }
            Console.WriteLine(Soma);
        }
    }
}
