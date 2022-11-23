using System;

namespace ex037
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var total = 0;
            var parcela = 0;

            Console.WriteLine("Preço das compras: R$ ");
            int preco = int.Parse(Console.ReadLine());

            Console.WriteLine("FORMAS DE PAGAMENTO \r\n " +

                "[ 1 ] á vista dinheiro/cheque \r\n" +
                "[ 2 ] á vista cartão \r\n" +
                "[ 3 ] 2x no cartão \r\n" +
                "[ 4 ] 3x ou mais no cartão ");


            Console.WriteLine("Qual é a opção? ");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                total = preco - (preco * 10 / 100);
            }
            else if (opcao == 2)
            {
                total = preco - (preco * 5 / 100);
            }
            else if (opcao == 3)
            {
                total = preco;
                parcela = preco / 2;
                Console.WriteLine($"Sua compra será parcelada em 2x de {parcela.ToString("F2")} SEM JUROS ");
            }
            else if (opcao == 4)
            {
                total = preco + (preco * 20 / 100);

                Console.WriteLine("Quantas parcelas ");
                int totalParcela = int.Parse(Console.ReadLine());

                parcela = total / totalParcela;
                Console.WriteLine($"Sua compra de R$ {preco.ToString("F2")} será parcelada em {totalParcela}x de {parcela.ToString("F2")} COM 20% de JUROS");
            }


            Console.WriteLine($"Sua compra de R$ {preco.ToString("F2")} vai custar R$ {total.ToString("F2")} no final ");
        }
    }
}
