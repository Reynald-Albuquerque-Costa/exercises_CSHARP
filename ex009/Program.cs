using System;

namespace ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Largura da parede: ");
            double lar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Altura da parede: ");
            double alt = Convert.ToDouble(Console.ReadLine());

            var area = lar * alt;

            var tinta = area / 2;

            Console.WriteLine($"Sua parde tem a dimensão de {lar}x{alt} e sua área é de {area}m2");
            Console.WriteLine($"Para pintar sua parede, você precisára de {tinta}l de tinta.");
        }
    }
}
