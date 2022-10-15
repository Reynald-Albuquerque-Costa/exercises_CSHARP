using System;

namespace ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeira nota: ");
            double p1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Segunda nota: ");
            double p2 = Convert.ToDouble(Console.ReadLine());

            double m = (p1 + p2) / 2;

            Console.WriteLine($"A média entre {p1} e {p2} é igual a {m}");
        }
    }
}
