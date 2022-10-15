using System;

namespace ex012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos dias alugado? ");
            double dias = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quantos Km rodados? ");
            double km = Convert.ToDouble(Console.ReadLine());

            var pdias = dias * 60;
            var pkm = km * 0.15;
            var total = pdias + pkm;

            Console.WriteLine($"O total a pagar é de R$ {total}");
        }
    }
}
