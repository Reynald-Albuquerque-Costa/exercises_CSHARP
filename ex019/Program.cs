using System;

namespace ex019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número");
            double num = Convert.ToDouble(Console.ReadLine());

            var u = num % 10;
            var u1 = Math.Truncate(u);

            var d = (num / 10 ) % 10;
            var d1 = Math.Truncate(d);

            var c = (num / 100) % 10;
            var c1 = Math.Truncate(c);

            var m = (num / 1000) % 10;
            var m1 = Math.Truncate(m);

            Console.WriteLine($"Analisando o número {num} ...");
            Console.WriteLine($"Unidade: {u1}");
            Console.WriteLine($"Dezena: {d1}");
            Console.WriteLine($"Centena: {c1}");
            Console.WriteLine($"Milhar: {m1}");


        }
    }
}
