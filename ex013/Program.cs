using System;

namespace ex013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            double num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"O número {num} tem a parte inteira {Math.Truncate(num)}");
        }
    }
}
