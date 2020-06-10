using System;

namespace MenorDeDosN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Dame el primer valor ");
            n1 = Convert.ToInt32(Console.ReadLine());

            int n2;
            Console.WriteLine("Dame el segundo valor ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine(n1 + " es mayor que " + n2);
            }
            else
            {
                Console.WriteLine(n2 + " es mayor que " + n1);
            }
            Console.ReadKey();
        }
    }
}
