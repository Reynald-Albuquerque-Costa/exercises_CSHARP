using System;

namespace ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanto de dinheiro você tem na carteira? R$");
            decimal din = Convert.ToDecimal(Console.ReadLine());

            decimal dol = din / 5.20M;

            Console.WriteLine($"Com R$ {din} você pode comprar US$ {dol.ToString("F2")}");
        }
    }
}
