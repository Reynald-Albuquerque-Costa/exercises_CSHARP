using System;

namespace ex011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o salário do funcionário? R$ ");
            decimal salario = Convert.ToDecimal(Console.ReadLine());

            decimal aumento = salario + (salario * 0.15M);

            Console.WriteLine($"Um funcionário que ganhava R${salario}, com um aumento de 15%, passa a receber R${aumento.ToString("F2")}");

        }
    }
}
