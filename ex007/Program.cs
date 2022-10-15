using System;

namespace ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para ver sua tabuada: ");
            double num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(new String('-', 8));

            for (int x = 0; x <= 10; x++)
            {
                double result = num * x;
                Console.WriteLine(num + "X" + x + "=" + result);
            }

            Console.WriteLine(new String('-', 8));
        }
    }
}
