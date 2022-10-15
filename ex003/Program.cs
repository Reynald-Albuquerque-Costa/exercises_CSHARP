using System;

namespace ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            double num = Convert.ToDouble(Console.ReadLine());

            double antecessor = num - 1;
            double sucessor = num + 1;

            Console.WriteLine($"Analisando o valor {num}, seu antecessor é {antecessor} e seu sucessor é {sucessor}");
        }
    }
}
