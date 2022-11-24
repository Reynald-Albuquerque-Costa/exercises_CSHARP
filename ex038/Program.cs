using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ex038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sua opção: ");
            Console.WriteLine("[ 0 ] PEDRA \r\n" +
                              "[ 1 ] PAPEL \r\n" +
                              "[ 2 ] TESOURA ");

            Console.WriteLine("Qual é a sua jogada? ");
            int jogador = int.Parse(Console.ReadLine());

            Console.WriteLine("JO");
            Thread.Sleep(1000);

            Console.WriteLine("KEN");
            Thread.Sleep(1000);

            Console.WriteLine("PO !!");
            Thread.Sleep(1000);

            var itens = new List<string> { "PEDRA", "PAPEL", "TESOURA" };

            // Sortea qual número o computador vai jogar
            var rnd = new Random();
            var computador = rnd.Next(itens.Count);

            Console.WriteLine(new String('=', 30));

            Console.WriteLine($"O computador escolheu {itens[computador]} ");
            Console.WriteLine($"O jogador escolheu {itens[jogador]}  ");

            Console.WriteLine(new String('=', 30));

            if (computador == 0) // Computador jogou PEDRA
            {
                if (jogador == 0)
                    Console.WriteLine("EMPATE");
                else if (jogador == 1)
                    Console.WriteLine("JOGADOR VENCE");
                else if (jogador == 2)
                    Console.WriteLine("COMPUTADOR VENCE");
                else
                    Console.WriteLine("JOGADA INVÁLIDA");
                
            }
            else if (computador == 1) // Computador jogou PAPEL
            {
                if (jogador == 0)
                    Console.WriteLine("COMPUTADOR VENCE");
                else if (jogador == 1)
                    Console.WriteLine("EMPATE");
                else if (jogador == 2)
                    Console.WriteLine("JOGADOR VENCE");
                else
                    Console.WriteLine("JOGADA INVÁLIDA");
            }
            else if (computador == 2) // Computador jogou TESOURA
            {
                if (jogador == 0)
                    Console.WriteLine("JOGADOR VENCE");
                else if (jogador == 1)
                    Console.WriteLine("COMPUTADOR VENCE");
                else if (jogador == 2)
                    Console.WriteLine("EMPATE");
                else
                    Console.WriteLine("JOGADA INVÁLIDA");
            }
        }
    }
}
