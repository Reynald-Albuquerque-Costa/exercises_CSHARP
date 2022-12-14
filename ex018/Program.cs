using System;
using System.Linq;

namespace ex018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu primero nome: ");
            string nome1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite seu sobrenome completo: ");
            string nome2 = Convert.ToString(Console.ReadLine());

            var tiraEspaco1 = nome1.Trim();
            var tiraEspaco2 = nome2.Trim();
            var juncao = tiraEspaco1 + " " + tiraEspaco2;
            var jReplace = juncao.Trim();

            string n1 = nome1.Replace(" ", "");
            string n2 = nome2.Replace(" ", "");

            var total = n1 + n2;

            Console.WriteLine("Analisando seu nome ...");
            Console.WriteLine($"Seu nome em maíusculo é {jReplace.ToUpper()}");
            Console.WriteLine($"Seu nome em munúsculo é {jReplace.ToLower()}");
            Console.WriteLine($"Seu nome tem ao todo {total.Count()} letras");
            Console.WriteLine($"Seu primeiro nome tem {n1.Count()} letras");

        }
    }
}
