using System;

namespace ex028
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeiro valor: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Terceiro valor: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Verificando quem é o menor
            var menor = a;
            if(b < a && b < c)
            {
                menor = b;
            }
            if(c < a && c < b)
            {
                menor = c;
            }

            // Verificando que é o maior
            var maior = a;
            if(b > a && b > c)
            {
                maior = b;
            }
            if(c > a && c > b)
            {
                maior = c;
            }

            Console.WriteLine($"O menor valor digitado foi {menor}");
            Console.WriteLine($"O maior valor digitado foi {maior}");
        }
    }
}
