using System;
using System.Globalization;

namespace Uri1012
{
    class Program
    {
        static void Main(string[] args)
        {
            Double A,B,C, AreaTriangulo, AreaCirculo, AreaTrapezio, AreaQuadrado, AreaRetangulo;

            string[] valores = Console.ReadLine().Split(' ');
            A = Double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = Double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = Double.Parse(valores[2], CultureInfo.InvariantCulture);

            AreaTriangulo = (A * C) / 2.0;
            AreaCirculo = 3.14159 * C * C;
            AreaTrapezio = (A + B) * C / 2.0;
            AreaQuadrado = (B * B);
            AreaRetangulo = (A * B);

            Console.WriteLine("TRIANGULO: " + AreaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + AreaCirculo.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + AreaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + AreaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + AreaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}

