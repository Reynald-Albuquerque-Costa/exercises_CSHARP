using System;
using System.Threading;

namespace ex039
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Contagem regressiva 

            for (int x = 0; x <= 10; x++)
            {
                var total = 10 - x;
                Console.WriteLine(total);
                Thread.Sleep(1000);
            }
        }
    }
}
