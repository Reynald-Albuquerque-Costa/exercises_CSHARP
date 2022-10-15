using System;

namespace ex015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digita o ângulo que você deseja: ");
            double angulo = Convert.ToDouble(Console.ReadLine());

            double seno = Math.Sin(angulo * (Math.PI / 180));
            double cosseno = Math.Cos(angulo * (Math.PI / 180));
            double tangente = Math.Tan(angulo * (Math.PI / 180));

            Console.WriteLine($"O ângulo de {angulo} tem o SENO de {seno.ToString("F2")} ");
            Console.WriteLine($"O ângulo de {angulo} tem o COSSENO de {cosseno.ToString("F2")} ");
            Console.WriteLine($"O ângulo de {angulo} tem o TANGENTE de {tangente.ToString("F2")} ");

        }
    }
}
