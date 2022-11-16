using System;

namespace ex030
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeiro segmento: ");
            double r1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Segundo segmento: ");
            double r2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Terceiro segmento: ");
            double r3 = Convert.ToDouble(Console.ReadLine());

            if(r1 < r2 + r3 && r2 < r1 + r3 && r3 < r1 + r2)
            {
                Console.WriteLine("Os segmentos acima PODEM FORMAR um triângulo!");
            }
            else
            {
                Console.WriteLine("Os segmentos acima NÃO PODEM FORMAR um triângulo");
            }
        }
    }
}
