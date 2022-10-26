using System;

namespace ex025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine($"O número {num} é PAR !");
            }
            else
            {
                Console.WriteLine($"O número {num} é ÍMPAR !");
            }
        }
    }
}
