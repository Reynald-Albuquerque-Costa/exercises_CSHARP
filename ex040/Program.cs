using System;

namespace ex040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int x = 0; x <= 50 ; x++)
            {
                if(x % 2 == 0)
                    Console.WriteLine(x);
            }
        }
    }
}
