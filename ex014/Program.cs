using System;

namespace ex014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comprimento do cateto oposto: ");
            double co = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Comprimento do cato adjacente: ");
            double ca = Convert.ToDouble(Console.ReadLine());

            var soma = Math.Pow(co, 2) + Math.Pow(ca, 2);
            var hi = Math.Sqrt(soma);

            Console.WriteLine($"A hipotenusa vai medir {hi}");

        }
    }
}
