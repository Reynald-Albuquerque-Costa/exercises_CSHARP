using System;

namespace ex034
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeira nota: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segunda nota: ");
            float n2 = float.Parse(Console.ReadLine());

            var media = (n1 + n2) / 2;

            Console.WriteLine($"Tirando {n1} e {n2}. A média do aluno é {media}");

            if (media >= 5 && media < 7)
            {
                Console.WriteLine("RECUPERAÇÃO ");
            }
            else if(media < 5)
            {
                Console.WriteLine("REPROVADO ");
            }
            else if(media >= 7)
            {
                Console.WriteLine("APROVADO ");
            }
        }
    }
}
