using System;

namespace ex021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome completo?");
            string nomeCompleto = Convert.ToString(Console.ReadLine());

            Console.WriteLine($"Seu nome tem Silva? {nomeCompleto.Contains("Silva")}");
        }
    }
}
