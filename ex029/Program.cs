using System;

namespace ex029
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal novoSalario;

            Console.WriteLine("Qual é o salário do funcionário? R$ ");
            decimal salario = Convert.ToDecimal(Console.ReadLine());

            if(salario <= 1250)
            {
                novoSalario = salario + (salario * 15 / 100);
            }
            else
            {
                novoSalario = salario + (salario * 10 / 100);
            }

            Console.WriteLine($"Quem ganhava R$ {salario} passa a ganhar R$ {novoSalario} agora ");
        }
    }
}
