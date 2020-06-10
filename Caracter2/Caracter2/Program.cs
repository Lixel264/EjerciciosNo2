using System;

namespace Caracter2
{
    class Program
    {
        static void Main(string[] args)
        {
            string letra;
            Console.WriteLine("Presione una tecla");
            letra = Console.ReadLine();
            int lt = letra.Length;


            while (lt > 1)
            {
                    Console.WriteLine("ERROR, tienes que presionar solo una tecla");
                    Console.WriteLine("Vuelva a intentar y presione solo una tecla");
                    break;
            }

            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u" || letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U")
            {
                Console.WriteLine("La tecla que presionaste es una vocal");
            }
            else
            {
                if (letra == "0" || letra == "1" || letra == "2" || letra == "3" || letra == "4" || letra == "5" || letra == "6" || letra == "7" || letra == "8" || letra == "9")
                {
                    Console.WriteLine("La tecla que presionaste es una cifra númerica");
                    Console.WriteLine("La tecla que presionaste es una constante");
                }
                Console.ReadKey();
            }
        }
    }
}
