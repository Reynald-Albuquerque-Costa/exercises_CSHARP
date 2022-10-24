using System;
using System.Linq;

namespace ex022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome completo: ");
            string nomeCompleto = Convert.ToString(Console.ReadLine());

            string[] nome = nomeCompleto.Split(' ');

            Console.WriteLine("Muito prazer em te conhcer !");
            Console.WriteLine($"Seu primeiro nome é {nome[0]}");
            Console.WriteLine($"Seu último nome é {nome[nome.Length - 1]}");



        }
    }
}
