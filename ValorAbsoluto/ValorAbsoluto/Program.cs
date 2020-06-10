using System;

namespace ValorAbsoluto
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Escribe un numero");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine(numero);
                Console.WriteLine("La conversion es " + numero * -1);
            }
            else
            {
                Console.WriteLine(numero);
                Console.WriteLine("La conversion es " + numero * -1);
            }
            Console.ReadKey();
            
        }
    }
}
