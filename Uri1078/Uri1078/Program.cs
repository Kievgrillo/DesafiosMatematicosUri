using System;

namespace Uri1078
{
    class Prgram
    {
        static void Main(string[] args)
        {
            int N; 

            N = int.Parse(Console.ReadLine());

            for (int i=1; i <= 10; i++)
            {
                int Resultado = i * N;
                Console.WriteLine( i + " x " + N + " = " + Resultado );
            }
        }
    }
}
