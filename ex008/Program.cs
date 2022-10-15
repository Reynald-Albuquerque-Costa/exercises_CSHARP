using System;

namespace ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanto de dinheiro você tem na carteira? R$");
            double din = Convert.ToDouble(Console.ReadLine());

            double dol = din / 5.20;

            Console.WriteLine($"Com R${din} você pode comprar US${dol}");
        }
    }
}
