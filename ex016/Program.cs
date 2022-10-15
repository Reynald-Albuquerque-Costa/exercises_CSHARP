using System;
using System.Collections.Generic;

namespace ex016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeiro aluno: ");
            string n1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Segundo aluno: ");
            string n2 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Terceiro aluno: ");
            string n3 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Quarto aluno: ");
            string n4 = Convert.ToString(Console.ReadLine());

            var lista = new List<string> { n1, n2, n3, n4 };

            var rnd = new Random();
            var escolhido = lista[rnd.Next(lista.Count)];

            Console.WriteLine($"O aluno sorteado foi {escolhido}");

        }
    }
}
