using System;

namespace ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            double num = Convert.ToDouble(Console.ReadLine());

            double d = num * 2;
            double t = num * 3;
            double r = Math.Sqrt(num);

            Console.WriteLine($"O dobro de {num} é {d}");
            Console.WriteLine($"O triplo de {num} é {t}");
            Console.WriteLine($"A raiz quadra de {num} é {r}");
        }
    }
}
