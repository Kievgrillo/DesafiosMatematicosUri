using System; 

namespace Uri1007
{
    class Program
    {
        static void Main(string[] args)
        {
            Double A, B, C, D, Diferenca;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
            D = double.Parse(Console.ReadLine());

            Diferenca = (A * B - C * D);

            Console.WriteLine("DIFERENCA = " + Diferenca);
        }
    }
}