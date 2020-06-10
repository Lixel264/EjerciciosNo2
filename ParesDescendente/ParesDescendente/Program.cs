using System;

namespace ParesDescendente
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 23;

            n1 = 22;

            while (n1 > 7)
            {
                Console.WriteLine(n1); n1 -= 2;
            }
        }
    }
}
