using System;

namespace ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uma distância em metros: ");
            double m = Convert.ToDouble(Console.ReadLine());

            double cm = m * 100;
            double mm = m * 1000;
            double km = m / 1000;
            double dam = m / 10;

            Console.WriteLine($"A medida de {m}m corresponde a {cm}cm, {mm}m, {km}km e {dam}dam ");
        }
    }
}
