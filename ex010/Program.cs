using System;

namespace ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o preço do produto? R$ ");
            decimal preco = Convert.ToDecimal(Console.ReadLine());

            decimal desconto = preco - (preco * 0.05M);

            Console.WriteLine($"O produto que custava R${preco}, na promoção com desconto de 5% vai custar R${desconto.ToString("F2")}");

        }
    }
}
