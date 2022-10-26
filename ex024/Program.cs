using System;

namespace ex024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a velocidadde atual do carro: ");
            double velocidade = Convert.ToDouble(Console.ReadLine());

            if (velocidade > 80)
            {
                Console.WriteLine("MULTADO! Velocidade acima da permitida que é 80 Km/h");
                Console.WriteLine($"Sua multa vai custar R$ {(velocidade - 80) * 7} reais");
            }
            
            Console.WriteLine("Tenha um bom dia! Dirija com segunrança!");

        }
    }
}
