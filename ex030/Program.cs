using System;

namespace ex030
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeiro segmento: ");
            float r1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo segmento: ");
            float r2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Terceiro segmento: ");
            float r3 = float.Parse(Console.ReadLine());

            if (r1 < r2 + r3 && r2 < r1 + r3 && r3 < r1 + r2)
            {
                Console.WriteLine("Os segmentos acima PODEM FORMAR um triângulo! ");
                if (r1 == r2 && r2 == r3)
                    Console.WriteLine("EQUILÁTERO! ");
                else if (r1 != r2 && r2 != r3 && r3 != r1)
                    Console.WriteLine("ESCALENO! ");
                else
                    Console.WriteLine("ISÓSCELES! ");
            }
            else
            {
                Console.WriteLine("Os segmentos acima NÃO PODEM FORMAR um triângulo");
            }
        }
    }
}
