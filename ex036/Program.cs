using System;

namespace ex036
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite seu peso: ");
            float peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            float altura = float.Parse(Console.ReadLine());


            Console.WriteLine("Seu peso é " + peso);
            Console.WriteLine("Sua altura é " + altura);


            var imc = peso / (Math.Pow(altura, 2));

            if (imc < 18.5)
                Console.WriteLine("Abaixo do peso");
            else if (imc > 18.5 && imc < 25)
                Console.WriteLine("Peso ideal");
            else if (imc <= 30)
                Console.WriteLine("Sobrepeso");
            else if (imc > 30 && imc < 40)
                Console.WriteLine("Obesidade");
            else
                Console.WriteLine("Obesidade mórbida");
        }
    }
}
