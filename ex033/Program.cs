using System;

namespace ex033
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anoAtual = DateTime.Now.Year;

            Console.WriteLine("Ano de nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            int idade = anoAtual - anoNascimento;

            Console.WriteLine($"Quem nasceu em {anoNascimento} tem {idade} anos em {anoAtual}");

            if (idade == 18)
            {
                Console.WriteLine("Você tem que se alistar IMEDIATAMENTE ");
            }
            else if(idade < 18)
            {
                int saldo = 18 - idade;
                int ano = anoAtual + saldo;
                Console.WriteLine($"Ainda faltam {saldo} anos para o alistamento ");
                Console.WriteLine($"Seu alistamento será em {ano} ");
            }
            else if(idade > 18)
            {
                int saldo = idade - 18;
                int ano = anoAtual - saldo;
                Console.WriteLine($"Você já deveria ter se alistato há {saldo} anos ");
                Console.WriteLine($"Seu alistamento foi em {ano} ");

            }
        }
    }
}
