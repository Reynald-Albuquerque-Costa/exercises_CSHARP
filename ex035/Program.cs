using System;

namespace ex035
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anoAtual = DateTime.Today.Year;

            Console.WriteLine("Ano de nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            int idade = anoAtual - anoNascimento;

            Console.WriteLine($"O atleta tem {idade} anos ");

            if (idade <= 9)
                Console.WriteLine("Classificação: MIRIM");
            else if (idade <= 14)
                Console.WriteLine("Classificação: INFANTIL");
            else if (idade <= 19)
                Console.WriteLine("Classificação: JUNIOR");
            else if (idade <= 25)
                Console.WriteLine("Classificação: SÊNIOR");
            else
                Console.WriteLine("Classificação: MASTER");
        }
    }
}
