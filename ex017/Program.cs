using System;
using System.Collections.Generic;
using System.Linq;

namespace ex017
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
            var embaralhado = lista.OrderBy(item => rnd.Next());

            Console.WriteLine("A ordem de apresentação será: ");

            foreach (var value in embaralhado)
            {

                Console.WriteLine(value);
            }

        }
    }
}
