using System;

namespace ex020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Em que cidade você nasceu? ");
            string cid = Convert.ToString(Console.ReadLine());   

            var cidade = cid.Trim();

            Console.WriteLine(cidade.Substring(0, 3).ToUpper() == "SÃO");
        }
    }
}
