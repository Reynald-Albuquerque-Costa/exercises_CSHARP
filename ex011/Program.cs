using System;

namespace ex011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o salário do funcionário? R$ ");
            double salario = Convert.ToDouble(Console.ReadLine());

            var aumento = salario + (salario * 0.15);

            Console.WriteLine($"Um funcionário que ganhava R${salario}, com um aumento de 15%, passa a receber R${aumento}");

        }
    }
}
