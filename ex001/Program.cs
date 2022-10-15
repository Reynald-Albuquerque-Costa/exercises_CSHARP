using System;

namespace ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Convert.ToString(Console.ReadLine());

            Console.WriteLine($"É um prazer te conhecer {nome} !");
        }
    }
}
