using System;

namespace ex041
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Soma entre todos os números impares que são múltiplos de três e que se encontram em um intervalo de 1 a 500

            int soma = 0;

            for(int x = 1; x <= 500; x++)
            {
                if(x % 2 != 0)
                    if(x % 3 == 0)
                        soma += x;
            }

            Console.WriteLine($"A soma de todos os valores solicitados é {soma}");
        }
    }
}
