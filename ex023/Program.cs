using System;
using System.Collections.Generic;
using System.Threading;

namespace ex023
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var lista = new List<int> { 0, 1, 2, 3, 4, 5 };

            var rnd = new Random();
            var computador = lista[rnd.Next(lista.Count)]; 

            Console.WriteLine(new String('*', 40));
            Console.WriteLine("Vou pensar em um número entre 0 a 5.Tente adivinhar .... \n");
            Console.WriteLine(new String('*', 40));

            Console.WriteLine("Em que número eu pensei? ");
            int jogador = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("PROCESSANDO ....... ");
            Thread.Sleep(3000);
            if (jogador == computador)
            {
                Console.WriteLine("Parabénsss! você acertou! ");
            }
            else
            {
                Console.WriteLine($"Errou! Eu pensei no número {computador} e não no {jogador}");
                Console.WriteLine("Tente novamente !");
            }


        }
    }
}
