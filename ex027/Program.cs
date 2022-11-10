using System;

namespace ex027
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que ano quer analisar? ");
            int ano = Convert.ToInt32(Console.ReadLine());

            if(DateTime.IsLeapYear(ano))
            {
                Console.WriteLine($"O ano {ano} é BISSEXTO ");
            }
            else
            {
                Console.WriteLine($"O ano {ano} não é BISSEXTO");
            }
        }
    }
}
