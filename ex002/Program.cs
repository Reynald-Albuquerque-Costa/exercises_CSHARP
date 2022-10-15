using System;

namespace ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite outro valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            double soma = valor1 + valor2;

            Console.WriteLine($"A soma dos dois valores é {soma}");
        }
    }
}
