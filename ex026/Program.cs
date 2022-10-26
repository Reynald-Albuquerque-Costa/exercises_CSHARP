using System;

namespace ex026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a distância da viagem em Km? ");
            double distancia = Convert.ToInt32(Console.ReadLine());

            if(distancia <= 200)
            {
                Console.WriteLine($"Sua passagem será de R$ {(distancia * 0.50)} reais ");
            }
            else
            {
                Console.WriteLine($"Sua passagem será de R$ {distancia * 0.45} reais");
            }

            Console.WriteLine("Boa viagem !");
        }
    }
}
