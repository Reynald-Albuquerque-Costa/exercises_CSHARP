using System;

namespace ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o preço do produto? R$ ");
            double preco = Convert.ToDouble(Console.ReadLine());

            var desconto = preco - (preco * 0.05);

            Console.WriteLine($"O produto que custavo R${preco}, na promoção com desconto de 5% vai custar R${desconto}");

        }
    }
}
