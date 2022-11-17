using System;
using System.Linq.Expressions;

namespace ex032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeiro valor: ");
            float primeiro = float.Parse(Console.ReadLine());

            Console.WriteLine("Segunda valor: ");
            float segundo = float.Parse(Console.ReadLine());

            if(primeiro > segundo)
            {
                Console.WriteLine("O PRIMEIRO é maior ");
            }
            else if(primeiro == segundo)
            {
                Console.WriteLine("Os valores são IGUAIS");
            }
            else
            {
                Console.WriteLine("O SEGUNDO valor é maior ");
            }
        }
    }
}
