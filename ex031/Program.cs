using System;

namespace ex031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o valor da casa? R$");
            decimal valorCasa = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Salário do comprador? R$");
            decimal salarioComprador = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Quantos anos quer pagar? ");
            int anos = int.Parse(Console.ReadLine());

            var prestacao = valorCasa / (anos * 12);
            var minimo = salarioComprador * 30 / 100;

            Console.WriteLine($"Para pagar uma casa de R$ {valorCasa} em {anos} anos, a prestação será de {prestacao.ToString("F2")}");
            
            if(prestacao <= minimo)
            {
                Console.WriteLine("Empréstimo pode ser CONCEDIDO !");
            }
            else
            {
                Console.WriteLine("Empréstimo NEGADO !");
            }
        }
    }
}
